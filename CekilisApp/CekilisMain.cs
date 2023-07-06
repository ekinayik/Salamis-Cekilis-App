using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace CekilisApp
{
    public partial class SalamisCasinoMain : Form
    {
        
        string winningmachine;
        string sounds_Path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds";
        string general_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string announcment_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds\Announcements";
        string txt_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"c:\Cekilis\Datasources";
        string luckypath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds\luckyslot.mp3";
        string slotcashpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds\slotcash.mp4";
        string bingopath = null;
        DirectoryInfo directoryInfoann = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds\Announcements");
        DirectoryInfo directoryInfomus = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Sounds\Musiclist");
        public void setAnonsListBox()
        {
            anonsListBox.Items.Clear();
            try
            {
                FileInfo[] Files = directoryInfoann.GetFiles("*.mp3");
                foreach (FileInfo file in Files)
                {
                    anonsListBox.Items.Add(file.Name);
                }
            }
            catch 
            { 
            }
        }
        public void setMusicListBox()
        {
            musicListBox.Items.Clear();
            try 
            {
                FileInfo[] Files = directoryInfomus.GetFiles("*.mp3");
                foreach(FileInfo file in Files)
                {
                    musicListBox.Items.Add(file.Name);
                }
            }
            catch 
            { 
            }
        }
        public void setMusicPlaylist()
        {
            try { 
            var playlist = musicPlayer.playlistCollection.newPlaylist("NormalPlaylist");
            FileInfo[] Files = directoryInfomus.GetFiles("*.mp3");
            foreach (FileInfo file in Files)
            {
                var mediaItem = musicPlayer.newMedia(directoryInfomus+"/"+file.Name);
                playlist.appendItem(mediaItem);
            }
            musicPlayer.currentPlaylist=playlist;
            }
            catch { }
        }
        public SalamisCasinoMain()
        {
            InitializeComponent();
            lucky_slot_layout.Hide();
            slot_cash_layout.Hide();
            settings_layout.Hide();
            bingo_layout.Hide();
            reception_layout.Hide();
            setAnonsListBox();
            setMusicListBox();
            setMusicPlaylist();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            winningmachine=textBox1.Text.ToString();
            Class1.winnernum = "  Kazanan Şanslı Makine  \n" + winningmachine;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if(Class1.form!=null)
            { 
            Class1.form.Close();
            }
            if(Class1.WinnerNumForm==null)
            { 
            Class1.WinnerNumForm = new WinnerMac();
            }
            if (Screen.AllScreens.Length <= 1)
            {
                Screen[] screens = Screen.AllScreens;
                try 
                {
                    Class1.WinnerNumForm.Close();              
                    Class1.WinnerNumForm.Show();
                }
                catch 
                {
                    Class1.WinnerNumForm.Close();
                    Class1.WinnerNumForm = new WinnerMac();
                    Class1.WinnerNumForm.Show();
                }
                setFormLocation(Class1.WinnerNumForm, screens[0]);
                this.Refresh();
            }
            else
            {
                Screen[] screens = Screen.AllScreens;
                try
                {
                    Class1.WinnerNumForm.Close();
                    Class1.WinnerNumForm.Show();
                }
                catch
                {
                    Class1.WinnerNumForm.Close();
                    Class1.WinnerNumForm = new WinnerMac();
                    Class1.WinnerNumForm.Show();
                }
                setFormLocation(Class1.WinnerNumForm, screens[1]);
                this.Refresh();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(Class1.WinnerNumForm!=null)
            { 
            Class1.WinnerNumForm.Close();
            }
            if (Class1.form != null)
            {
                Class1.form.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void setFormLocation(Form form, Screen screen)
        {
            // first method
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            // second method
            //Point location = screen.Bounds.Location;
            //Size size = screen.Bounds.Size;

            //form.Left = location.X;
            //form.Top = location.Y;
            //form.Width = size.Width;
            //form.Height = size.Height;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Class1.WinnerNumForm != null)
            {
                Class1.WinnerNumForm.Close();
            }
            if (Class1.form == null)
            {
                Class1.form = new Cekilis();
            }
            if (Screen.AllScreens.Length<=1)
            {
                Screen[] screens = Screen.AllScreens;
                try
                {
                    Class1.form.Show();
                }
                catch
                {
                    Class1.form = new Cekilis();
                    Class1.form.Show();
                }
                setFormLocation(Class1.form, screens[0]);
                this.Refresh();
            }
            else { 
                Screen[] screens = Screen.AllScreens;
                try
                {
                    Class1.form.Show();
                }
                catch
                {
                    Class1.form = new Cekilis();
                    Class1.form.Show();
                }
                setFormLocation(Class1.form, screens[1]);
                this.Refresh();
            }
        }
        private void reception_BT_Click(object sender, EventArgs e)
        {
            lucky_slot_layout.Hide();
            slot_cash_layout.Hide();
            bingo_layout.Hide();
            settings_layout.Hide();
            reception_layout.Show();
        }
        private void lucky_slot_bt_Click(object sender, EventArgs e)
        {
            lucky_slot_layout.Show();
            slot_cash_layout.Hide();
            bingo_layout.Hide();
            settings_layout.Hide();
            reception_layout.Hide();
        }
        private void slot_Cash_bt_Click(object sender, EventArgs e)
        {
            lucky_slot_layout.Hide();
            slot_cash_layout.Show();
            bingo_layout.Hide();
            settings_layout.Hide();
            reception_layout.Hide();
        }
        private void bingo_bt_Click(object sender, EventArgs e)
        {
            lucky_slot_layout.Hide();
            slot_cash_layout.Hide();
            bingo_layout.Show();
            settings_layout.Hide();
            reception_layout.Hide();
        }
        private void settings_bt_Click(object sender, EventArgs e)
        {
            lucky_slot_layout.Hide();
            slot_cash_layout.Hide();
            bingo_layout.Hide();
            settings_layout.Show();
            reception_layout.Hide();
        }
        String path, file;
        private int FileDialog(int format)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            switch(format)
            {
                case 1:
                    ofd.Filter = "MP3 | *.mp3";
                    break;
                case 2:
                    ofd.Filter = "MP4|*.mp4";
                    break;
                default:
                    ofd.Filter = "MP3 | *.mp3|MP4|*.mp4";
                    break;
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                file = ofd.SafeFileName;
                return 1;
            }
            else 
            {
                return 0;
            }
        }
        private void lucky_music_bt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            if (FileDialog(1) == 1) {
            string destFile = System.IO.Path.Combine(sounds_Path, "luckyslot.mp3");
            System.IO.File.Copy(path, destFile,true);
            }
            else { return; }
        }
        private void cas_music_bt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            if (FileDialog(2) == 1)
            {
                string destFile = System.IO.Path.Combine(sounds_Path, "slotcash.mp4");
                System.IO.File.Copy(path, destFile, true);
            }
            else { return; }
        }
        private void bingo_music_bt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            if (FileDialog(1) == 1)
            {
                string destFile = System.IO.Path.Combine(sounds_Path, file);
                System.IO.File.Copy(path, destFile, true);
            }
            else { return; }
        }
        private void CloseSlotCashBT_Click(object sender, EventArgs e)
        {
            if(Class1.VideoPlayerForm!=null)
            {
                Class1.VideoPlayerForm.Close();
            }
        }
        private void slotCashvidBT_Click_1(object sender, EventArgs e)
        {
            if (Class1.VideoPlayerForm != null)
            {
                Class1.VideoPlayerForm.Close();
            }
            if (Screen.AllScreens.Length <= 1)
            {
                Screen[] screens = Screen.AllScreens;
                Class1.VideoPlayerForm = new VideoPlayer();
                Class1.VideoPlayerForm.Show();
                setFormLocation(Class1.VideoPlayerForm, screens[0]);
                this.Refresh();
            }
            else
            {
                Screen[] screens = Screen.AllScreens;
                Class1.VideoPlayerForm = new VideoPlayer();
                Class1.VideoPlayerForm.Show();
                setFormLocation(Class1.VideoPlayerForm, screens[1]);
                this.Refresh();
            }
        }
        private void startCashMusBT_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.URL = slotcashpath;
        }
        private void anonsListBox_DoubleClick(object sender, EventArgs e)
        {
            if(anonsListBox.SelectedItem!=null)
            {
                axWindowsMediaPlayer1.settings.setMode("loop", false);
                axWindowsMediaPlayer1.URL = announcment_path+@"\"+anonsListBox.SelectedItem.ToString();
                musicPlayer.Ctlcontrols.pause();
            }
        }
        private void add_annBT_Click(object sender, EventArgs e)
        {

            string filename=Microsoft.VisualBasic.Interaction.InputBox("Enter Announcement Name", "Name Of Announcement", "").ToString();
            if(filename=="")
            {
                MessageBox.Show("You Should write name of announcement", "Warning");
                return;
            }
            if(FileDialog(1)==1)
            {                
                string destFile = System.IO.Path.Combine(announcment_path, filename+".mp3");
                MessageBox.Show("File added into" + announcment_path);
                System.IO.File.Copy(path, destFile, true);
                setAnonsListBox();
            }
            else 
            {
                return;
            }
        }
        private void anonsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete&&anonsListBox.SelectedItem!=null)
            {
                DialogResult deletedialog= MessageBox.Show(anonsListBox.SelectedItem.ToString()+" will be removed, Are You Sure ?","Delete",MessageBoxButtons.YesNo);
                if (deletedialog==DialogResult.Yes)
                {
                    File.Delete(announcment_path + "/" + anonsListBox.SelectedItem.ToString());
                    setAnonsListBox();
                }
                else 
                {
                    return;
                }
            }
        }

        private void musicListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            musicPlayer.settings.setMode("loop", true);
            musicPlayer.settings.setMode("shuffle", true);
        }

        private void stopSongBT_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void start_song_bt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("loop", false);
            axWindowsMediaPlayer1.URL = luckypath;
        }
    }
}
