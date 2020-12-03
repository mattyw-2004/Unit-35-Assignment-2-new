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
            try// adding try and catch to prevent the programming from crashing
            {
                //numbers are added into the code via textboxes 
                double height = double.Parse(textBox4.Text);
                double length = double.Parse(textBox6.Text);
                double width = double.Parse(textBox5.Text);
                //surface area is calculated after the numbers are added into the textboxes 
                double surfacearea = (2 * length * height * 2 * length * width * 2 * width * height);
                // answear will go to the label and that will display the answer fo who is using the programming 
                label2.Text = "surface area is " + surfacearea;

            }
            catch
            {
                //make it a bit funny and show how sick the epic cuboid is by a big message
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
               // taking numbers from textbox
                //calculating the surface area and implementing pi into the mix 
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
               //numbers are taken from the textboxes 
                //calculating using fractions and pi again 
                double radius = double.Parse(textBox7.Text);
                //fractions have to have a .0 after them 
                double volume = (4.0 / 3.0 * Math.PI * radius * radius * radius);
                label6.Text = "voulme is " + volume;

            }
            catch
            {
                MessageBox.Show("EPIC SHERE SAYS NANI NOW TRY AGAIN");
                //you are  not funny


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
            try//use try and catch to prevent crashing from letters being entered
            {
                //numbers are taken from the text boxes 
                double height = double.Parse(textBox10.Text);
                double radius = double.Parse(textBox9.Text);
                //calculating surface area of a cone 
                double surfacearea = (Math.PI * radius *(radius + Math.Sqrt(height * height + radius * radius)));
                label4.Text = "Surface area = " + surfacearea;
                //sending the answer to the label 
            }
            catch
            {
                // use message box to tell the user that something is wrong with the input
                MessageBox.Show("this isnt possible says the cone");
                // I am sensing a theme here mainly being these shapes are awsome and you should tell the creator 
            }
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try// using try and catch to prevent crashing on my hard work 
            {
                double radius = double.Parse(textBox11.Text);
                double height = double.Parse(textBox12.Text);
                //the radius and the height go into the calclation using fractions and pi again
                double volume = (1.0 / 3.0 * Math.PI * radius * radius * height);
                label7.Text = "volume =" + volume; 
                //answer is sent to the label 
            }
            catch
            {
                //messagebox used to tell that somthing is wrong with the input 
                MessageBox.Show(" something is wrong try again");
                //i just coulnt be bothered making this one funny 
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
