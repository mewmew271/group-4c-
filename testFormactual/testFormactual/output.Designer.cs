namespace testFormactual
{
    partial class output
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.outputFilmName = new System.Windows.Forms.Label();
			this.directorsName = new System.Windows.Forms.Label();
			this.wlFilmId = new System.Windows.Forms.Label();
			this.wlFilmName = new System.Windows.Forms.Label();
			this.outputFilmID = new System.Windows.Forms.Label();
			this.outputFilmDirector = new System.Windows.Forms.Label();
			this.saveToWl = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// outputFilmName
			// 
			this.outputFilmName.AutoSize = true;
			this.outputFilmName.Location = new System.Drawing.Point(39, 52);
			this.outputFilmName.Name = "outputFilmName";
			this.outputFilmName.Size = new System.Drawing.Size(53, 13);
			this.outputFilmName.TabIndex = 0;
			this.outputFilmName.Text = "FilmName";
			this.outputFilmName.Click += new System.EventHandler(this.label1_Click);
			// 
			// directorsName
			// 
			this.directorsName.AutoSize = true;
			this.directorsName.Location = new System.Drawing.Point(195, 25);
			this.directorsName.Name = "directorsName";
			this.directorsName.Size = new System.Drawing.Size(78, 13);
			this.directorsName.TabIndex = 6;
			this.directorsName.Text = "Directors name";
			// 
			// wlFilmId
			// 
			this.wlFilmId.AutoSize = true;
			this.wlFilmId.Location = new System.Drawing.Point(124, 25);
			this.wlFilmId.Name = "wlFilmId";
			this.wlFilmId.Size = new System.Drawing.Size(39, 13);
			this.wlFilmId.TabIndex = 5;
			this.wlFilmId.Text = "Film ID";
			// 
			// wlFilmName
			// 
			this.wlFilmName.AutoSize = true;
			this.wlFilmName.Location = new System.Drawing.Point(39, 25);
			this.wlFilmName.Name = "wlFilmName";
			this.wlFilmName.Size = new System.Drawing.Size(59, 13);
			this.wlFilmName.TabIndex = 4;
			this.wlFilmName.Text = "Film Name ";
			// 
			// outputFilmID
			// 
			this.outputFilmID.AutoSize = true;
			this.outputFilmID.Location = new System.Drawing.Point(124, 52);
			this.outputFilmID.Name = "outputFilmID";
			this.outputFilmID.Size = new System.Drawing.Size(36, 13);
			this.outputFilmID.TabIndex = 7;
			this.outputFilmID.Text = "FilmID";
			this.outputFilmID.Click += new System.EventHandler(this.outputFilmID_Click);
			// 
			// outputFilmDirector
			// 
			this.outputFilmDirector.AutoSize = true;
			this.outputFilmDirector.Location = new System.Drawing.Point(195, 52);
			this.outputFilmDirector.Name = "outputFilmDirector";
			this.outputFilmDirector.Size = new System.Drawing.Size(78, 13);
			this.outputFilmDirector.TabIndex = 8;
			this.outputFilmDirector.Text = "Directors name";
			// 
			// saveToWl
			// 
			this.saveToWl.Location = new System.Drawing.Point(42, 385);
			this.saveToWl.Name = "saveToWl";
			this.saveToWl.Size = new System.Drawing.Size(104, 23);
			this.saveToWl.TabIndex = 9;
			this.saveToWl.Text = "save to wishlist";
			this.saveToWl.UseVisualStyleBackColor = true;
			this.saveToWl.Click += new System.EventHandler(this.saveToWl_Click);
			// 
			// output
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.saveToWl);
			this.Controls.Add(this.outputFilmDirector);
			this.Controls.Add(this.outputFilmID);
			this.Controls.Add(this.directorsName);
			this.Controls.Add(this.wlFilmId);
			this.Controls.Add(this.wlFilmName);
			this.Controls.Add(this.outputFilmName);
			this.Name = "output";
			this.Text = "output";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputFilmName;
		private System.Windows.Forms.Label directorsName;
		private System.Windows.Forms.Label wlFilmId;
		private System.Windows.Forms.Label wlFilmName;
		private System.Windows.Forms.Label outputFilmID;
		private System.Windows.Forms.Label outputFilmDirector;
		private System.Windows.Forms.Button saveToWl;
	}
}