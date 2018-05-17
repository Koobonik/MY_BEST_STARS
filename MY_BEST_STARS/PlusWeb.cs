using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_BEST_STARS
{
    public partial class PlusWeb : Form
    {
        public PlusWeb()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Web_Enter_Click(object sender, EventArgs e)//웹 등록 버튼
        {
            /*
            User user = new User(namebox.Text);//name박스의 텍스트를 불러와서 이름을 넣어줌
            */
            int i = 1;

            while (true)
            {
                Button btn = new Button();
                btn.Size = new Size(i * 40, 30);
                btn.Name = textBox1.Text;//이름은 텍스트 박스 1 에서 가져옴
                MakeWeb makeweb = new MakeWeb(textBox1.Text, textBox2.Text);//이름과 주소를 받아와서 웹을 만듦
                btn.Text = btn.Name;
                btn.Location = new Point(10 + i * (80 + 5), 50);
                MainGUI form2 = new MainGUI();
                form2.Controls.Add(btn);
                ++i;
                btn.Visible = true;
                this.Visible = false;//창닫고
                form2.ShowDialog();//그 창을 띄움
                break;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;//창닫고
        }
    }
}
