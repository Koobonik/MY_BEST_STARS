﻿using System;
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
    public partial class Spec_Prcie_Set : Form
    {
        public Spec_Prcie_Set()
        {
            InitializeComponent();
        }

        private void Spec_Price_Url_TextChanged(object sender, EventArgs e)//url 텍스트 박스
        {
            
        }
        
        private void Hour_TextChanged(object sender, EventArgs e)//시간 텍스트 박스
        {
            
        }

        private void Minute_TextChanged(object sender, EventArgs e)//분 텍스트 박스
        {

        }

        public void label3_Click(object sender, EventArgs e)//시간을 표시해주는 곳
        {

            Set_Client_and_Server scs = new Set_Client_and_Server();
            /*
            DateTime dt = scs.UntilS2();
            String dts;
            dt = dt.AddTicks(dt.Ticks);
            bool b = true;
            while (b)
            {
                dts = dt.ToString("현재 서버 시간 : HH시 mm분 ss초");
                label3.Text = dts;
                scs.Delay(100);
            }
            */
        }
        private void Set_Click(object sender, EventArgs e) // (재)설정 버튼
        {
            /* 시간에 대한 예외처리 하는 부분 */

            // Hour 부분이 들어올 때
            DateTime dth = DateTime.Now;
            //dt.ToString("HH시mm분");
            int H_now_time = int.Parse(dth.ToString("HH")); // 현재 시간
            int H_box_time = int.Parse(Hour.Text); // 박스에 입력될 시간
            if (H_now_time > H_box_time)
            {
                Hour.Text = null;
                MessageBox.Show("지금 이후의 시간을 입력해주세요");
            }

            // Miniute 부분이 들어올 때
            DateTime dtm = DateTime.Now;
            //dt.ToString("HH시mm분");
            int M_now_time = int.Parse(dtm.ToString("mm")); // 현재 분
            int M_box_time = int.Parse(Minute.Text); // 박스에 입력될 분
            if (M_now_time > M_box_time)
            {
                Minute.Text = null;
                MessageBox.Show("지금 이후의 시간을 입력해주세요");
            }


            /*  예외처리 이후 실행될 부분    */
            if (Hour.Text == null && Minute.Text == null)//시간 부분에 null 값이 들어온다면
            {
                Set_Client_and_Server scs = new Set_Client_and_Server(Spec_Price_Url.Text);
                scs.Get_Server_Time();
            }
            else//전부 다 들어왔을경우
            {
                Set_Client_and_Server scs = new Set_Client_and_Server(Spec_Price_Url.Text, Hour.Text, Minute.Text);//url과 시 분 초 받기
                bool a = true;
                while (a)
                {
                    if (scs.Get_Server_Time().Equals(scs.Time))//서버의 시간과 내가 설정한 시간이 같다면
                    {
                        System.Diagnostics.Process.Start(scs.Url);//사용자가 설정했던 url을 연다.
                        a = false; 
                    }
                    else if (a)
                    {
                        label3.Text = scs.Output();//라벨에 지속적으로 서버 시간 갱신
                    }
                }
            }
            this.Visible = false; //다 완료 하면 창 닫기

        }
        private void Close_Click(object sender, EventArgs e)//종료 버튼
        {
            this.Visible = false; //창종료
        }

        
    }
}