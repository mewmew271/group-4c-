using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testFormactual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			
		}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			string Name = fName.Text;
			string Database = Fdatabase.Text;
			string ID = fID.Text;

			//MessageBox.Show(Name + "\n" + Database + "\n" + ID);

            output output = new output(Name, ID);
            
            output.Show();
			//Close();

            
        }

        //https://www.guru99.com/c-sharp-windows-forms-application.html
        //https://stackoverflow.com/questions/11779143/how-do-i-run-a-python-script-from-c
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string Name = fName.Text;
            string Database = Fdatabase.Text;
            int ID = random.Next(1, 100000);

            MessageBox.Show(Name + "\n" + Database + "\n" + ID);

           
        }


        private void wishlist_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

		private void Fdatabase_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void fID_TextChanged(object sender, EventArgs e)
        {

        }

        private void showWish_Click(object sender, EventArgs e)
        {
            wishlist wishlist = new wishlist();
            wishlist.Show();
        }
    }
}
