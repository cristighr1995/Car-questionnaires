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
    public partial class Form2 : Form
    {
        Label[,] answerLabel = new Label [1,3]; //label-ul cu raspunsuri 
        bool[] Checked = new bool[26]; //vectorul in care se retine daca s-a raspuns la intrebare
        string[,] item = new string[26, 7]; //itemul care retine liniile din fisier
        int answersNo, currentQuestion, totalNo, goodScore, wrongScore; 
        //citeste din fisier intrebarile 
        StreamReader question = new StreamReader(Application.StartupPath + "\\intrebari.txt"); 
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            totalNo = 26;
            answersNo = 0;
            currentQuestion = 0;
            goodScore = 0;
            wrongScore = 0;
            int i = 0, j;
            //design
            this.Height = 700;
            this.Width = 1120;
            this.Text = "Chestionarul #1";
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Form1\\1.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Label\\thumb_up.jpg");
            pictureBox3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Label\\thumb_down.jpg");
            pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Label\\questions.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Label\\trimit_raspunsul.jpg");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini Label\\raspund_mai_tarziu.jpg");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            // // //
            label1.Width = 1000;
            label1.Height = 270;
            label1.Left = 50;
            label1.Top = 150;
            //
            label2.Width = 220;
            label2.Height = 50;
            label2.Top = 70;
            label2.Left = 50;
            //
            label3.Width = 220;
            label3.Height = 50;
            label3.Top = 70;
            label3.Left = 310;
            //
            label4.Width = 220;
            label4.Height = 50;
            label4.Top = 70;
            label4.Left = 570;
            //
            label5.Width = 220;
            label5.Height = 50;
            label5.Top = 70;
            label5.Left = 830;
            //
            pictureBox1.Width = 47;
            pictureBox1.Height = 47;
            pictureBox1.Left = 52;
            pictureBox1.Top = 72;
            //
            pictureBox2.Width = 47;
            pictureBox2.Height = 47;
            pictureBox2.Left = 312;
            pictureBox2.Top = 72;
            //
            pictureBox3.Width = 47;
            pictureBox3.Height = 47;
            pictureBox3.Left = 572;
            pictureBox3.Top = 72;
            //
            pictureBox4.Width = 370;
            pictureBox4.Height = 270;
            pictureBox4.Left = 680;
            pictureBox4.Top = 150;
            //
            button1.Width = 200;
            button1.Height = 50;
            button1.Left = 310;
            button1.Top = 585;
            //
            button2.Width = 200;
            button2.Height = 50;
            button2.Left = 570;
            button2.Top = 585;
            //
            label8.Width = 157;
            label8.Height = 47;
            label8.Top = 72;
            label8.Left = 105;
            label8.Font = new Font("Calibri", 10);
            label8.TextAlign = ContentAlignment.MiddleCenter;
            //
            label6.Width = 157;
            label6.Height = 47;
            label6.Top = 72;
            label6.Left = 365;
            label6.Font = new Font("Calibri", 10);
            label6.TextAlign = ContentAlignment.MiddleCenter;
            //
            label7.Width = 157;
            label7.Height = 47;
            label7.Top = 72;
            label7.Left = 625;
            label7.Font = new Font("Calibri", 10);
            label7.TextAlign = ContentAlignment.MiddleCenter;
            //
            pictureBox4.SendToBack();
            // // //

            //adauga butoanele pentru raspuns
            for ( j = 0; j < 3; j++)
            {
                 answerLabel[i, j] = new Label();
                 answerLabel[i, j].Left = 50;
                 answerLabel[i, j].AutoSize = false;
                 answerLabel[i, j].BorderStyle = BorderStyle.FixedSingle;
                 answerLabel[i, j].Width = 1000;
                 answerLabel[i, j].Height = 45;
                 answerLabel[i, j].Top = 430 +j * 50;
                 answerLabel[i, j].BackColor = Color.White;
                 answerLabel[i, j].TextAlign = ContentAlignment.MiddleLeft;
                 answerLabel[i, j].Font = new Font("Calibri", 11);
                 this.Controls.Add(answerLabel[i, j]);
            }

            for ( i = 0; i < 26; i++)
            {
                for ( j = 0; j < 7; j++)
                {
                    item[i, j] = question.ReadLine();
                }
                Checked[i] = false;
            }

            //incarca prima intrebare
            label1.Text = item[0, 0];
            answerLabel[0, 0].Text = item[0, 1];
            answerLabel[0, 1].Text = item[0, 3];
            answerLabel[0, 2].Text = item[0, 5];
            answerLabel[0, 0].Tag = "NU";
            answerLabel[0, 1].Tag = "NU";
            answerLabel[0, 2].Tag = "NU";
            //creeaza event handler (Click)
            answerLabel[0, 0].Click += new EventHandler(answer1_Click);
            answerLabel[0, 1].Click += new EventHandler(answer2_Click);
            answerLabel[0, 2].Click += new EventHandler(answer3_Click);     
     
            //raspunsuri corecte si gresite = 0
            label6.Text = "0 raspunsuri corecte";
            label7.Text = "0 raspunsuri gresite";
            label8.Text = "26 intrebari ramase";
        }

        // verifica daca raspunsul ales este corect si trece la urmatoare intrebare nerezolvata
        private void button1_Click(object sender, EventArgs e) 
        { 
            //tine evidenta intrebarilor la care s-a raspuns 
            Checked[currentQuestion] = true;

            if ((string)answerLabel[0, 0].Tag == item[currentQuestion, 2] && (string)answerLabel[0, 1].Tag == item[currentQuestion, 4] && (string)answerLabel[0, 2].Tag == item[currentQuestion, 6])
            {
                goodScore++;
                label6.Text = goodScore.ToString() + " raspunsuri corecte";
            }
            else
            {
                wrongScore++;
                label7.Text = wrongScore.ToString() + " raspunsuri gresite";
            }

            //actualizeaza cate intrebari au ramas
            label8.Text = (totalNo - answersNo - 1).ToString() + " intrebari ramase";
               
            answersNo++; // la fiecare apasare de buton, fie raspunsul corect sau nu
                         // mareste numarul de intrebari rezolvate
            if (wrongScore == 5)
            {
                MessageBox.Show("Ati fost declarat respins !!!");
            }

            if (answersNo < totalNo)
            {
                do
                {
                    if (currentQuestion < totalNo - 1) currentQuestion++;
                    else currentQuestion = 0;
                }
                while (Checked[currentQuestion] == true);

                //incarca prima intrebare nerezolvata
                label1.Text = item[currentQuestion, 0];
                answerLabel[0, 0].Text = item[currentQuestion, 1];
                answerLabel[0, 1].Text = item[currentQuestion, 3];
                answerLabel[0, 2].Text = item[currentQuestion, 5];
                answerLabel[0, 0].Tag = "NU";
                answerLabel[0, 1].Tag = "NU";
                answerLabel[0, 2].Tag = "NU";
                answerLabel[0, 0].BackColor = Color.White;
                answerLabel[0, 1].BackColor = Color.White;
                answerLabel[0, 2].BackColor = Color.White;
                label1.Width = 1000;
                pictureBox4.SendToBack();

                if (label1.Text == item[1, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\2.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[2, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\3.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[3, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\4.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[8, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\9.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[9, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\10.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[10, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\11.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[25, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\26.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
            }
            else
            {
                MessageBox.Show("Ati terminat testul !");
                if (goodScore >= 22)
                {
                    MessageBox.Show("FELICITARI !!! Ati fost declarat ADMIS !!!");
                }
                else
                {
                    MessageBox.Show("OF ! Nu-i nimic. Momentan nu sunteti prea bine pregatit");
                }
            }
            
        }

        //la fiecare apasare, culoarea de fundal si tag-ul se schimba , pentru a verifica apoi daca e corecta alegerea
        private void answer1_Click(object sender, EventArgs e)
        {
            if ( (string)answerLabel[0, 0].Tag == "NU")
            {
                answerLabel[0, 0].BackColor = Color.LightGreen;
                answerLabel[0, 0].Tag = "DA";
            }
            else
            {
                answerLabel[0, 0].BackColor = Color.White;
                answerLabel[0, 0].Tag = "NU";
            }
        }
        private void answer2_Click(object sender, EventArgs e)
        {
            if ( (string)answerLabel[0, 1].Tag == "NU")
            {
                answerLabel[0, 1].BackColor = Color.LightGreen;
                answerLabel[0, 1].Tag = "DA";
            }
            else
            {
                answerLabel[0, 1].BackColor = Color.White;
                answerLabel[0, 1].Tag = "NU";
            }
        }
        private void answer3_Click(object sender, EventArgs e)
        {
            if ( (string)answerLabel[0, 2].Tag == "NU")
            {
                answerLabel[0, 2].BackColor = Color.LightGreen;
                answerLabel[0, 2].Tag = "DA";
            }
            else
            {
                answerLabel[0, 2].BackColor = Color.White;
                answerLabel[0, 2].Tag = "NU";
            }
        }

        //butonul "raspund mai tarziu" 
        private void button2_Click(object sender, EventArgs e)
        {
            //incarca prima intrebare nerezolvata, fara a o bifa ca rezolvata
            if (answersNo < totalNo)
            {
                do
                {
                    if (currentQuestion < totalNo - 1) currentQuestion++;
                    else currentQuestion = 0;
                }
                while (Checked[currentQuestion] == true);

                label1.Text = item[currentQuestion, 0];
                answerLabel[0, 0].Text = item[currentQuestion, 1];
                answerLabel[0, 1].Text = item[currentQuestion, 3];
                answerLabel[0, 2].Text = item[currentQuestion, 5];
                answerLabel[0, 0].Tag = "NU";
                answerLabel[0, 1].Tag = "NU";
                answerLabel[0, 2].Tag = "NU";
                label1.Width = 1000;
                pictureBox4.SendToBack();

                if (label1.Text == item[1, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\2.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[2, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\3.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[3, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\4.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[8, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\9.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[9, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\10.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[10, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\11.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
                if (label1.Text == item[25, 0])
                {
                    pictureBox4.BringToFront();
                    pictureBox4.BackgroundImage = Image.FromFile(Application.StartupPath + "\\imagini PictureBox\\26.jpg");
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
                    label1.Width = 632;
                }
            }
        } 

    }
}
