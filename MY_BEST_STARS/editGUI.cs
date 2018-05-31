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
    public partial class editGUI : Form
    {
        public editGUI()
        {
            InitializeComponent();
        }

        private void PlusWebButton_Click(object sender, EventArgs e)//웹추가 버튼
        {
            PlusWeb plusweb = new PlusWeb();//나만의 만능찾기라는 창을 만듦
            plusweb.ShowDialog();//그 창을 띄움
        }

        private void Board_Click(object sender, EventArgs e)
        {
            
        }

        private void application_Click(object sender, EventArgs e)
        {
            application app = new application();//애플리케이션 추가 객체
            app.ShowDialog();//창 띄우기

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }
    }
}
