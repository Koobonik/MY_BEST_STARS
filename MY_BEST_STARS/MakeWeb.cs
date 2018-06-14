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
    class MakeWeb//웹 집합체
    {
        public void Web_surfing_Mode()//웹서핑 모드
        {
            Browser browser = new Browser();
            browser.ShowDialog();
            try
            {
                System.Diagnostics.Process.Start("https://www.naver.com");//네이버
                System.Diagnostics.Process.Start("http://www.coolenjoy.net");//쿨엔조이
                System.Diagnostics.Process.Start("https://okky.kr");//오키 커뮤니티
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);//브라우저가 없을때 출력되는 메시지
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        public void Develop_Mode()//개발 모드
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Koobonik");//깃허브
                System.Diagnostics.Process.Start("https://mailprogramming.com/");//매일프로그래밍
                System.Diagnostics.Process.Start("https://aws.amazon.com/ko/");//아마존 웹서비스
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);//브라우저가 없을때 출력되는 메시지
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        public void Clothes_Shopping()//옷쇼핑
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.superstari.co.kr");//슈퍼스타아이
                System.Diagnostics.Process.Start("http://mr-s.co.kr/");//미스터스트릿
                System.Diagnostics.Process.Start("http://www.asclo.com/");//애즈클로
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);//브라우저가 없을때 출력되는 메시지
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        public void Computer_Part()//컴퓨터 부품
        {
            try
            {
                System.Diagnostics.Process.Start("https://pc.pping.kr/");//행복쇼핑
                System.Diagnostics.Process.Start("http://www.3rshop.co.kr/main/main.php");//3R shop
                System.Diagnostics.Process.Start("http://www.danawa.com/");//다나와
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);//브라우저가 없을때 출력되는 메시지
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        public void Weather()//네이버 날씨
        {
            try
            {
                System.Diagnostics.Process.Start("https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query=%EB%82%A0%EC%94%A8");//네이버 날씨
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);//브라우저가 없을때 출력되는 메시지
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        public void Find_Dust()//미세먼지
        {
            try
            {
                System.Diagnostics.Process.Start("https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&query=%EB%AF%B8%EC%84%B8%EB%A8%BC%EC%A7%80");//미세먼지
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);//브라우저가 없을때 출력되는 메시지
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }


}
