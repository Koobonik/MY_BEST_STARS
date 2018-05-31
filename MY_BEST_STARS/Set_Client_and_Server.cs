using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_BEST_STARS
{
    class Set_Client_and_Server
    {
        public String Url, Hour, Miniute;//이 객체가 갖게 될 웹 주소 시 분 초 변수
        public String Server_Time, Time;//String 형의 객체 시간을 나타내줄 변수
        DateTime DT;                    //이 객체(Set_Client)가 서버로부터 받아온 DateTime 을 저장할 변수
        DateTime dtBefore;              //요청 보내기 전 시간
        DateTime dtAfter;               //요청 받은 후의 시간
        DateTime dtNosp;                //보내기 전 시간과 요청 받은 후의 시간의 오차를 대입받을 변수
        String Until_M, Until_S;        //분까지 나오게할지 초까지 나오게 할지

        public Set_Client_and_Server(String url, String hour, String miniute)//문자열과 시간을 받아와 만드는 생성자
        {
            this.Url = url;
            this.Hour = hour;
            this.Miniute = miniute;
            this.Time = hour + "시" + miniute + "분";
        }

        public Set_Client_and_Server(String url)
        {
            this.Url = url;
        }
        public String Set_Time_is()
        {
            String Set_Time = Hour + "시" + Miniute + "분";
            return "설정시간은 "+ Set_Time + " 입니다.";
        }
        public String Get_Server_Time()//서버시간 가져오기
        {
            
            //웹에 요청 보내기
            System.Net.HttpWebRequest wReqFirst = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(Url);
            
            //요청 보내기 전 시간
            dtBefore = DateTime.Now;

            //보낸 요청 답장 받기
            System.Net.HttpWebResponse wRespFirst = (System.Net.HttpWebResponse)wReqFirst.GetResponse();

            //요청 받은 후의 시간
            dtAfter = DateTime.Now;

            //알맞게 변환하기
            DateTime dtNosp = Convert.ToDateTime(wRespFirst.Headers["Date"].ToString());

            //요청에 걸린 시간 계산하여 서버 시간 보정. 하지만 오차가 거의 1초임 ㅠㅠ 추후 패치 필요
            dtNosp = dtNosp.AddTicks(dtAfter.Ticks - dtBefore.Ticks);
            Until_M = dtNosp.ToString("HH시mm분");

            return Until_M;
        }
        public String UntilS()
        {
            //웹에 요청 보내기
            System.Net.HttpWebRequest wReqFirst = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(Url);

            //요청 보내기 전 시간
            dtBefore = DateTime.Now;

            //보낸 요청 답장 받기
            System.Net.HttpWebResponse wRespFirst = (System.Net.HttpWebResponse)wReqFirst.GetResponse();

            //요청 받은 후의 시간
            dtAfter = DateTime.Now;

            //알맞게 변환하기
            DateTime dtNosp = Convert.ToDateTime(wRespFirst.Headers["Date"].ToString());

            //요청에 걸린 시간 계산하여 서버 시간 보정. 하지만 오차가 거의 1초임 ㅠㅠ 추후 패치 필요
            dtNosp = dtNosp.AddTicks(dtAfter.Ticks - dtBefore.Ticks);

            Until_S = dtNosp.ToString("현재 서버 시간은 "+"HH시mm분ss초");
            return Until_S;
        }
        public String Output()//라벨에 시간을 계속 푸쉬해줄 메소드
        {
            Delay(1000);
            return UntilS();
        }
        public void Compare()//서버시간이 설정한 시간과 같으면 웹 실행
        {
            bool con = true;
            while (con)
            {
                if (this.Time.Equals(Get_Server_Time()))
                {
                    System.Diagnostics.Process.Start(Url);//사용자가 설정했던 url을 연다.
                    con = false;
                }
                else
                {
                    Delay(500);//0.5초 기다려라!
                }
            }
        }
        static DateTime Delay(int ms)//기다리게 만드는 함수
        {
            DateTime thisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime AfterWards = thisMoment.Add(duration);
            while (AfterWards >= thisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                thisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
    }
}
