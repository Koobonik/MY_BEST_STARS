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
    class MakeWeb
    {
        public MakeWeb()
        {
           
        }

        public void Web_surfing_Mode()//웹서핑 모드
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.naver.com");//네이버
                System.Diagnostics.Process.Start("http://www.coolenjoy.net");//쿨엔조이
                System.Diagnostics.Process.Start("https://okky.kr");//오키 커뮤니티
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
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
