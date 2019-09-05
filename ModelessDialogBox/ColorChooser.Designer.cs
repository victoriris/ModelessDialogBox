namespace ModelessDialogBox
{
    partial class ColorChooser
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.RadioButton();
            this.BlueBtn = new System.Windows.Forms.RadioButton();
            this.GreenBtn = new System.Windows.Forms.RadioButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.otherBtn = new System.Windows.Forms.RadioButton();
            this.colorsPanel = new System.Windows.Forms.Panel();
            this.colorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(40, 149);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.AutoSize = true;
            this.RedBtn.Location = new System.Drawing.Point(5, 3);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(45, 17);
            this.RedBtn.TabIndex = 1;
            this.RedBtn.TabStop = true;
            this.RedBtn.Text = "Red";
            this.RedBtn.UseVisualStyleBackColor = true;
            this.RedBtn.Click += new System.EventHandler(this.RadioBtn_changed);
            // 
            // BlueBtn
            // 
            this.BlueBtn.AutoSize = true;
            this.BlueBtn.Location = new System.Drawing.Point(4, 33);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(46, 17);
            this.BlueBtn.TabIndex = 2;
            this.BlueBtn.TabStop = true;
            this.BlueBtn.Text = "Blue";
            this.BlueBtn.UseVisualStyleBackColor = true;
            this.BlueBtn.Click += new System.EventHandler(this.RadioBtn_changed);
            // 
            // GreenBtn
            // 
            this.GreenBtn.AutoSize = true;
            this.GreenBtn.Location = new System.Drawing.Point(4, 67);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(54, 17);
            this.GreenBtn.TabIndex = 3;
            this.GreenBtn.TabStop = true;
            this.GreenBtn.Text = "Green";
            this.GreenBtn.UseVisualStyleBackColor = true;
            this.GreenBtn.Click += new System.EventHandler(this.RadioBtn_changed);
            // 
            // otherBtn
            // 
            this.otherBtn.AutoSize = true;
            this.otherBtn.Location = new System.Drawing.Point(5, 99);
            this.otherBtn.Name = "otherBtn";
            this.otherBtn.Size = new System.Drawing.Size(51, 17);
            this.otherBtn.TabIndex = 4;
            this.otherBtn.TabStop = true;
            this.otherBtn.Text = "Other";
            this.otherBtn.UseVisualStyleBackColor = true;
            this.otherBtn.Click += new System.EventHandler(this.OtherBtn_Click);
            // 
            // colorsPanel
            // 
            this.colorsPanel.Controls.Add(this.GreenBtn);
            this.colorsPanel.Controls.Add(this.otherBtn);
            this.colorsPanel.Controls.Add(this.BlueBtn);
            this.colorsPanel.Controls.Add(this.RedBtn);
            this.colorsPanel.Location = new System.Drawing.Point(10, 12);
            this.colorsPanel.Name = "colorsPanel";
            this.colorsPanel.Size = new System.Drawing.Size(126, 131);
            this.colorsPanel.TabIndex = 5;
            // 
            // ColorChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 184);
            this.Controls.Add(this.colorsPanel);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ColorChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.ColorChooser_Load);
            this.colorsPanel.ResumeLayout(false);
            this.colorsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.RadioButton RedBtn;
        private System.Windows.Forms.RadioButton BlueBtn;
        private System.Windows.Forms.RadioButton GreenBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RadioButton otherBtn;
        private System.Windows.Forms.Panel colorsPanel;
    }
}