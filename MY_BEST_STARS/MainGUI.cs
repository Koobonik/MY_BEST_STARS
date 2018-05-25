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
        public MainGUI()
        {
            InitializeComponent();
            notifyIcon1.Visible = false;
        }
        private void ToTray()//트레이로 보내는 소스
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);
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
            Application.Exit();
        }

        private void openweb_Click(object sender, EventArgs e)//웹서핑 모드
        {
            web.Web_surfing_Mode();
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
        private void MainGUI_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true; // tray icon 표시
                this.Hide();
            }
            else
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true; // 작업 표시줄 표시
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true; // tray icon 표시
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true; // 작업 표시줄 표시
            }
            this.Resize += MainGUI_Resize;
        }
        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
            this.notifyIcon1.Visible = false;
        }
        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.ToTray();
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Dispose();
            Application.Exit();
        }
        private void MainGUI_SizeChanged(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                this.ToTray();
        }
        
    }
}