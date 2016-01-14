using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Chestionar_Auto_Bun
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        StreamReader banc_sofer = new StreamReader(Application.StartupPath + "\\bancuri_soferi.txt");
        
        StreamReader banc_computer = new StreamReader(Application.StartupPath + "\\bancuri_computer.txt");
        
        StreamReader banc_politist = new StreamReader(Application.StartupPath + "\\bancuri_politisti.txt");

        private void label1_Click(object sender, EventArgs e)
        {
            //reseteaza la inceputul textului fiecare streamReader
            banc_sofer.BaseStream.Position = 0;
            banc_sofer.DiscardBufferedData();
            banc_politist.BaseStream.Position = 0;
            banc_politist.DiscardBufferedData();
            banc_computer.BaseStream.Position = 0;
            banc_computer.DiscardBufferedData();
            label5.Visible = false;
            label6.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            richTextBox1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            richTextBox1.Text = banc_sofer.ReadToEnd();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            banc_sofer.BaseStream.Position = 0;
            banc_sofer.DiscardBufferedData();
            banc_politist.BaseStream.Position = 0;
            banc_politist.DiscardBufferedData();
            banc_computer.BaseStream.Position = 0;
            banc_computer.DiscardBufferedData();
            label5.Visible = false;
            label6.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            richTextBox1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            
            richTextBox1.Text = banc_politist.ReadToEnd();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            banc_sofer.BaseStream.Position = 0;
            banc_sofer.DiscardBufferedData();
            banc_politist.BaseStream.Position = 0;
            banc_politist.DiscardBufferedData();
            banc_computer.BaseStream.Position = 0;
            banc_computer.DiscardBufferedData();
            label5.Visible = false;
            label6.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            richTextBox1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            
            richTextBox1.Text = banc_computer.ReadToEnd();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800,600);
            this.Text = "Amuzament";
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\fund.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //
            richTextBox1.Size = new Size(510,420);
            richTextBox1.Left = 260;
            richTextBox1.Top = 120;
            richTextBox1.Text = banc_sofer.ReadToEnd();
            //
            label1.Cursor = Cursors.Hand;
            label2.Cursor = Cursors.Hand;
            label3.Cursor = Cursors.Hand;
            label4.Cursor = Cursors.Hand;
            //
            panel1.Size = new Size(225,190);
            panel1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\panel.jpg");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            //
            axWindowsMediaPlayer1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            //
            label7.BackColor = Color.Transparent;
            label7.Size = new Size(46,54);
            label7.Left = 45;
            label7.Top = 26;
            label7.Text = "";
            label7.Cursor = Cursors.Hand;
            //
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            //
            label5.Size = new Size(100,23);
            label5.Left = 74;
            label5.Top = 328;
            label5.Text = "Video 1";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\wood.png");
            label5.BackgroundImageLayout = ImageLayout.Stretch;
            //
            label6.Size = new Size(100, 23);
            label6.Left = 74;
            label6.Top = 362;
            label6.Text = "Video 2";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\wood.png");
            label6.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Location = richTextBox1.Location;
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\video\\1.mp4"; 
            label5.Visible = true;
            label6.Visible = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\video\\1.mp4";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\video\\2.mp4";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
