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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private string numeNou;
        public string Item2
        {
            get { return numeNou; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeNou = textBox1.Text;
            this.Dispose();

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Size = new Size(300, 300);
            this.BackColor = Color.DarkCyan;
            this.Text = "Nume nou";
            //
            label1.Size = new Size(258, 27);
            label1.Top = 90;
            label1.Left = 12;
            label1.Text = "Va rugam introduceti numele";
            label1.Font = new Font("Calibri",11);
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            //
            textBox1.Size = new Size(258, 22);
            textBox1.Top = 130;
            textBox1.Left = 12;
            //
            button1.Size = new Size(75, 23);
            button1.Top = 218;
            button1.Left = 195;
            button1.Text = "Gata";
            //
        }
    }
}
