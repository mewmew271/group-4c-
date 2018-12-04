using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testFormactual
{
    public partial class wishlist : Form
    {
        public wishlist(string name, string ID, string director)
        {
            InitializeComponent();
			
			string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Student\Desktop\WriteText.txt");
			List<string> filmName =  new List<string>();
			List<string> directorName = new List<string>();
			List<string> filmID = new List<string>();

			for (int x = 0; x < lines.Length; x=x+3)
			{
				filmName.Add(lines[x]);				
				filmID.Add(lines[x+1]);
				directorName.Add(lines[x+2]);	
			}
			
			if (lines.Length/3 > 0)
			{
				fName1.Visible = true;
				fId1.Visible = true;
				dName1.Visible = true;

				fName1.Text = filmName[0];
				fId1.Text = filmID[0];
				dName1.Text = directorName[0];
			}
			if (lines.Length/3 > 1)
			{
				fName2.Visible = true;
				fId2.Visible = true;
				dName3.Visible = true;

				fName2.Text = filmName[1];
				fId2.Text = filmID[1];
				dName2.Text = directorName[1];
			}
			if (lines.Length/3 > 2)
			{
				fName3.Visible = true;
				fId3.Visible = true;
				dName3.Visible = true;

				fName3.Text = filmName[2];
				fId3.Text = filmID[2];
				dName3.Text = directorName[2];
			}
			if (lines.Length/3 > 3)
			{
				fName4.Visible = true;
				fId4.Visible = true;
				dName4.Visible = true;

				fName4.Text = filmName[3];
				fId4.Text = filmID[3];
				dName4.Text = directorName[3];
			}
			if (lines.Length/3 > 4)
			{
				fName5.Visible = true;
				fId5.Visible = true;
				dName5.Visible = true;

				fName5.Text = filmName[4];
				fId5.Text = filmID[4];
				dName5.Text = directorName[4];
			}


		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void wishlist_Load(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void fId10_Click(object sender, EventArgs e)
		{

		}

		private void dName9_Click(object sender, EventArgs e)
		{

		}

		private void dName8_Click(object sender, EventArgs e)
		{

		}

		private void dName7_Click(object sender, EventArgs e)
		{

		}

		private void fId9_Click(object sender, EventArgs e)
		{

		}

		private void fId8_Click(object sender, EventArgs e)
		{

		}

		private void fId7_Click(object sender, EventArgs e)
		{

		}

		private void dName6_Click(object sender, EventArgs e)
		{

		}

		private void fId6_Click(object sender, EventArgs e)
		{

		}

		private void dName5_Click(object sender, EventArgs e)
		{

		}

		private void fId5_Click(object sender, EventArgs e)
		{

		}

		private void fName10_Click(object sender, EventArgs e)
		{

		}

		private void fName9_Click(object sender, EventArgs e)
		{

		}

		private void fName38_Click(object sender, EventArgs e)
		{

		}

		private void fName7_Click(object sender, EventArgs e)
		{

		}

		private void fName6_Click(object sender, EventArgs e)
		{

		}

		private void fName5_Click(object sender, EventArgs e)
		{

		}

		private void dName4_Click(object sender, EventArgs e)
		{

		}

		private void dName3_Click(object sender, EventArgs e)
		{

		}

		private void dName2_Click(object sender, EventArgs e)
		{

		}

		private void fId4_Click(object sender, EventArgs e)
		{

		}

		private void fId3_Click(object sender, EventArgs e)
		{

		}

		private void fId2_Click(object sender, EventArgs e)
		{

		}

		private void fName4_Click(object sender, EventArgs e)
		{

		}

		private void fName3_Click(object sender, EventArgs e)
		{

		}

		private void fName2_Click(object sender, EventArgs e)
		{

		}

		private void dName1_Click(object sender, EventArgs e)
		{

		}

		private void fId1_Click(object sender, EventArgs e)
		{

		}

		private void dName10_Click(object sender, EventArgs e)
		{

		}
	}
}
