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
    public partial class MainGUI : Form//메인 화면
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)//편집 버튼
        {
            this.Visible = false;//창닫고
            editGUI editgui = new editGUI();//나만의 만능찾기라는 창을 만듦
            editgui.ShowDialog();//그 창을 띄움
        }

        private void close_Click(object sender, EventArgs e)//닫힘 버튼
        {
            Visible = false;
        }

        private void openweb_Click(object sender, EventArgs e)//웹페이지 여는 기본 틀 마련
        {
            MakeWeb web = new MakeWeb();

        }
        
    }
}