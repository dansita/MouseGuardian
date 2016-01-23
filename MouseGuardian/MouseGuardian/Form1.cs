using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MouseGuardian
{
    public partial class Form1 : Form
    {
        // Global Hook
        // Taken from https://gist.github.com/Stasonix/3181083
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                
                if (vkCode.ToString() == "162")
                {
                    Screen s = Screen.PrimaryScreen;
                    Rectangle b = s.Bounds;
                    Cursor.Position = new Point(b.Left + b.Width / 2,
                                                b.Top + b.Height / 2);
                }
                return (IntPtr)1;
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
                getPointer();
            base.WndProc(ref m);
        }

        private void getPointer()
        {
            Screen s = Screen.PrimaryScreen;
            Rectangle b = s.Bounds;
            Cursor.Position = new Point(b.Left + b.Width / 2,
                                        b.Top + b.Height / 2);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                getPointer();
            }
                
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            xMousePosition.Text = "X: " + Cursor.Position.X.ToString();
            yMousePosition.Text = "Y: " + Cursor.Position.Y.ToString();
            // Determine the size of the "virtual screen", which includes all monitors.
            Bitmap screenshot = new Bitmap(
    SystemInformation.VirtualScreen.Width,
    SystemInformation.VirtualScreen.Height,
    PixelFormat.Format32bppArgb);

            Graphics screenGraph = Graphics.FromImage(screenshot);

            screenGraph.CopyFromScreen(
                SystemInformation.VirtualScreen.X,
                SystemInformation.VirtualScreen.Y,
                0,
                0,
                SystemInformation.VirtualScreen.Size,
                CopyPixelOperation.SourceCopy);
            float x = Cursor.Position.X;
            float y = Cursor.Position.Y;
            Pen pen = new Pen(Properties.Settings.Default.lineColor, 30);
            Pen pen2 = new Pen(Properties.Settings.Default.lineColor, 5);
            Brush bru = new System.Drawing.SolidBrush(Properties.Settings.Default.lineColor);
            Font fnt = new Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Pixel);
            screenGraph.DrawRectangle(pen, x, y, 5, 5);
            if (hor == "true") { screenGraph.DrawLine(pen2, 0, y, 5000, y); }
            if (ver == "true") { screenGraph.DrawLine(pen2, x, 0, x, 5000); }
            if (coo == "true") { string t = "(" + x.ToString() + ", " + y.ToString() + ")"; screenGraph.DrawString(t, fnt, bru, x + 10, y + 10); }

            pictureBox1.Image = screenshot;

        }
        public string hor = Properties.Settings.Default.horline;
        public string ver = Properties.Settings.Default.verline;
        public string coo = Properties.Settings.Default.coor;
        private void Form1_Load(object sender, EventArgs e)
        {
            SetHook();
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.InstalledUICulture;
            
            if (Properties.Settings.Default.Language == "default")
            {
                Properties.Settings.Default.Language = ci.TwoLetterISOLanguageName.ToString();
            }

            loadLanguage();
            if(Properties.Settings.Default.disableMirror == "false")
            {
                timer1.Start();
                disableMirrorLabel.Checked = false;
                toolStrip1.Enabled = true;
            }
            else {
                disableMirrorLabel.Checked = true;
                toolStrip1.Enabled = false;
            }
            toolStrip1.Location = Properties.Settings.Default.tool1Loc;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
            Properties.Settings.Default.tool1Loc = toolStrip1.Location;
            Properties.Settings.Default.Save();
        }

        private void githubLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dansita/MouseGuardian");
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horLine_Click(object sender, EventArgs e)
        {
            if(horLine.Checked == true) { hor = "true"; Properties.Settings.Default.horline = "true"; } else { hor = "false"; Properties.Settings.Default.horline = "false"; }
            Properties.Settings.Default.Save();
        }

        private void verLine_Click(object sender, EventArgs e)
        {
            if (verLine.Checked == true) { ver = "true"; Properties.Settings.Default.verline = "true"; } else { ver = "false"; Properties.Settings.Default.verline = "false"; }
            Properties.Settings.Default.Save();
        }

        private void coorLabel_Click(object sender, EventArgs e)
        {
            if (coorLabel.Checked == true) { coo = "true"; Properties.Settings.Default.coor = "true"; } else { coo = "false"; Properties.Settings.Default.coor = "false"; }
            Properties.Settings.Default.Save();
        }

        private void lineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form color = new ColorSel();
                color.ShowDialog();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguage("en");
        }

        private void changeLanguage(string lang)
        {
            Properties.Settings.Default.Language = lang;
            Properties.Settings.Default.Save();
            loadLanguage();
        }

        private void loadLanguage(){
            string x = Properties.Settings.Default.Language;
            switch (x)
            {
                default:
                    this.Text = "MouseGuardian 1.1";
                    aboutMenu.Text = "?";
                    shortcutLabel.Text = "Press CTRL to position the cursor at the center of the screen";
                    showLabel.Text = "Show";
                    horLine.Text = "Horizontal Line";
                    verLine.Text = "Vertical Line";
                    coorLabel.Text = "Coordinates";
                    prefLabel.Text = "Preferences";
                    linecLabel.Text = "Line Color";
                    langLabel.Text = "Interface Language";
                    helpLabel.Text = "Help";
                    updLabel.Text = "Check Updates";
                    aboutLabel.Text = "About";
                    playMirror.Text = "Play Mirroring";
                    pauseMirror.Text = "Pause Mirroring";
                    stopMirror.Text = "Stop Mirroring";
                    disableMirrorLabel.Text = "Disable Mirroring";
                    break;

                case "it":
                    this.Text = "MouseGuardian 1.1";
                    aboutMenu.Text = "?";
                    shortcutLabel.Text = "Premi CTRL per posizionare il cursore al centro dello schermo";
                    showLabel.Text = "Visualizza";
                    horLine.Text = "Linea orizzontale";
                    verLine.Text = "Linea verticale";
                    coorLabel.Text = "Coordinate";
                    prefLabel.Text = "Preferenze";
                    linecLabel.Text = "Colore linea";
                    langLabel.Text = "Lingua interfaccia";
                    helpLabel.Text = "Aiuto";
                    updLabel.Text = "Controlla aggiornamenti";
                    aboutLabel.Text = "Informazioni su ...";
                    playMirror.Text = "Riproduci Mirroring";
                    pauseMirror.Text = "Metti in pausa Mirroring";
                    stopMirror.Text = "Ferma Mirroring";
                    disableMirrorLabel.Text = "Disabilita il mirroring";
                    break;
            
              }
        }

        private void italianItalianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLanguage("it");
        }

        private void horLine_Paint(object sender, PaintEventArgs e)
        {
            if (Properties.Settings.Default.horline == "true")
            {
                horLine.Checked = true;
            } else { horLine.Checked = false; }
        }

        private void verLine_Paint(object sender, PaintEventArgs e)
        {
            if (Properties.Settings.Default.verline == "true")
            {
                verLine.Checked = true;
            }
            else { verLine.Checked = false; }
        }

        private void coorLabel_Paint(object sender, PaintEventArgs e)
        {
            if (Properties.Settings.Default.coor == "true")
            {
                coorLabel.Checked = true;
            }
            else { coorLabel.Checked = false; }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dansita/MouseGuardian/wiki");
        }

        private void gitHubProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dansita/MouseGuardian");
        }

        private void playMirror_Click(object sender, EventArgs e)
        {
            playMirror.Enabled = false;
            pauseMirror.Enabled = true;
            stopMirror.Enabled = true;
            timer1.Start();
        }

        private void pauseMirror_Click(object sender, EventArgs e)
        {
            playMirror.Enabled = true;
            pauseMirror.Enabled = false;
            stopMirror.Enabled = true;
            timer1.Stop();
        }

        private void stopMirror_Click(object sender, EventArgs e)
        {
            playMirror.Enabled = true;
            pauseMirror.Enabled = false;
            stopMirror.Enabled = false;
            timer1.Stop();
            pictureBox1.Image = null;
        }

        private void disableMirrorLabel_Click(object sender, EventArgs e)
        {
            if (disableMirrorLabel.Checked == true)
            {
                Properties.Settings.Default.disableMirror = "true";
                Properties.Settings.Default.Save();
                timer1.Stop();
                toolStrip1.Enabled = false;
                pictureBox1.Image = null;
            }
            else {
                Properties.Settings.Default.disableMirror = "false";
                Properties.Settings.Default.Save();
                timer1.Start();
                toolStrip1.Enabled = true;
            }
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }
    }
}

