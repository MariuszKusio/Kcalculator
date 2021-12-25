
namespace Kcalculator
{
    partial class Home
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlUpBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.TbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblHeight = new System.Windows.Forms.Label();
            this.TbHeight = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.lblBmiinfo = new System.Windows.Forms.Label();
            this.lblDayKc = new System.Windows.Forms.Label();
            this.PbPoland = new System.Windows.Forms.PictureBox();
            this.PbEnglish = new System.Windows.Forms.PictureBox();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHome = new System.Windows.Forms.Panel();
            this.TbDarkMode = new Kcalculator.ToggleButton();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlUpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPoland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEnglish)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpBar
            // 
            this.pnlUpBar.BackColor = System.Drawing.Color.White;
            this.pnlUpBar.Controls.Add(this.pictureBox1);
            this.pnlUpBar.Controls.Add(this.PbClose);
            this.pnlUpBar.Location = new System.Drawing.Point(0, 0);
            this.pnlUpBar.Name = "pnlUpBar";
            this.pnlUpBar.Size = new System.Drawing.Size(500, 26);
            this.pnlUpBar.TabIndex = 0;
            this.pnlUpBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlUpBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PbClose
            // 
            this.PbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbClose.Image = ((System.Drawing.Image)(resources.GetObject("PbClose.Image")));
            this.PbClose.Location = new System.Drawing.Point(476, 3);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(21, 20);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClose.TabIndex = 13;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // TbWeight
            // 
            this.TbWeight.BackColor = System.Drawing.SystemColors.Control;
            this.TbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbWeight.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TbWeight.Location = new System.Drawing.Point(65, 91);
            this.TbWeight.Name = "TbWeight";
            this.TbWeight.Size = new System.Drawing.Size(100, 20);
            this.TbWeight.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TbWeight, "Wprowadź swoją wagę w kg.");
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(5, 91);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(42, 17);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Waga";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(5, 130);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Wzrost";
            // 
            // TbHeight
            // 
            this.TbHeight.BackColor = System.Drawing.SystemColors.Control;
            this.TbHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHeight.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TbHeight.Location = new System.Drawing.Point(65, 130);
            this.TbHeight.Name = "TbHeight";
            this.TbHeight.Size = new System.Drawing.Size(100, 20);
            this.TbHeight.TabIndex = 3;
            this.toolTip2.SetToolTip(this.TbHeight, "Wprowadź swój wzrost w cm.");
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCalculate.Location = new System.Drawing.Point(90, 168);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 5;
            this.BtnCalculate.Text = "Oblicz";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(189, 90);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 17);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Twoje BMI wynosi :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(189, 129);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(227, 17);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Twoje dzienne zapotrzebowanie kcal :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(189, 168);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(288, 85);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = resources.GetString("lbl3.Text");
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmi.Location = new System.Drawing.Point(303, 90);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(15, 17);
            this.lblBmi.TabIndex = 10;
            this.lblBmi.Text = "0";
            this.toolTip3.SetToolTip(this.lblBmi, resources.GetString("lblBmi.ToolTip"));
            // 
            // lblBmiinfo
            // 
            this.lblBmiinfo.AutoSize = true;
            this.lblBmiinfo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBmiinfo.Location = new System.Drawing.Point(352, 91);
            this.lblBmiinfo.Name = "lblBmiinfo";
            this.lblBmiinfo.Size = new System.Drawing.Size(0, 17);
            this.lblBmiinfo.TabIndex = 11;
            // 
            // lblDayKc
            // 
            this.lblDayKc.AutoSize = true;
            this.lblDayKc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayKc.Location = new System.Drawing.Point(413, 129);
            this.lblDayKc.Name = "lblDayKc";
            this.lblDayKc.Size = new System.Drawing.Size(15, 17);
            this.lblDayKc.TabIndex = 12;
            this.lblDayKc.Text = "0";
            // 
            // PbPoland
            // 
            this.PbPoland.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbPoland.Image = ((System.Drawing.Image)(resources.GetObject("PbPoland.Image")));
            this.PbPoland.Location = new System.Drawing.Point(12, 268);
            this.PbPoland.Name = "PbPoland";
            this.PbPoland.Size = new System.Drawing.Size(21, 20);
            this.PbPoland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPoland.TabIndex = 14;
            this.PbPoland.TabStop = false;
            this.PbPoland.Click += new System.EventHandler(this.PbPoland_Click);
            // 
            // PbEnglish
            // 
            this.PbEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbEnglish.Image = ((System.Drawing.Image)(resources.GetObject("PbEnglish.Image")));
            this.PbEnglish.Location = new System.Drawing.Point(39, 268);
            this.PbEnglish.Name = "PbEnglish";
            this.PbEnglish.Size = new System.Drawing.Size(21, 20);
            this.PbEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbEnglish.TabIndex = 15;
            this.PbEnglish.TabStop = false;
            this.PbEnglish.Click += new System.EventHandler(this.PbEnglish_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHome.Controls.Add(this.TbDarkMode);
            this.pnlHome.Location = new System.Drawing.Point(0, 26);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(500, 275);
            this.pnlHome.TabIndex = 18;
            // 
            // TbDarkMode
            // 
            this.TbDarkMode.BackColor = System.Drawing.SystemColors.Control;
            this.TbDarkMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TbDarkMode.Location = new System.Drawing.Point(12, 217);
            this.TbDarkMode.MinimumSize = new System.Drawing.Size(40, 19);
            this.TbDarkMode.Name = "TbDarkMode";
            this.TbDarkMode.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TbDarkMode.OffToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TbDarkMode.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TbDarkMode.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TbDarkMode.Size = new System.Drawing.Size(40, 19);
            this.TbDarkMode.TabIndex = 17;
            this.toolTip4.SetToolTip(this.TbDarkMode, "Tryb ciemny");
            this.TbDarkMode.UseVisualStyleBackColor = false;
            this.TbDarkMode.CheckedChanged += new System.EventHandler(this.TbDarkMode_CheckedChanged);
            // 
            // toolTip4
            // 
            this.toolTip4.AutoPopDelay = 5000;
            this.toolTip4.InitialDelay = 800;
            this.toolTip4.ReshowDelay = 100;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.PbEnglish);
            this.Controls.Add(this.PbPoland);
            this.Controls.Add(this.lblDayKc);
            this.Controls.Add(this.lblBmiinfo);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.TbHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.TbWeight);
            this.Controls.Add(this.pnlUpBar);
            this.Controls.Add(this.pnlHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlUpBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPoland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEnglish)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpBar;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.TextBox TbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox TbHeight;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.Label lblBmiinfo;
        private System.Windows.Forms.Label lblDayKc;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbPoland;
        private System.Windows.Forms.PictureBox PbEnglish;
        private System.Windows.Forms.ToolTip toolTip3;
        private ToggleButton TbDarkMode;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

