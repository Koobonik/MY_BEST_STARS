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
      
        public static String naver = "https://www.naver.com"; // 네이버
        public static String okky = "https://okky.kr"; // 오키
        public static String coolenjoy = "http://www.coolenjoy.net";// 쿨엔 조이

        public static String github = "https://github.com/Koobonik";//깃허브
        public static String mailp = "https://mailprogramming.com/";//매일프로그래밍
        public static String amazon = "https://aws.amazon.com/ko/";//아마존 웹서비스

        public static String superstar = "http://www.superstari.co.kr"; // 슈퍼스타 아이
        public static String mr = "http://mr-s.co.kr/"; // 미스터 스트릿
        public static String asclo = "http://www.asclo.com/"; // 애즈클로

        public static String happy = "https://pc.pping.kr/"; //행복쇼핑
        public static String threeR = "http://www.3rshop.co.kr/main/main.php";//3R shop
        public static String danawa = "http://www.danawa.com/"; //다나와

        public static String weather = "https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query=%EB%82%A0%EC%94%A8";//네이버 날씨
        public static String dust = "https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query=%EB%AF%B8%EC%84%B8%EB%A8%BC%EC%A7%80";//미세먼지


        public Browser(string url)
        {
            InitializeComponent();
            webBrowser1.Navigate(url);
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
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
