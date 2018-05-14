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
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)//편집 버튼
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}