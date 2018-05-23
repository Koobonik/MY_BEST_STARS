namespace MY_BEST_STARS
{
    partial class application
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
            this.cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(31, 31);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(89, 23);
            this.cal.TabIndex = 0;
            this.cal.Text = "계산기 추가";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cal);
            this.Name = "application";
            this.Text = "응용프로그램";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cal;
    }
}