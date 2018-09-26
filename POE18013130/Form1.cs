using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE18013130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int postionsY = 1;

            for (int i = 0; i < 5; i++)
            {
                int posX = 20;

                for (int k = 0; k < 50; i++)
                {

                    Button myButton = new Button();
                    Point myButtonLocation = new Point(posX, postionsY);
                    Size myButtonSize = new Size(40, 30);
                    String myButtonText = new Map().ToString();

                    myButton.ForeColor = Color.Gray;

                    posX = posX + 50;

                    myButton.Location = myButtonLocation;
                    myButton.Size = myButtonSize;
                    myButton.Text = myButtonText;


                    this.Controls.Add(myButton);
                }
                postionsY = postionsY + 50;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1. Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
    //El0ei
   
}
