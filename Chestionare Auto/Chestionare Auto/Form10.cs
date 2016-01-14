using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chestionar_Auto_Bun
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private string raspuns;
        public string Item
        {
            get { return raspuns; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raspuns = textBox1.Text;
            this.Dispose();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300,300);
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\jeans.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "";
            //
            label1.Size = new Size(146,23);
            label1.Top = 10;
            label1.Left = 77;
            label1.Text = "Bine ati venit !!!";
            label1.Font = new Font("Calibri",12);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            //
            label2.Size = new Size(251,21);
            label2.Top = 110;
            label2.Left = 10;
            label2.Text = "Va rugam sa va introduceti numele";
            label2.Font = new Font("Calibri",10);
            label2.ForeColor = Color.White;
            label2.BackColor = Color.Transparent;
            //
            textBox1.Size = new Size(258,22);
            textBox1.Top = 140;
            textBox1.Left = 10;
            textBox1.MaxLength = 26;
            //
            button1.Size = new Size(75, 23);
            button1.Top = 218;
            button1.Left = 195;
            button1.Text = "Gata";
            //
        }

    }
}
