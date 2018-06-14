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
    public partial class Browser : Form
    {
        String naver = "https://www.naver.com"; // 네이버
        String okky = "https://okky.kr"; // 오키
        String coolenjoy = "http://www.coolenjoy.net";// 쿨엔 조이

        String github = "https://github.com/Koobonik";//깃허브
        String mailp = "https://mailprogramming.com/";//매일프로그래밍
        String amazon = "https://aws.amazon.com/ko/";//아마존 웹서비스

        String happy = "https://pc.pping.kr/"; //행복쇼핑
        String threeR = "http://www.3rshop.co.kr/main/main.php";//3R shop
        String danawa = "http://www.danawa.com/"; //다나와

        public Browser()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)//웹 브라우저
        {
            this.Text = webBrowser1.Document.Title + " – 브라우저 샘플"; // 
            toolStripTextBox1.Text = webBrowser1.Document.Url.ToString(); // 
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // 뒤로가기
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // 앞으로 가기
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // 엔터 버튼
        {
            webBrowser1.Navigate(this.naver);
        }
        public void toolStripButton5_Click()
        {
            webBrowser1.Navigate(this.naver);
               
        }

    }
}
