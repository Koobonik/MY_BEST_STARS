namespace MY_BEST_STARS
{
    partial class PlusWeb
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WebName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Web_Enter = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "웹 사이트 주소";
            // 
            // WebName
            // 
            this.WebName.AutoSize = true;
            this.WebName.Location = new System.Drawing.Point(38, 36);
            this.WebName.Name = "WebName";
            this.WebName.Size = new System.Drawing.Size(29, 12);
            this.WebName.TabIndex = 2;
            this.WebName.Text = "이름";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Web_Enter
            // 
            this.Web_Enter.Location = new System.Drawing.Point(103, 108);
            this.Web_Enter.Name = "Web_Enter";
            this.Web_Enter.Size = new System.Drawing.Size(75, 23);
            this.Web_Enter.TabIndex = 4;
            this.Web_Enter.Text = "등록";
            this.Web_Enter.UseVisualStyleBackColor = true;
            this.Web_Enter.Click += new System.EventHandler(this.Web_Enter_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(198, 108);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PlusWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 154);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Web_Enter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.WebName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "PlusWeb";
            this.Text = "웹 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WebName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Web_Enter;
        private System.Windows.Forms.Button Cancel;
    }
}