using System;

namespace Autoclicker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelWindowTitle = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.panelMain = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.CloseBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.PanelButtom = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.cbToggle = new System.Windows.Forms.CheckBox();
            this.sldCPS = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.lbCPS = new System.Windows.Forms.Label();
            this.LeftClick = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.cbShiftD = new System.Windows.Forms.CheckBox();
            this.btBind = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Bind = new System.Windows.Forms.Timer(this.components);
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mcoffen = new System.Windows.Forms.Label();
            this.panelWindowTitle.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowTitle
            // 
            this.panelWindowTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelWindowTitle.Controls.Add(this.siticonePanel1);
            this.panelWindowTitle.Controls.Add(this.siticoneControlBox1);
            this.panelWindowTitle.Controls.Add(this.CloseBox);
            resources.ApplyResources(this.panelWindowTitle, "panelWindowTitle");
            this.panelWindowTitle.Name = "panelWindowTitle";
            this.panelWindowTitle.ShadowDecoration.Parent = this.panelWindowTitle;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticonePanel1.Controls.Add(this.panelMain);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox3);
            resources.ApplyResources(this.siticonePanel1, "siticonePanel1");
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMain.Controls.Add(this.siticoneCircleButton1);
            this.panelMain.Controls.Add(this.label2);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            this.panelMain.ShadowDecoration.Parent = this.panelMain;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // siticoneControlBox2
            // 
            resources.ApplyResources(this.siticoneControlBox2, "siticoneControlBox2");
            this.siticoneControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox2.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            // 
            // siticoneControlBox3
            // 
            resources.ApplyResources(this.siticoneControlBox3, "siticoneControlBox3");
            this.siticoneControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox3.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox3.HoverState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            // 
            // siticoneControlBox1
            // 
            resources.ApplyResources(this.siticoneControlBox1, "siticoneControlBox1");
            this.siticoneControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox1.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            // 
            // CloseBox
            // 
            resources.ApplyResources(this.CloseBox, "CloseBox");
            this.CloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CloseBox.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.CloseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.CloseBox.HoverState.Parent = this.CloseBox;
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.ShadowDecoration.Parent = this.CloseBox;
            // 
            // PanelButtom
            // 
            this.PanelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            resources.ApplyResources(this.PanelButtom, "PanelButtom");
            this.PanelButtom.Name = "PanelButtom";
            this.PanelButtom.ShadowDecoration.Parent = this.PanelButtom;
            // 
            // cbToggle
            // 
            resources.ApplyResources(this.cbToggle, "cbToggle");
            this.cbToggle.Name = "cbToggle";
            this.cbToggle.UseVisualStyleBackColor = true;
            this.cbToggle.CheckedChanged += new System.EventHandler(this.cbToggle_CheckedChanged);
            // 
            // sldCPS
            // 
            this.sldCPS.HoverState.Parent = this.sldCPS;
            resources.ApplyResources(this.sldCPS, "sldCPS");
            this.sldCPS.Maximum = 25;
            this.sldCPS.Minimum = 5;
            this.sldCPS.Name = "sldCPS";
            this.sldCPS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.sldCPS.Value = 10;
            this.sldCPS.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sldCPS_Scroll);
            // 
            // lbCPS
            // 
            resources.ApplyResources(this.lbCPS, "lbCPS");
            this.lbCPS.Name = "lbCPS";
            this.lbCPS.Click += new System.EventHandler(this.lbCPS_Click);
            // 
            // LeftClick
            // 
            this.LeftClick.Enabled = true;
            this.LeftClick.Tick += new System.EventHandler(this.LeftClick_Tick);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // cbShiftD
            // 
            resources.ApplyResources(this.cbShiftD, "cbShiftD");
            this.cbShiftD.Name = "cbShiftD";
            this.cbShiftD.UseVisualStyleBackColor = true;
            // 
            // btBind
            // 
            this.btBind.CheckedState.Parent = this.btBind;
            this.btBind.CustomImages.Parent = this.btBind;
            this.btBind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBind.DisabledState.Parent = this.btBind;
            this.btBind.FillColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btBind, "btBind");
            this.btBind.ForeColor = System.Drawing.Color.White;
            this.btBind.HoverState.Parent = this.btBind;
            this.btBind.Name = "btBind";
            this.btBind.ShadowDecoration.Parent = this.btBind;
            this.btBind.Click += new System.EventHandler(this.btBind_Click);
            this.btBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btBind_KeyUp);
            // 
            // Bind
            // 
            this.Bind.Enabled = true;
            this.Bind.Interval = 150;
            this.Bind.Tick += new System.EventHandler(this.Bind_Tick);
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.DisabledState.Parent = this.siticoneCircleButton1;
            resources.ApplyResources(this.siticoneCircleButton1, "siticoneCircleButton1");
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.HoverState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Click += new System.EventHandler(this.siticoneCircleButton1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mcoffen
            // 
            resources.ApplyResources(this.mcoffen, "mcoffen");
            this.mcoffen.Name = "mcoffen";
            this.mcoffen.Click += new System.EventHandler(this.mcoffen_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ControlBox = false;
            this.Controls.Add(this.mcoffen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBind);
            this.Controls.Add(this.cbShiftD);
            this.Controls.Add(this.lbCPS);
            this.Controls.Add(this.sldCPS);
            this.Controls.Add(this.cbToggle);
            this.Controls.Add(this.PanelButtom);
            this.Controls.Add(this.panelWindowTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWindowTitle.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel panelWindowTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox CloseBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel panelMain;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelButtom;
        private System.Windows.Forms.CheckBox cbToggle;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar sldCPS;
        private System.Windows.Forms.Label lbCPS;
        private System.Windows.Forms.Timer LeftClick;
        private System.Windows.Forms.Timer Random;
        private System.Windows.Forms.CheckBox cbShiftD;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btBind;
        private System.Windows.Forms.Timer Bind;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mcoffen;

        public EventHandler RainbowCheckBox_Click { get; private set; }
    }
}

