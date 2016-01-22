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
            Pen pen = new Pen(Color.Red, 30);
            screenGraph.DrawRectangle(pen, x, y, 50, 50);
            pictureBox1.Image = screenshot;

        }
        public string about = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            SetHook();
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.InstalledUICulture;
            switch (ci.TwoLetterISOLanguageName)
            {
                default:
                    this.Text = "MouseGuardian 2016";
                    appMenu.Text = "App";
                    githubLabel.Text = "View on GitHub";
                    exitMenu.Text = "Exit App";
                    aboutMenu.Text = "About";
                    shortcutLabel.Text = "Press CTRL to position the cursor at the center of the screen";
                    about = "MouseGuardian v. 1.0 created by Daniel Sedmak.\nCopyright 2016 Daniel Sedmak - Released under the MIT License";
                    break;

                case "it":
                    this.Text = "MouseGuardian 2016";
                    appMenu.Text = "App";
                    githubLabel.Text = "Vedi su GitHub";
                    exitMenu.Text = "Chiudi App";
                    aboutMenu.Text = "Info su";
                    shortcutLabel.Text = "Premi CTRL per posizionare il cursore al centro dello schermo";
                    about = "MouseGuardian v. 1.0 creato da Daniel Sedmak.\nCopyright 2016 Daniel Sedmak - Rilasciato con licenza MIT";
                    break;

                case "fr":
                    this.Text = "MouseGuardian 2016";
                    appMenu.Text = "App";
                    githubLabel.Text = "Voir sur GitHub";
                    exitMenu.Text = "Fermer App";
                    aboutMenu.Text = "À propos";
                    shortcutLabel.Text = "Appuyez sur Ctrl pour placer le curseur au centre de l'écran";
                    about = "MouseGuardian v. 1.0 created by Daniel Sedmak.\nCopyright 2016 Daniel Sedmak - Released under the MIT License";
                    break;

                case "sp":
                    this.Text = "MouseGuardian 2016";
                    appMenu.Text = "App";
                    githubLabel.Text = "Ver en GitHub";
                    exitMenu.Text = "Cerrar App";
                    aboutMenu.Text = "Acerca de";
                    shortcutLabel.Text = "Presionar Ctrl para colocar el cursor en el centro de la pantalla";
                    about = "MouseGuardian v. 1.0 created by Daniel Sedmak.\nCopyright 2016 Daniel Sedmak - Released under the MIT License";
                    break;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(about, aboutMenu.Text + " "+this.Text);
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
        }

        private void githubLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dansita/MouseGuardian");
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

