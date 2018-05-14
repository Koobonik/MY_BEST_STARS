using System;

namespace MY_BEST_STARS
{
    partial class UserRegister
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 0;
            this.name.Text = "이름";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(48, 9);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 21);
            this.namebox.TabIndex = 1;
            namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(154, 9);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 2;
            this.register.Text = "등록";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 38);
            this.Controls.Add(this.register);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.name);
            this.Name = "UserRegister";
            this.Text = "사용자 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Button register;
    }
}

