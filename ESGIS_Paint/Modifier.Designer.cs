namespace ESGIS_Paint
{
    partial class Modifier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier));
            this.rotatePB = new System.Windows.Forms.PictureBox();
            this.droitePB = new System.Windows.Forms.PictureBox();
            this.gauchePB = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.quitPB = new System.Windows.Forms.PictureBox();
            this.mutePB = new System.Windows.Forms.PictureBox();
            this.soundPB = new System.Windows.Forms.PictureBox();
            this.openPB = new System.Windows.Forms.PictureBox();
            this.modifTT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rotatePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droitePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauchePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPB)).BeginInit();
            this.SuspendLayout();
            // 
            // rotatePB
            // 
            this.rotatePB.InitialImage = null;
            this.rotatePB.Location = new System.Drawing.Point(0, 67);
            this.rotatePB.Name = "rotatePB";
            this.rotatePB.Size = new System.Drawing.Size(788, 454);
            this.rotatePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotatePB.TabIndex = 0;
            this.rotatePB.TabStop = false;
            // 
            // droitePB
            // 
            this.droitePB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.droitePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.droitePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.droitePB.Image = ((System.Drawing.Image)(resources.GetObject("droitePB.Image")));
            this.droitePB.Location = new System.Drawing.Point(225, 5);
            this.droitePB.Name = "droitePB";
            this.droitePB.Size = new System.Drawing.Size(55, 50);
            this.droitePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.droitePB.TabIndex = 3;
            this.droitePB.TabStop = false;
            this.modifTT.SetToolTip(this.droitePB, "TOURNER A DROITE");
            this.droitePB.Click += new System.EventHandler(this.droitePB_Click);
            // 
            // gauchePB
            // 
            this.gauchePB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gauchePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gauchePB.Image = ((System.Drawing.Image)(resources.GetObject("gauchePB.Image")));
            this.gauchePB.Location = new System.Drawing.Point(147, 5);
            this.gauchePB.Name = "gauchePB";
            this.gauchePB.Size = new System.Drawing.Size(50, 50);
            this.gauchePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gauchePB.TabIndex = 4;
            this.gauchePB.TabStop = false;
            this.modifTT.SetToolTip(this.gauchePB, "TOURNER A GAUCHE");
            this.gauchePB.Click += new System.EventHandler(this.gauchePB_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(381, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.modifTT.SetToolTip(this.pictureBox3, "ENREGISTRER");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // quitPB
            // 
            this.quitPB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quitPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitPB.Image = ((System.Drawing.Image)(resources.GetObject("quitPB.Image")));
            this.quitPB.Location = new System.Drawing.Point(452, 5);
            this.quitPB.Name = "quitPB";
            this.quitPB.Size = new System.Drawing.Size(55, 50);
            this.quitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quitPB.TabIndex = 6;
            this.quitPB.TabStop = false;
            this.modifTT.SetToolTip(this.quitPB, "QUITTER");
            this.quitPB.Click += new System.EventHandler(this.quitPB_Click);
            // 
            // mutePB
            // 
            this.mutePB.Image = ((System.Drawing.Image)(resources.GetObject("mutePB.Image")));
            this.mutePB.Location = new System.Drawing.Point(596, 5);
            this.mutePB.Name = "mutePB";
            this.mutePB.Size = new System.Drawing.Size(44, 38);
            this.mutePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mutePB.TabIndex = 10;
            this.mutePB.TabStop = false;
            this.modifTT.SetToolTip(this.mutePB, "MUTE");
            this.mutePB.Click += new System.EventHandler(this.mutePB_Click);
            // 
            // soundPB
            // 
            this.soundPB.Image = ((System.Drawing.Image)(resources.GetObject("soundPB.Image")));
            this.soundPB.Location = new System.Drawing.Point(541, 12);
            this.soundPB.Name = "soundPB";
            this.soundPB.Size = new System.Drawing.Size(36, 31);
            this.soundPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundPB.TabIndex = 9;
            this.soundPB.TabStop = false;
            this.modifTT.SetToolTip(this.soundPB, "MUSIC");
            this.soundPB.Click += new System.EventHandler(this.soundPB_Click);
            // 
            // openPB
            // 
            this.openPB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openPB.Image = ((System.Drawing.Image)(resources.GetObject("openPB.Image")));
            this.openPB.Location = new System.Drawing.Point(23, 5);
            this.openPB.Name = "openPB";
            this.openPB.Size = new System.Drawing.Size(70, 56);
            this.openPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openPB.TabIndex = 11;
            this.openPB.TabStop = false;
            this.modifTT.SetToolTip(this.openPB, "OUVRIR");
            this.openPB.Click += new System.EventHandler(this.openPB_Click);
            // 
            // modifTT
            // 
            this.modifTT.AutoPopDelay = 5000;
            this.modifTT.InitialDelay = 50;
            this.modifTT.ReshowDelay = 100;
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.openPB);
            this.Controls.Add(this.mutePB);
            this.Controls.Add(this.soundPB);
            this.Controls.Add(this.quitPB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gauchePB);
            this.Controls.Add(this.droitePB);
            this.Controls.Add(this.rotatePB);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotatePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droitePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauchePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rotatePB;
        private System.Windows.Forms.PictureBox droitePB;
        private System.Windows.Forms.PictureBox gauchePB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox quitPB;
        private System.Windows.Forms.PictureBox mutePB;
        private System.Windows.Forms.PictureBox soundPB;
        private System.Windows.Forms.PictureBox openPB;
        private System.Windows.Forms.ToolTip modifTT;
    }
}