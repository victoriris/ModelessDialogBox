﻿namespace ModelessDialogBox
{
    partial class MainForm
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
            this.colorChangeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorChangeBtn
            // 
            this.colorChangeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorChangeBtn.Location = new System.Drawing.Point(310, 189);
            this.colorChangeBtn.Name = "colorChangeBtn";
            this.colorChangeBtn.Size = new System.Drawing.Size(184, 45);
            this.colorChangeBtn.TabIndex = 0;
            this.colorChangeBtn.Text = "Change Color";
            this.colorChangeBtn.UseVisualStyleBackColor = true;
            this.colorChangeBtn.Click += new System.EventHandler(this.ColorChangeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorChangeBtn);
            this.Name = "MainForm";
            this.Text = "Chabge Colors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button colorChangeBtn;
    }
}

