using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_BEST_STARS
{
    public partial class application : Form
    {
        public application()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\Windows\System32\cale.exe");
        }
    }
}
