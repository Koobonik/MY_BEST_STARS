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
            Set_Client_and_Server Servertime = new Set_Client_and_Server(Spec_Price_Url.Text);
            
        }
        private void Set_Click(object sender, EventArgs e)//  (재)설정 버튼
        {
            Set_Client_and_Server scs = new Set_Client_and_Server(Spec_Price_Url.Text, Hour.Text, Minute.Text);//url과 시 분 초 받기
            bool a = true;
            while (a)
            {
                if(scs.Get_Server_Time().Equals(scs.Time))
                {
                    System.Diagnostics.Process.Start(scs.Url);//사용자가 설정했던 url을 연다.
                    label3.Text = scs.Output();
                    a = false;
                }
                else if(a)
                {
                    label3.Text = scs.Output();
                }
            }

        }
        private void Close_Click(object sender, EventArgs e)//종료 버튼
        {
            this.Visible = false;//창종료
        }

    }
}