namespace VegasScriptAssignVideoEventFromAudioEvent
{
    partial class VegasScriptSettingDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTrackNameBox = new System.Windows.Forms.TextBox();
            this.searchTrackNameLabel = new System.Windows.Forms.Label();
            this.marginLabel = new System.Windows.Forms.Label();
            this.marginBox = new System.Windows.Forms.TextBox();
            this.millisecondLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.millisecondLabel);
            this.panel1.Controls.Add(this.marginBox);
            this.panel1.Controls.Add(this.marginLabel);
            this.panel1.Controls.Add(this.searchTrackNameLabel);
            this.panel1.Controls.Add(this.searchTrackNameBox);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 55);
            this.panel1.TabIndex = 0;
            // 
            // searchTrackNameBox
            // 
            this.searchTrackNameBox.Location = new System.Drawing.Point(111, 4);
            this.searchTrackNameBox.Name = "searchTrackNameBox";
            this.searchTrackNameBox.Size = new System.Drawing.Size(198, 19);
            this.searchTrackNameBox.TabIndex = 0;
            // 
            // searchTrackNameLabel
            // 
            this.searchTrackNameLabel.AutoSize = true;
            this.searchTrackNameLabel.Location = new System.Drawing.Point(10, 7);
            this.searchTrackNameLabel.Name = "searchTrackNameLabel";
            this.searchTrackNameLabel.Size = new System.Drawing.Size(72, 12);
            this.searchTrackNameLabel.TabIndex = 1;
            this.searchTrackNameLabel.Text = "対象トラック名";
            // 
            // marginLabel
            // 
            this.marginLabel.AutoSize = true;
            this.marginLabel.Location = new System.Drawing.Point(10, 32);
            this.marginLabel.Name = "marginLabel";
            this.marginLabel.Size = new System.Drawing.Size(89, 12);
            this.marginLabel.TabIndex = 2;
            this.marginLabel.Text = "字幕側のマージン";
            // 
            // marginBox
            // 
            this.marginBox.Location = new System.Drawing.Point(111, 29);
            this.marginBox.Name = "marginBox";
            this.marginBox.Size = new System.Drawing.Size(76, 19);
            this.marginBox.TabIndex = 3;
            // 
            // millisecondLabel
            // 
            this.millisecondLabel.AutoSize = true;
            this.millisecondLabel.Location = new System.Drawing.Point(193, 32);
            this.millisecondLabel.Name = "millisecondLabel";
            this.millisecondLabel.Size = new System.Drawing.Size(31, 12);
            this.millisecondLabel.TabIndex = 4;
            this.millisecondLabel.Text = "ミリ秒";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(160, 63);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(241, 63);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cansel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // VegasScriptSettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 89);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.panel1);
            this.Name = "VegasScriptSettingDialog";
            this.Text = "字幕位置・長さ合わせの設定";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label searchTrackNameLabel;
        private System.Windows.Forms.TextBox searchTrackNameBox;
        private System.Windows.Forms.Label millisecondLabel;
        private System.Windows.Forms.TextBox marginBox;
        private System.Windows.Forms.Label marginLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
    }
}