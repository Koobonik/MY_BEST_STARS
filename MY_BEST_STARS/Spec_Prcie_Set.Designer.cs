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
            this.Hour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(111, 45);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(40, 21);
            this.Hour.TabIndex = 3;
            this.Hour.TextChanged += new System.EventHandler(this.Hour_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "설정 시간";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Set
            // 
            this.Set.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Set.Location = new System.Drawing.Point(50, 112);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(101, 31);
            this.Set.TabIndex = 5;
            this.Set.Text = "(재)설정";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Close.Location = new System.Drawing.Point(186, 112);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(101, 31);
            this.Close.TabIndex = 6;
            this.Close.Text = "닫기";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(157, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "시";
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(187, 45);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(40, 21);
            this.Minute.TabIndex = 8;
            this.Minute.TextChanged += new System.EventHandler(this.Minute_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(233, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "분";
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(263, 45);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(40, 21);
            this.Second.TabIndex = 10;
            this.Second.TextChanged += new System.EventHandler(this.Second_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(309, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "초";
            // 
            // Spec_Prcie_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 155);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hour);
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
        private System.Windows.Forms.TextBox Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Minute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.Label label6;
    }
}