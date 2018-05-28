namespace MY_BEST_STARS
{
    partial class Spec_Prcie_Set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spec_Prcie_Set));
            this.label1 = new System.Windows.Forms.Label();
            this.Spec_Price_Url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Spec_Price_Time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "특가 주소 :";
            // 
            // Spec_Price_Url
            // 
            this.Spec_Price_Url.Location = new System.Drawing.Point(111, 7);
            this.Spec_Price_Url.Name = "Spec_Price_Url";
            this.Spec_Price_Url.Size = new System.Drawing.Size(204, 21);
            this.Spec_Price_Url.TabIndex = 1;
            this.Spec_Price_Url.TextChanged += new System.EventHandler(this.Spec_Price_Url_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "특가 시간 :";
            // 
            // Spec_Price_Time
            // 
            this.Spec_Price_Time.Location = new System.Drawing.Point(111, 45);
            this.Spec_Price_Time.Name = "Spec_Price_Time";
            this.Spec_Price_Time.Size = new System.Drawing.Size(204, 21);
            this.Spec_Price_Time.TabIndex = 3;
            this.Spec_Price_Time.TextChanged += new System.EventHandler(this.Spec_Price_Time_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(137, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "서버 시간";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(50, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "(재)설정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(186, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "닫기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Spec_Prcie_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 155);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Spec_Price_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Spec_Price_Url);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spec_Prcie_Set";
            this.Text = "특가모드 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Spec_Price_Url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Spec_Price_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}