using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekilisApp
{
    public partial class WinnerMac : Form
    {
        public WinnerMac()
        {
            InitializeComponent();
            WinnerLabel.Text = Class1.winnernum;
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}
