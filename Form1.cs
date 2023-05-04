using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{

    

    public partial class Form1 : Form
    {
        

        #region dlls

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        #endregion
        private Timer timer = new Timer(); // Timer-Instanz


        public Form1()
        {
            InitializeComponent();
            cbToggle.Size = new Size(80, 20);


            // Timer-Konfiguration
            timer.Tick += new EventHandler(CheckProcess); 
            timer.Interval = 2000; // Zeitintervall in Millisekunden (hier 5 Sekunden)
            timer.Start(); 
        }
        private void CheckProcess(Object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName("javaw");

            if (process.Length > 0)
            {
                mcoffen.Text = "Minecraft is open!";
            }
            else
            {
                mcoffen.Text = "Minecraft isnt open!";
            }
        }

        private void cbToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sldCPS_Scroll(object sender, ScrollEventArgs e)
        {
            lbCPS.Text = $"{sldCPS.Value}";
            
        }
        bool isShifting = false;
        private void LeftClick_Tick(object sender, EventArgs e)
        {
            LeftClick.Interval = 1000 / randomisedCPS;
            

            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (cbToggle.Checked && !isShifting) 
                    { 
                        if(MouseButtons == MouseButtons.Left)
                        {
                        SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Task.Delay(5);
                        SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                    
                }
                if (cbShiftD.Checked)
                {

               
                    if(GetAsyncKeyState(Keys.LShiftKey) < 0)
                    {
                        isShifting = true;
                    }
                    else
                    {
                        isShifting = false;
                    }
                }
            }
        }

        

        private void lbCPS_Click(object sender, EventArgs e)
        {

        }

        int randomisedCPS = 10;
        private void Random_Tick(object sender, EventArgs e)
        {
            randomisedCPS = new Random().Next(sldCPS.Value -3, sldCPS.Value + 3);
        }

        private void btBind_KeyUp(object sender, KeyEventArgs e)
        {
            if(btBind.Text == "...")
            {

            
                if(GetAsyncKeyState(Keys.Escape) < 0)
                {
                btBind.Text = "none";
                }
                else
                {
                btBind.Text = e.KeyCode.ToString();
                }
            }
        }

        private void btBind_Click(object sender, EventArgs e)
        {
            btBind.Text = "...";
        }
        public static KeysConverter Key = new KeysConverter();
        private void Bind_Tick(object sender, EventArgs e)
        {
            if(btBind.Text != "none")
            {
                if(btBind.Text != "...")
                {
                    Keys key = (Keys)Key.ConvertFromString(btBind.Text);
                    if(GetAsyncKeyState(key) < 0)
                    {
                        cbToggle.Checked = !cbToggle.Checked;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mcoffen_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
