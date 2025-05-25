namespace Controls.ToggleButton
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
            this.toggleButton1 = new Controls.ToggleButton();
            this.toggleButton2 = new Controls.ToggleButton();
            this.toggleButton3 = new Controls.ToggleButton();
            this.toggleButton4 = new Controls.ToggleButton();
            this.SuspendLayout();
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(75, 52);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.DimGray;
            this.toggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.SolidStyle = false;
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // toggleButton2
            // 
            this.toggleButton2.AutoSize = true;
            this.toggleButton2.Checked = true;
            this.toggleButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton2.Location = new System.Drawing.Point(152, 51);
            this.toggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton2.OnBackColor = System.Drawing.Color.CornflowerBlue;
            this.toggleButton2.OnToggleColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toggleButton2.Size = new System.Drawing.Size(45, 22);
            this.toggleButton2.TabIndex = 1;
            this.toggleButton2.UseVisualStyleBackColor = true;
            // 
            // toggleButton3
            // 
            this.toggleButton3.AutoSize = true;
            this.toggleButton3.Checked = true;
            this.toggleButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton3.Location = new System.Drawing.Point(75, 95);
            this.toggleButton3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.OffBackColor = System.Drawing.SystemColors.GrayText;
            this.toggleButton3.OffToggleColor = System.Drawing.SystemColors.InactiveBorder;
            this.toggleButton3.OnBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toggleButton3.OnToggleColor = System.Drawing.SystemColors.HotTrack;
            this.toggleButton3.Size = new System.Drawing.Size(45, 22);
            this.toggleButton3.SolidStyle = false;
            this.toggleButton3.TabIndex = 2;
            this.toggleButton3.UseVisualStyleBackColor = true;
            // 
            // toggleButton4
            // 
            this.toggleButton4.AutoSize = true;
            this.toggleButton4.Location = new System.Drawing.Point(152, 95);
            this.toggleButton4.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton4.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton4.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButton4.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton4.Size = new System.Drawing.Size(45, 22);
            this.toggleButton4.TabIndex = 3;
            this.toggleButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.toggleButton4);
            this.Controls.Add(this.toggleButton3);
            this.Controls.Add(this.toggleButton2);
            this.Controls.Add(this.toggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToggleButton toggleButton1;
        private ToggleButton toggleButton2;
        private ToggleButton toggleButton3;
        private ToggleButton toggleButton4;
    }
}