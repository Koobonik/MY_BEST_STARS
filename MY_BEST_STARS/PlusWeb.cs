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
        Button btn = new Button();//배열을 이용한 버튼 객체생성 
        MainGUI form2 = new MainGUI();//MainGUI로 폼을 만들고
        public static int i = 1;//버튼 추가할 때 쓰일 변수 이름

        public PlusWeb()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)//이름칸
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)//주소칸
        {

        }
        private void Web_Enter_Click(object sender, EventArgs e)//웹 등록 버튼
        {
            btn.Size = new Size(114, 36);//버튼 사이즈
            btn.Text = textBox1.Text;//이름은 텍스트 박스 1 에서 가져옴
            btn.Click += new EventHandler(btn_Click);//버튼 클릭 기능추가
            btn.Location = new Point(374, i*73);//버튼의 위치 ( 가로, 세로 ) 
            btn.Visible = true;//btn 있다고 하기
            form2.Controls.Add(btn);//form2 에 버튼을 추가한다.
            i++;
            this.Visible = false;//창닫고
            form2.ShowDialog();//그 창을 띄움
        }
        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            try
            {
                System.Diagnostics.Process.Start(textBox2.Text);//링크
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)//취소버튼
        {
            this.Visible = false;//창닫고
        }
    }
}
