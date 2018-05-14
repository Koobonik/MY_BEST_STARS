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
            this.Board = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlusWebButton
            // 
            this.PlusWebButton.Location = new System.Drawing.Point(39, 33);
            this.PlusWebButton.Name = "PlusWebButton";
            this.PlusWebButton.Size = new System.Drawing.Size(75, 23);
            this.PlusWebButton.TabIndex = 0;
            this.PlusWebButton.Text = "웹 추가";
            this.PlusWebButton.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            this.Board.Location = new System.Drawing.Point(135, 33);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(84, 23);
            this.Board.TabIndex = 1;
            this.Board.Text = "게시판 추가";
            this.Board.UseVisualStyleBackColor = true;
            // 
            // editGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 304);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.PlusWebButton);
            this.Name = "editGUI";
            this.Text = "편집";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlusWebButton;
        private System.Windows.Forms.Button Board;
    }
}