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
        MakeWeb web = new MakeWeb();//MakeWeb 이라는 클래스 이용해서 웹 기능 만들기
        Browser broswer = new Browser();
        public MainGUI()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)//편집 버튼
        {
            editGUI editgui = new editGUI();//나만의 만능찾기라는 창을 만듦
            editgui.ShowDialog();//그 창을 띄움
        }

        private void close_Click(object sender, EventArgs e)//닫힘 버튼
        {
            Visible = false;
            Application.Exit();
        }

        private void Spec_Price_Mode_Click(object sender, EventArgs e)//특가모드 버튼
        {
            Spec_Prcie_Set sps = new Spec_Prcie_Set();
            sps.ShowDialog();

        }

        private void openweb_Click(object sender, EventArgs e)//웹서핑 모드
        {
            web.Web_surfing_Mode();
            broswer.toolStripButton5_Click();
        }

        private void Develop_Mode_Click(object sender, EventArgs e)//개발자 모드
        {
            web.Develop_Mode();
        }

        private void Clothes_Shopping_Click(object sender, EventArgs e)//옷쇼핑
        {
            web.Clothes_Shopping();
        }

        private void Computer_Part_Click(object sender, EventArgs e)//컴퓨터 부품
        {
            web.Computer_Part();
        }

        private void Weather_Click(object sender, EventArgs e)//날씨 버튼
        {
            web.Weather();
        }

        private void Fine_Dust_Click(object sender, EventArgs e)//미세먼지 버튼
        {
            web.Find_Dust();
        }

        
    }
}