using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kcalculator
{
    public partial class Home : Form
    {

        
        public Home()
        {
            InitializeComponent();
        }
        
        //Ruch okna
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlUpBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void BtnCalculate_Click(object sender, EventArgs e)
        {
            

            if (TbWeight.Text == "" || TbHeight.Text == "")
            {
                MessageBox.Show("Enter missing values");
            }
            else
            {
                try
                {
                    
                    float w = float.Parse(TbWeight.Text);
                    float h = (float.Parse(TbHeight.Text) / 100) * (float.Parse(TbHeight.Text) / 100);
                    float bmi = w/h;
                    double bmir = Math.Round(bmi, 2);
                    float kcal = w * 33;
                    lblDayKc.Text = kcal.ToString();
                    lblBmi.Text = bmir.ToString();


                    if (bmir < 16)
                    {
                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "Wygłodzenie";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Severe Thinness";
                        }
                    }
                    else if (bmir > 16 && bmir < 17)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "Wychudzenie";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Moderate Thinness";
                        }
                    }
                    else if (bmir > 17 && bmir < 18.5)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "Niedowaga";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Mild Thinness";
                        }
                    }
                    else if (bmir > 18.5 && bmir < 25)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "Wartość prawidłowa";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Normal";
                        }
                    }
                    else if (bmir > 25 && bmir < 30)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "Nadwaga";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Overweight";
                        }
                    }
                    else if (bmir > 30 && bmir < 35)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "I stopień otyłości";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Obese Class I";
                        }
                    }
                    else if (bmir > 35 && bmir < 40)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "II stopień otyłości";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Obese Class II";
                        }
                    }
                    else if (bmir > 40 && bmir < 299)
                    {

                        if (lblWeight.Text == "Waga")
                        {
                            lblBmiinfo.Text = "III stopień otyłości";
                        }
                        else
                        {
                            lblBmiinfo.Text = "Obese Class III";
                        }
                    }
                    else if (bmir > 300)
                    {
                        if (lblWeight.Text == "Waga")
                        {
                            MessageBox.Show("Zbyt wysokie BMI. Sprawdź poprawność danych.");
                        }
                        else
                        {
                            MessageBox.Show("To high BMI. Check your data.");
                        }
                        
                    }

                    }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbEnglish_Click(object sender, EventArgs e)
        {
            
            lbl1.Text = "Your BMI : ";
            lbl2.Text = "Your daily calories requirement : ";
            lblWeight.Text = "Weight";
            lblHeight.Text = "Height";
            toolTip1.SetToolTip(TbWeight, "Insert your weight in kg.");
            toolTip2.SetToolTip(TbHeight, "Insert your height in cm.");
            toolTip3.SetToolTip(lblBmi, "under 16 - severe thinness\n16 - 17 - moderate thinness\n17 - 18.5 - mild thinness\n18.5 - 25 - normal\n25 - 30 - overweight\n30 - 35 - obese class I\n35 - 40 - obese class II\nover 40 - obese class III");
            toolTip4.SetToolTip(TbDarkMode, "Dark mode");
            BtnCalculate.Text = "Calculate";
            lbl3.Text = "If you want to increase your mass, do you must\nadd the daily requirement from 300 to 600 kcal\ndepending on the activity physical.Otherwise, you\nmust subtract from the demand of 300 - 400kcal.";
            lblBmi.Location = new Point(252,90);
            lblDayKc.Location = new Point(382,129);
            lblBmiinfo.Location = new Point(287,90); 

            if(lblBmiinfo.Text == "Wygłodzenie")
            {
                lblBmiinfo.Text = "Severe Thinness";
            }
            else if(lblBmiinfo.Text == "Wychudzenie")
            {
                lblBmiinfo.Text = "Moderate Thinness";
            }
            else if (lblBmiinfo.Text == "Niedowaga")   
            {
                lblBmiinfo.Text = "Mild Thinness";
            }
            else if (lblBmiinfo.Text == "Wartość prawidłowa")
            {
                lblBmiinfo.Text = "Normal";
            }
            else if (lblBmiinfo.Text == "Nadwaga")
            {
                lblBmiinfo.Text = "Overweight";
            }
            else if (lblBmiinfo.Text == "I stopień otyłości")
            {
                lblBmiinfo.Text = "Obese Class I";
            }
            else if (lblBmiinfo.Text == "II stopień otyłości")
            {
                lblBmiinfo.Text = "Obese Class II";
            }
            else if (lblBmiinfo.Text == "III stopień otyłości")
            {
                lblBmiinfo.Text = "Obese Class III";
            }

        }

        private void PbPoland_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Twoje BMI wynosi : ";
            lbl2.Text = "Twoje dzienne zapotrzebowanie kcal : ";
            lblWeight.Text = "Waga";
            lblHeight.Text = "Wzrost";
            toolTip1.SetToolTip(TbWeight, "Wprowadź swoją wagę w kg.");
            toolTip2.SetToolTip(TbHeight, "Wprowadź swój wzrost w cm.");
            toolTip3.SetToolTip(lblBmi, "mniej niż 16 - wygłodzenie\n16 - 17 - wychudzenie\n17 - 18.5 - niedowaga\n18.5 - 25 - wartość prawidłowa\n25 - 30 - nadwaga\n30 - 35 - I stopień otyłości\n35 - 40 - II stopień otyłości\npowyżej 40 - III stopień otyłości");
            toolTip4.SetToolTip(TbDarkMode, "Tryb ciemny");
            BtnCalculate.Text = "Oblicz";
            lbl3.Text = "Jeżeli chcesz zwiększyć swoją masę to do\nzapotrzebowania dziennego musisz dodać\nod 300 do 600 kcal w zależności od aktywności\nfizycznej. W przeciwnym wypadku musisz odjąć\nod zapotrzebowania 300 - 400kcal.";
            lblBmi.Location = new Point(303, 90);
            lblDayKc.Location = new Point(413, 129);
            lblBmiinfo.Location = new Point(352, 90);

            if (lblBmiinfo.Text == "Severe Thinness")
            {
                lblBmiinfo.Text = "Wygłodzenie"; 
            }
            else if (lblBmiinfo.Text == "Moderate Thinness")
            {
                lblBmiinfo.Text = "Wychudzenie"; 
            }
            else if (lblBmiinfo.Text == "Mild Thinness")
            {
                lblBmiinfo.Text = "Niedowaga"; 
            }
            else if (lblBmiinfo.Text == "Normal")
            {
                lblBmiinfo.Text = "Wartość prawidłowa"; 
            }
            else if (lblBmiinfo.Text == "Overweight")
            {
                lblBmiinfo.Text = "Nadwaga"; 
            }
            else if (lblBmiinfo.Text == "Obese Class I")
            {
                lblBmiinfo.Text = "I stopień otyłości";
            }
            else if (lblBmiinfo.Text == "Obese Class II")
            {
                lblBmiinfo.Text = "II stopień otyłości"; 
            }
            else if (lblBmiinfo.Text == "Obese Class III")
            {
                lblBmiinfo.Text = "III stopień otyłości"; 
            }

            

        }
        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void TbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if(TbDarkMode.Checked)
            {
                // Back Color
                this.BackColor = Color.FromArgb(45, 45, 48);
                pnlUpBar.BackColor = Color.DarkGray;
                pnlHome.BackColor = Color.FromArgb(45, 45, 48);
                lbl3.BackColor = Color.FromArgb(45, 45, 48);
                lbl2.BackColor = Color.FromArgb(45, 45, 48);
                lbl1.BackColor = Color.FromArgb(45, 45, 48);
                lblBmi.BackColor = Color.FromArgb(45, 45, 48);
                lblBmiinfo.BackColor = Color.FromArgb(45, 45, 48);
                lblDayKc.BackColor = Color.FromArgb(45, 45, 48);
                lblHeight.BackColor = Color.FromArgb(45, 45, 48);
                lblWeight.BackColor = Color.FromArgb(45, 45, 48);
                TbHeight.BackColor = Color.FromArgb(45, 45, 48);
                TbWeight.BackColor = Color.FromArgb(45, 45, 48);
                // Text Color
                lbl1.ForeColor = Color.WhiteSmoke;
                lbl2.ForeColor = Color.WhiteSmoke;
                lbl3.ForeColor = Color.WhiteSmoke;
                lblBmi.ForeColor = Color.WhiteSmoke;
                lblBmiinfo.ForeColor = Color.WhiteSmoke;
                lblDayKc.ForeColor = Color.WhiteSmoke;
                lblHeight.ForeColor = Color.WhiteSmoke;
                lblWeight.ForeColor = Color.WhiteSmoke;
                TbWeight.ForeColor = Color.WhiteSmoke;
                TbHeight.ForeColor = Color.WhiteSmoke;
                // Button and PictureB
                BtnCalculate.BackColor = Color.DarkGray;
                BtnCalculate.ForeColor = Color.Black;
                PbPoland.BackColor = Color.FromArgb(45, 45, 48);
                PbEnglish.BackColor = Color.FromArgb(45, 45, 48);
                TbDarkMode.BackColor = Color.FromArgb(45, 45, 48);
            }
            else
            {
                // Back Color
                this.BackColor = Color.FromArgb(240, 240, 240);
                pnlUpBar.BackColor = Color.White;
                pnlHome.BackColor = Color.FromArgb(240, 240, 240);
                lbl3.BackColor = Color.FromArgb(240, 240, 240);
                lbl2.BackColor = Color.FromArgb(240, 240, 240);
                lbl1.BackColor = Color.FromArgb(240, 240, 240);
                lblBmi.BackColor = Color.FromArgb(240, 240, 240);
                lblBmiinfo.BackColor = Color.FromArgb(240, 240, 240);
                lblDayKc.BackColor = Color.FromArgb(240, 240, 240);
                lblHeight.BackColor = Color.FromArgb(240, 240, 240);
                lblWeight.BackColor = Color.FromArgb(240, 240, 240);
                TbHeight.BackColor = Color.FromArgb(240, 240, 240);
                TbWeight.BackColor = Color.FromArgb(240, 240, 240);
                // Text Color
                lbl1.ForeColor = Color.Black;
                lbl2.ForeColor = Color.Black;
                lbl3.ForeColor = Color.Black;
                lblBmi.ForeColor = Color.Black;
                lblBmiinfo.ForeColor = Color.Black;
                lblDayKc.ForeColor = Color.Black;
                lblHeight.ForeColor = Color.Black;
                lblWeight.ForeColor = Color.Black;
                TbWeight.ForeColor = Color.Black;
                TbHeight.ForeColor = Color.Black;
                // Button and PictureB
                BtnCalculate.BackColor = Color.FromArgb(240, 240, 240);
                BtnCalculate.ForeColor = Color.Black;
                PbPoland.BackColor = Color.FromArgb(240, 240, 240);
                PbEnglish.BackColor = Color.FromArgb(240, 240, 240);
                TbDarkMode.BackColor = Color.FromArgb(240, 240, 240);
            }


        }
    }
}
