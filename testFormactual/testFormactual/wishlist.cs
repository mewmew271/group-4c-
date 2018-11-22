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
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void wishlist_Load(object sender, EventArgs e)
		{

		}
	}
}
