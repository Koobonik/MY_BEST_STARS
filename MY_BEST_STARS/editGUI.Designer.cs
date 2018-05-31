namespace MY_BEST_STARS
{
    partial class editGUI
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
            this.PlusWebButton = new System.Windows.Forms.Button();
            this.application = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlusWebButton
            // 
            this.PlusWebButton.Location = new System.Drawing.Point(109, 12);
            this.PlusWebButton.Name = "PlusWebButton";
            this.PlusWebButton.Size = new System.Drawing.Size(75, 23);
            this.PlusWebButton.TabIndex = 0;
            this.PlusWebButton.Text = "웹 추가";
            this.PlusWebButton.UseVisualStyleBackColor = true;
            this.PlusWebButton.Click += new System.EventHandler(this.PlusWebButton_Click);
            // 
            // application
            // 
            this.application.Location = new System.Drawing.Point(12, 12);
            this.application.Name = "application";
            this.application.Size = new System.Drawing.Size(91, 23);
            this.application.TabIndex = 2;
            this.application.Text = "응용프로그램";
            this.application.UseVisualStyleBackColor = true;
            this.application.Click += new System.EventHandler(this.application_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(57, 44);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.Text = "닫기";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // editGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 79);
            this.Controls.Add(this.close);
            this.Controls.Add(this.application);
            this.Controls.Add(this.PlusWebButton);
            this.Name = "editGUI";
            this.Text = "편집";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlusWebButton;
        private System.Windows.Forms.Button application;
        private System.Windows.Forms.Button close;
    }
}