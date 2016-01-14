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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Width = 900;
            this.Height = 600;
            this.Text = "Ajutor";
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\help_wood.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //
            label1.Size = new Size(62, 70);
            label1.Top = 23;
            label1.Left = 56;
            label1.Cursor = Cursors.Hand;
            label1.Text = "";
            label1.BackColor = Color.Transparent;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
