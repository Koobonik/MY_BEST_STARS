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

        private void Spec_Price_Url_TextChanged(object sender, EventArgs e)
        {

        }

        private void Spec_Price_Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//  (재)설정 버튼
        {
            Set_Client_and_Server scs = new Set_Client_and_Server();
        }

        private void button2_Click(object sender, EventArgs e)//종료 버튼
        {

        }
    }
}
