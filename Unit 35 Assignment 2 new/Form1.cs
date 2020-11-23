using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_35_Assignment_2_new
{
    public partial class Form1 : Form
    {
        public object TextBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //using try and catch to make sure the programme doesnt crash
            try
            {
                //read text from textboxes 
                double height = double.Parse(textBox1.Text);
                double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox3.Text);
                //Caclulate forces Fx and Fy
                double volume = (length * width * height);
                //output the answear to the labels 
                label1.Text = " volume is " + volume;

               
            }
            catch
            {
                //use catch to make it run properally 
                MessageBox.Show("EPIC CUBOID SAYS NO NOW TRY AGAIN. ");
            }
        }   
            

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(textBox4.Text);
                double length = double.Parse(textBox6.Text);
                double width = double.Parse(textBox5.Text);
                double surfacearea = (2 * length * height * 2 * length * width * 2 * width * height);
                label2.Text = "surface area is " + surfacearea;

            }
            catch
            {
                MessageBox.Show("EPIC CUBOID SAYS NO TRY AGAIN YOU MUPPET");
            }
         

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox8.Text);
                double surfacearea = (4 * Math.PI * radius * radius);
                label5.Text = " surface area is " + surfacearea;
            }
            catch
            {
                MessageBox.Show("EPIC SPHERE SAYS NO TRY AGAIN YOU IDIOT");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBox7.Text);
                double volume = (4.0 / 3.0 * Math.PI * radius * radius * radius);
                label6.Text = "voulme is " + volume;

            }
            catch
            {
                MessageBox.Show("EPIC SHERE SAYS NANI NOW TRY AGAIN");

            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
