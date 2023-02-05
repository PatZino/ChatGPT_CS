using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using static System.Net.WebRequestMethods;

namespace ChatGPTCS
{
    public partial class ChatGPT : Form
    {
        string OPENAI_API_KEY = ""; // https://beta.openai.com/account/api-keys
        SpeechRecognitionEngine oSpeechRecognitionEngine = null;
        System.Speech.Synthesis.SpeechSynthesizer oSpeechSynthesizer = null;

        public ChatGPT()
        {
            InitializeComponent();
        }
        private void ChatGPT_Load(object sender, EventArgs e)
        {
            AppSettingsReader oAppSettingsReader = new AppSettingsReader();
            string sApiKey = oAppSettingsReader.GetValue("OPENAI_API_KEY", typeof(string)) + "";

            if (sApiKey == "")
            {
                MessageBox.Show("Please enter your OpenAI API key in the App.config file.");
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                OPENAI_API_KEY = sApiKey;
            }
                        
            //SetModels();
            cbModel.SelectedIndex = 0;

            cbVoice.Items.Clear();
            SpeechSynthesizer synth = new SpeechSynthesizer();
            foreach (var voice in synth.GetInstalledVoices())
                cbVoice.Items.Add(voice.VoiceInfo.Name);
            cbVoice.SelectedIndex = 0;
        }

        private void chkListen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkListen.Checked)
            {
                lblSpeech.Text = "";
                lblSpeech.Visible = true;
                SpeechToText();
            }
            else
            {
                oSpeechRecognitionEngine.RecognizeAsyncStop();
                lblSpeech.Visible = false;
            }
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMute.Checked)
            {
                lblVoice.Visible = false;
                cbVoice.Visible = false;
            }
            else
            {
                lblVoice.Visible = true;
                cbVoice.Visible = true;
            }
        }

        private void SpeechToText()
        {
            if (oSpeechRecognitionEngine != null)
            {
                oSpeechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                return;
            }

            oSpeechRecognitionEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            oSpeechRecognitionEngine.LoadGrammar(new DictationGrammar());
            oSpeechRecognitionEngine.SpeechRecognized += OnSpeechRecognized;
            oSpeechRecognitionEngine.SpeechHypothesized += OnSpeechHypothesized;
            oSpeechRecognitionEngine.SetInputToDefaultAudioDevice();
            oSpeechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void OnSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            lblSpeech.Text = ""; // Reset Hypothesized text

            if (txtQuestion.Text != "")
                txtQuestion.Text += "\n";

            string text = e.Result.Text;
            txtQuestion.Text += text;
        }

        private void OnSpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            string text = e.Result.Text;
            lblSpeech.Text = text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            {

                string sQuestion = txtQuestion.Text;
                if (string.IsNullOrEmpty(sQuestion))
                {
                    MessageBox.Show("Type in your question!");
                    txtQuestion.Focus();
                    return;
                }

                if (txtAnswer.Text != "")
                {
                    txtAnswer.AppendText("\r\n");
                }

                txtAnswer.AppendText("Me: " + sQuestion + "\r\n");
                txtQuestion.Text = "";

                try
                {
                    string sAnswer = SendMsg(sQuestion);
                    txtAnswer.AppendText("Chat GPT: " + sAnswer.Replace( "\n", "\r\n"));
                    SpeechToText(sAnswer);
                }
                catch (Exception ex)
                {
                    txtAnswer.AppendText("Error: " + ex.Message);
                }
            }
            
        }

        public void SpeechToText(string s)
        {
            if (chkMute.Checked)
                return;

            if (oSpeechSynthesizer == null)
            {
                oSpeechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
                oSpeechSynthesizer.SetOutputToDefaultAudioDevice();
            }

            if (cbVoice.Text != "")
                oSpeechSynthesizer.SelectVoice(cbVoice.Text);

            oSpeechSynthesizer.Speak(s);
        }
        
        public string SendMsg(string sQuestion)
        {

            System.Net.ServicePointManager.SecurityProtocol = 
                System.Net.SecurityProtocolType.Ssl3 | 
                System.Net.SecurityProtocolType.Tls12 | 
                System.Net.SecurityProtocolType.Tls11 | 
                System.Net.SecurityProtocolType.Tls;
            
            string apiEndpoint = "https://api.openai.com/v1/completions";
            var request = WebRequest.Create(apiEndpoint);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + OPENAI_API_KEY);

            int iMaxTokens = int.Parse( txtMaxTokens.Text); // 2048

            double dTemperature = double.Parse(txtTemperature.Text); // 0.5
            if (dTemperature < 0d | dTemperature > 1d)
            {
                MessageBox.Show("Randomness has to be between 0 and 1 with higher values resulting in more random text");
                return "";
            }

            string sUserId = txtUserID.Text; // 1
            string sModel = cbModel.Text; // text-davinci-002, text-davinci-003

            string data = "{";
            data += " \"model\":\"" + sModel + "\",";
            data += " \"prompt\": \"" + PadQuotes(sQuestion) + "\",";
            data += " \"max_tokens\": " + iMaxTokens + ",";
            data += " \"user\": \"" + sUserId + "\", ";
            data += " \"temperature\": " + dTemperature + ", ";
            data += " \"frequency_penalty\": 0.0" + ", "; // Number between -2.0 and 2.0  Positive value decrease the model's likelihood to repeat the same line verbatim.
            data += " \"presence_penalty\": 0.0" + ", "; // Number between -2.0 and 2.0. Positive values increase the model's likelihood to talk about new topics.
            data += " \"stop\": [\"#\", \";\"]"; // Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.
            data += "}";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }
            
            var response = request.GetResponse();
            var streamReader = new StreamReader(response.GetResponseStream());
            string sJson = streamReader.ReadToEnd();
            // Return sJson

            var oJavaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            Dictionary<string, object> oJson = (Dictionary<string, object>) oJavaScriptSerializer.DeserializeObject(sJson);
            Object[] oChoices = (Object[])oJson["choices"];
            Dictionary<string, object> oChoice = (Dictionary<string, object>) oChoices[0];
            string sResponse = (string) oChoice["text"];

            return sResponse;

        }

        private string PadQuotes(string s)
        {
            if (s.IndexOf("\\") != -1)
                s = s.Replace("\\", @"\\");
                    
            if (s.IndexOf("\n\r") != -1)
                s = s.Replace("\n\r", @"\n");

            if (s.IndexOf("\r") != -1)
                s = s.Replace("\r", @"\r");

            if (s.IndexOf("\n") != -1)
                s = s.Replace("\n", @"\n");

            if (s.IndexOf("\t") != -1)
                s = s.Replace("\t", @"\t");
            
            if (s.IndexOf("\"") != -1)
                return s.Replace("\"", @"""");
            else
                return s;
        }
        
        private void SetModels()
        {
            // https://beta.openai.com/docs/models/gpt-3

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3 | System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;

            string apiEndpoint = "https://api.openai.com/v1/models";
            var  request = WebRequest.Create(apiEndpoint);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + OPENAI_API_KEY);

            var response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            string sJson = streamReader.ReadToEnd();

            cbModel.Items.Clear();

            SortedList oSortedList = new SortedList();
            System.Web.Script.Serialization.JavaScriptSerializer oJavaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            Dictionary<string, object> oJson = (Dictionary<string, object>)oJavaScriptSerializer.DeserializeObject(sJson);
            Object[] oList = (Object[])oJson["data"];
            for (int i = 0; i <= oList.Length - 1; i++)
            {
                Dictionary<string, object> oItem = (Dictionary<string, object>)oList[i];
                string sId = (String) oItem["id"];
                if (oSortedList.ContainsKey(sId) == false)
                {
                    oSortedList.Add(sId, sId);
                }                
            }

            foreach (DictionaryEntry oItem in oSortedList)
                cbModel.Items.Add(oItem.Key);
        }


    }
}
