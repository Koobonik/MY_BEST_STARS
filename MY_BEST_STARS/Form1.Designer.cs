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
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(21, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(229, 12);
            this.name.TabIndex = 0;
            this.name.Text = "나만의 즐겨찾기에 오신 것을 환영합니다!";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(92, 30);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "시작";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.register_Click);
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 65);
            this.Controls.Add(this.start);
            this.Controls.Add(this.name);
            this.Name = "UserRegister";
            this.Text = "인사말";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button start;
    }
}

