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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            //InitializeComponent();  //바로 메인 화면 뜨게끔 수정
            this.Visible = false;//창닫고
            MainGUI form2 = new MainGUI();//나만의 만능찾기라는 창을 만듦
            form2.ShowDialog();//그 창을 띄움
        }

        public void register_Click(object sender, EventArgs e)//등록버튼
        {
            this.Visible = false;//창닫고
            MainGUI form2 = new MainGUI();//나만의 만능찾기라는 창을 만듦
            form2.ShowDialog();//그 창을 띄움
        }
    }
}
