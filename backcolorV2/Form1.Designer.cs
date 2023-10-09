namespace backcolorV2
{
    partial class Form1
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
            this.cbPurple = new System.Windows.Forms.CheckBox();
            this.cbBlack = new System.Windows.Forms.CheckBox();
            this.cbGreen = new System.Windows.Forms.CheckBox();
            this.cbYellow = new System.Windows.Forms.CheckBox();
            this.cbBlue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbPurple
            // 
            this.cbPurple.AutoSize = true;
            this.cbPurple.Location = new System.Drawing.Point(24, 37);
            this.cbPurple.Name = "cbPurple";
            this.cbPurple.Size = new System.Drawing.Size(44, 17);
            this.cbPurple.TabIndex = 0;
            this.cbPurple.Text = "Mor";
            this.cbPurple.UseVisualStyleBackColor = true;
            this.cbPurple.CheckedChanged += new System.EventHandler(this.cbMor_CheckedChanged);
            // 
            // cbBlack
            // 
            this.cbBlack.AutoSize = true;
            this.cbBlack.Location = new System.Drawing.Point(24, 200);
            this.cbBlack.Name = "cbBlack";
            this.cbBlack.Size = new System.Drawing.Size(52, 17);
            this.cbBlack.TabIndex = 1;
            this.cbBlack.Text = "Siyah";
            this.cbBlack.UseVisualStyleBackColor = true;
            this.cbBlack.CheckedChanged += new System.EventHandler(this.cbsiyah_CheckedChanged);
            // 
            // cbGreen
            // 
            this.cbGreen.AutoSize = true;
            this.cbGreen.Location = new System.Drawing.Point(24, 162);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(48, 17);
            this.cbGreen.TabIndex = 2;
            this.cbGreen.Text = "Yeşil";
            this.cbGreen.UseVisualStyleBackColor = true;
            this.cbGreen.CheckedChanged += new System.EventHandler(this.cbYesil_CheckedChanged);
            // 
            // cbYellow
            // 
            this.cbYellow.AutoSize = true;
            this.cbYellow.Location = new System.Drawing.Point(24, 123);
            this.cbYellow.Name = "cbYellow";
            this.cbYellow.Size = new System.Drawing.Size(44, 17);
            this.cbYellow.TabIndex = 3;
            this.cbYellow.Text = "Sarı";
            this.cbYellow.UseVisualStyleBackColor = true;
            this.cbYellow.CheckedChanged += new System.EventHandler(this.cbYellow_CheckedChanged);
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Location = new System.Drawing.Point(24, 79);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(49, 17);
            this.cbBlue.TabIndex = 4;
            this.cbBlue.Text = "Mavi";
            this.cbBlue.UseVisualStyleBackColor = true;
            this.cbBlue.CheckedChanged += new System.EventHandler(this.cbMavi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 242);
            this.Controls.Add(this.cbBlue);
            this.Controls.Add(this.cbYellow);
            this.Controls.Add(this.cbGreen);
            this.Controls.Add(this.cbBlack);
            this.Controls.Add(this.cbPurple);
            this.Name = "Form1";
            this.Text = "Parti Parti Yaaaee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPurple;
        private System.Windows.Forms.CheckBox cbBlack;
        private System.Windows.Forms.CheckBox cbGreen;
        private System.Windows.Forms.CheckBox cbYellow;
        private System.Windows.Forms.CheckBox cbBlue;
    }
}

