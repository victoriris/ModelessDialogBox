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
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(66, 177);
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
            this.RedBtn.Location = new System.Drawing.Point(15, 12);
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
            this.BlueBtn.Location = new System.Drawing.Point(14, 45);
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
            this.GreenBtn.Location = new System.Drawing.Point(14, 79);
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
            this.otherBtn.Location = new System.Drawing.Point(15, 116);
            this.otherBtn.Name = "otherBtn";
            this.otherBtn.Size = new System.Drawing.Size(51, 17);
            this.otherBtn.TabIndex = 4;
            this.otherBtn.TabStop = true;
            this.otherBtn.Text = "Other";
            this.otherBtn.UseVisualStyleBackColor = true;
            this.otherBtn.Click += new System.EventHandler(this.OtherBtn_Click);
            // 
            // ColorChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 232);
            this.Controls.Add(this.otherBtn);
            this.Controls.Add(this.GreenBtn);
            this.Controls.Add(this.BlueBtn);
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "ColorChooser";
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.RadioButton RedBtn;
        private System.Windows.Forms.RadioButton BlueBtn;
        private System.Windows.Forms.RadioButton GreenBtn;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RadioButton otherBtn;
    }
}