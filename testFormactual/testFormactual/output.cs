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
    public partial class output : Form
    {
        public output(string name, string ID)
        {
            InitializeComponent();
            outputFilmName.Text = name;
			outputFilmID.Text = ID;
			outputFilmDirector.Text = "bob";
		}

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            
            
        }

		private void outputFilmID_Click(object sender, EventArgs e)
		{

		}

		private void saveToWl_Click(object sender, EventArgs e)
		{
			wishlist wishlist = new wishlist(outputFilmName.Text, outputFilmID.Text, outputFilmDirector.Text);
			//string text = outputFilmName.Text outputFilmID.Text outputFilmDirector.Text;

			string[] wlSave = { outputFilmName.Text, outputFilmID.Text, outputFilmDirector.Text};
			using (System.IO.StreamWriter file =
					   new System.IO.StreamWriter(@"C:\Users\Student\Desktop\WriteText.txt"))
			{
				foreach (string line in wlSave)				
				file.WriteLine(line);
			}

			//System.IO.File.WriteAllText(@"C:\Users\Student\Desktop\WriteText.txt", text);
			this.Close();
			//wishlist.Show();
		}
	}
}
