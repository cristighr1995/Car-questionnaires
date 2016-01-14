using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chestionar_Auto_Bun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nume;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Width = 950;
            this.Height = 700;
            //
            Form10 formZece = new Form10();
            formZece.ShowDialog();
            if (formZece.Item != "")
            {
                label19.Text = formZece.Item;
            }
            //
            panel1.Visible = false;
            panel1.Size = new Size(290,370);
            panel1.Top = 200;
            panel1.Left = 915;
            //
            ///aici sunt controalele din interiorul panelului
            //
            label20.Width = 290;
            label20.Height = 70;
            label20.Top = 0;
            label20.Left = 0;
            label20.Text = "Personalizare";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            label20.Font = new Font("Calibri",16);
            //
            label14.AutoSize = true;
            label14.Top = 127;
            label14.Left = 5;
            label14.Text = "Schimbati imaginea de fundal";
            label14.Font = new Font("Calibri",11);
            label14.BackColor = Color.Transparent;
            //
            //
            label16.AutoSize = true;
            label16.Top = 181;
            label16.Left = 5;
            label16.Text = "Schimbati numele";
            label16.Font = new Font("Calibri", 11);
            label16.BackColor = Color.Transparent;
            //
            label17.AutoSize = true;
            label17.Top = 235;
            label17.Left = 5;
            label17.Text = "Schimbati imaginea de profil";
            label17.Font = new Font("Calibri", 11);
            label17.BackColor = Color.Transparent;
            //
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.Top = 228;
            pictureBox1.Left = 251;
            pictureBox1.BackgroundImage = pictureBox2.BackgroundImage;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            //
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.Top = 117;
            pictureBox3.Left = 251;
            pictureBox3.BackgroundImage = this.BackgroundImage;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            //
            label18.Size = new Size(75, 30);
            label18.Top = 324;
            label18.Left = 205;
            label18.Text = "OK";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            //
            ///pana aici sunt 
            //
            label19.BackColor = Color.Transparent;
            label19.Width = 250;
            label19.Height = 70;
            label19.Top = 50;
            label19.Left = 550;
            label19.AutoSize = false;
            label19.TextAlign = ContentAlignment.MiddleRight;
            label19.ForeColor = Color.White;
            //
            //
            pictureBox2.Width = 70;
            pictureBox2.Height = 70;
            pictureBox2.Top = 50;
            pictureBox2.Left = 805;
            pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\profil.png");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            //
            label1.Width = 120;
            label1.Height = 120;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Top = 200;
            label1.Left = 60;
            //
            label2.Width = 120;
            label2.Height = 120;
            label2.Text = "2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Top = 200;
            label2.Left = 185;
            //
            label3.Width = 120;
            label3.Height = 120;
            label3.Text = "3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Top = 325;
            label3.Left = 60;
            //
            label4.Width = 120;
            label4.Height = 120;
            label4.Text = "4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Top = 325;
            label4.Left = 185;
            //
            label5.Width = 120;
            label5.Height = 120;
            label5.Text = "5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Top = 450;
            label5.Left = 60;
            //
            label6.Width = 120;
            label6.Height = 120;
            label6.Text = "6";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Top = 450;
            label6.Left = 185;
            //
            label7.Width = 250;
            label7.Height = 120;
            label7.Text = "Semne rutiere";
            label7.TextAlign = ContentAlignment.BottomLeft;
            label7.Top = 200;
            label7.Left = 340;
            label7.Font = new Font("Calibri", 10);
            //
            label8.Width = 250;
            label8.Height = 120;
            label8.Text = "Curs de prim ajutor";
            label8.TextAlign = ContentAlignment.BottomLeft;
            label8.Top = 325;
            label8.Left = 340;
            label8.Font = new Font("Calibri", 10);
            //
            label9.Width = 250;
            label9.Height = 120;
            label9.Text = "Legislatie";
            label9.TextAlign = ContentAlignment.BottomLeft;
            label9.Top = 450;
            label9.Left = 340;
            label9.Font = new Font("Calibri", 10);
            //
            label10.Width = 250;
            label10.Height = 120;
            label10.Text = "Ajutor si sfaturi";
            label10.TextAlign = ContentAlignment.BottomLeft;
            label10.Top = 200;
            label10.Left = 625;
            label10.Font = new Font("Calibri", 10);
            //
            label11.Width = 250;
            label11.Height = 120;
            label11.Text = "Amuzament";
            label11.TextAlign = ContentAlignment.BottomLeft;
            label11.Top = 325;
            label11.Left = 625;
            label11.Font = new Font("Calibri",12);
            //
            label12.Width = 122;
            label12.Height = 120;
            label12.Text = "Personalizare";
            label12.TextAlign = ContentAlignment.BottomLeft;
            label12.Top = 450;
            label12.Left = 625;
            //
            label13.Width = 122;
            label13.Height = 120;
            ///nu are text/// e butonul de Bye Bye
            label13.Top = 450;
            label13.Left = 753;
            //

            labelTitlu.BackColor = Color.Transparent;
            labelTitlu.ForeColor = Color.White;
            label7.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\semnrutier.jpg");
            label7.BackgroundImageLayout = ImageLayout.Stretch;
            label8.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\ajutor.jpg");
            label8.BackgroundImageLayout = ImageLayout.Stretch;
            label9.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\legislatie.jpg");
            label9.BackgroundImageLayout = ImageLayout.Stretch;
            label10.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\help.jpg");
            label10.BackgroundImageLayout = ImageLayout.Stretch;
            label11.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\troll.jpg");
            label11.BackgroundImageLayout = ImageLayout.Stretch;
            label12.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\setari.png");
            label12.BackgroundImageLayout = ImageLayout.Stretch;
            label13.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\keepcalm.png");
            label13.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 formDoi = new Form2();
            formDoi.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form3 formTrei = new Form3();
            formTrei.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 formPatru = new Form4();
            formPatru.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6 formSase = new Form6();
            formSase.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form7 formSapte = new Form7();
            formSapte.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Pdf\\Semne rutiere.pdf");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Pdf\\Curs prim ajutor.pdf");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Pdf\\Cod rutier.pdf");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 formCinci = new Form5();
            formCinci.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            Form8 formOpt = new Form8();
            formOpt.Show();
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1275, 700);
            panel1.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form9 formNoua = new Form9();
            formNoua.ShowDialog();
        }

        //Schimba imaginea de fundal
        private void label14_Click(object sender, EventArgs e)
        {
            OpenFileDialog backImage = new OpenFileDialog();
            if (backImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox3.BackgroundImage = Image.FromFile(backImage.FileName);
                pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        //Schimba imaginea de profil
        private void label17_Click(object sender, EventArgs e)
        {
            OpenFileDialog profileImage = new OpenFileDialog();
            if(profileImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(profileImage.FileName);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
           
            Form11 formNume = new Form11();
            formNume.ShowDialog();
            if(formNume.Item2!="")
            {
                nume = formNume.Item2;
            }
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = pictureBox3.BackgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //
            label19.Text = nume;
            //
            pictureBox2.BackgroundImage = pictureBox1.BackgroundImage;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            ///
            //dupa ce schimba toate setarile panoul dispare
            ///
            panel1.Visible = false;
            this.Width = 950;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
