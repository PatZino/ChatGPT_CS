namespace ChatGPTCS
{
    partial class ChatGPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.txtMaxTokens = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.lblSpeech = new System.Windows.Forms.Label();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.chkListen = new System.Windows.Forms.CheckBox();
            this.lblVoice = new System.Windows.Forms.Label();
            this.cbVoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(542, 313);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 17);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Max tokens";
            // 
            // txtMaxTokens
            // 
            this.txtMaxTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaxTokens.Location = new System.Drawing.Point(628, 310);
            this.txtMaxTokens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxTokens.Name = "txtMaxTokens";
            this.txtMaxTokens.Size = new System.Drawing.Size(89, 22);
            this.txtMaxTokens.TabIndex = 16;
            this.txtMaxTokens.Text = "2048";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(327, 313);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 17);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Randomness";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTemperature.Location = new System.Drawing.Point(425, 310);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(89, 22);
            this.txtTemperature.TabIndex = 14;
            this.txtTemperature.Text = "0.5";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(149, 313);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 17);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserID.Location = new System.Drawing.Point(212, 310);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(89, 22);
            this.txtUserID.TabIndex = 12;
            this.txtUserID.Text = "1";
            // 
            // txtAnswer
            // 
            this.txtAnswer.AcceptsReturn = true;
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Location = new System.Drawing.Point(11, 10);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer.Size = new System.Drawing.Size(1044, 274);
            this.txtAnswer.TabIndex = 11;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Location = new System.Drawing.Point(11, 383);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(1044, 97);
            this.txtQuestion.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(11, 287);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 44);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(744, 313);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 17);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Model";
            // 
            // cbModel
            // 
            this.cbModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "text-davinci-003",
            "text-davinci-002",
            "code-davinci-002"});
            this.cbModel.Location = new System.Drawing.Point(796, 309);
            this.cbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(259, 24);
            this.cbModel.TabIndex = 18;
            // 
            // lblSpeech
            // 
            this.lblSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpeech.AutoSize = true;
            this.lblSpeech.Location = new System.Drawing.Point(15, 352);
            this.lblSpeech.Name = "lblSpeech";
            this.lblSpeech.Size = new System.Drawing.Size(66, 17);
            this.lblSpeech.TabIndex = 24;
            this.lblSpeech.Text = "speech...";
            this.lblSpeech.Visible = false;
            // 
            // chkMute
            // 
            this.chkMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(624, 344);
            this.chkMute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(61, 21);
            this.chkMute.TabIndex = 23;
            this.chkMute.Text = "Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            this.chkMute.CheckedChanged += new System.EventHandler(this.chkMute_CheckedChanged);
            // 
            // chkListen
            // 
            this.chkListen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkListen.AutoSize = true;
            this.chkListen.Location = new System.Drawing.Point(421, 345);
            this.chkListen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkListen.Name = "chkListen";
            this.chkListen.Size = new System.Drawing.Size(68, 21);
            this.chkListen.TabIndex = 22;
            this.chkListen.Text = "Listen";
            this.chkListen.UseVisualStyleBackColor = true;
            this.chkListen.CheckedChanged += new System.EventHandler(this.chkListen_CheckedChanged);
            // 
            // lblVoice
            // 
            this.lblVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVoice.AutoSize = true;
            this.lblVoice.Location = new System.Drawing.Point(744, 346);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(43, 17);
            this.lblVoice.TabIndex = 21;
            this.lblVoice.Text = "Voice";
            // 
            // cbVoice
            // 
            this.cbVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoice.FormattingEnabled = true;
            this.cbVoice.Location = new System.Drawing.Point(796, 344);
            this.cbVoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVoice.Name = "cbVoice";
            this.cbVoice.Size = new System.Drawing.Size(259, 24);
            this.cbVoice.TabIndex = 20;
            // 
            // ChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 490);
            this.Controls.Add(this.lblSpeech);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.chkListen);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.cbVoice);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtMaxTokens);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChatGPT";
            this.Text = "Chat GPT";
            this.Load += new System.EventHandler(this.ChatGPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtMaxTokens;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtTemperature;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.TextBox txtAnswer;
        internal System.Windows.Forms.TextBox txtQuestion;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cbModel;
        internal System.Windows.Forms.Label lblSpeech;
        internal System.Windows.Forms.CheckBox chkMute;
        internal System.Windows.Forms.CheckBox chkListen;
        internal System.Windows.Forms.Label lblVoice;
        internal System.Windows.Forms.ComboBox cbVoice;
    }
}

