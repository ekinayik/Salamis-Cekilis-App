using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekilisApp
{
    public partial class VideoPlayer : Form
    {
        //string slotcashpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds\slotcash.mp4";
        string slotcashpath = @"C:\Cekilis\Sounds\slotcash.mp4";

        public VideoPlayer()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            axWindowsMediaPlayer1.URL = slotcashpath;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.autoStart = false;
        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            switch (e.nKeyAscii)
            {
                case 81:
                    if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }
                    break;
                case 113:
                    if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                    }
                    break;
                case 69:
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
                case 101:
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    break;
                default:
                    break;
            }
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }
    }
}
