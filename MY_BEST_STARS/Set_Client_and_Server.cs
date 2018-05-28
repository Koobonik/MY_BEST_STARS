using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_BEST_STARS
{
    class Set_Client_and_Server
    {
        String Url, Hour, Miniute, Second;//이 객체가 갖게 될 웹 주소 시 분 초 변수
        DateTime DT;//이 객체(Set_Client)가 서버로부터 받아온 DateTime 을 저장할 변수
        DateTime dtBefore;//요청 보내기 전 시간
        DateTime dtAfter;//요청 받은 후의 시간
        DateTime dtNosp;//보내기 전 시간과 요청 받은 후의 시간의 오차를 대입받을 변수
        String a;
        public Set_Client_and_Server(String url, String hour, String miniute, String second)//문자열과 시간을 받아와 만드는 생성자
        {
            Url = url;
        }

        public Set_Client_and_Server(String url)
        {

        }
        public String Get_Server_Time(DateTime dtdt)//서버와 시간 동기화
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
            a = dtNosp.ToString("HH시 mm분 ss초");

            return a;
        }
        public void Compare()
        {

        }
    }
}
