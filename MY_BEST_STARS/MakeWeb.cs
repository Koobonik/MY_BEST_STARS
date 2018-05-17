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
        String Name, Url;//이름과 url
        public MakeWeb(String name, String url)
        {

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void makeButton()
        {
            Button button = new Button();
            button.Click += new EventHandler(button_Click);
        }
        protected void button_Click(object sender, EventArgs e)//동적 버튼 만들기
        {
            Button button = sender as Button;
        }

    }


}
