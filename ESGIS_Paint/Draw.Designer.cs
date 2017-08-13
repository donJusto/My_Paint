namespace ESGIS_Paint
{
    partial class Esgis_Paint
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Esgis_Paint));
            this.drawPN = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.quitBT = new System.Windows.Forms.Button();
            this.cercleLB = new System.Windows.Forms.Label();
            this.carreLB = new System.Windows.Forms.Label();
            this.rectLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rectPB = new System.Windows.Forms.PictureBox();
            this.cerclePB = new System.Windows.Forms.PictureBox();
            this.carrePB = new System.Windows.Forms.PictureBox();
            this.aboutBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.neoBT = new System.Windows.Forms.Button();
            this.tabsizeTB = new System.Windows.Forms.TextBox();
            this.tabColBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dessBT = new System.Windows.Forms.Button();
            this.dessCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.arrPN = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerclePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrePB)).BeginInit();
            this.panel9.SuspendLayout();
            this.arrPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPN
            // 
            this.drawPN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawPN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawPN.Cursor = System.Windows.Forms.Cursors.Cross;
            this.drawPN.Location = new System.Drawing.Point(-2, 1);
            this.drawPN.Name = "drawPN";
            this.drawPN.Size = new System.Drawing.Size(575, 546);
            this.drawPN.TabIndex = 1;
            this.drawPN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPN_MouseDown);
            this.drawPN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPN_MouseMove);
            this.drawPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPN_MouseUp);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.quitBT);
            this.panel8.Controls.Add(this.cercleLB);
            this.panel8.Controls.Add(this.carreLB);
            this.panel8.Controls.Add(this.rectLB);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.rectPB);
            this.panel8.Controls.Add(this.cerclePB);
            this.panel8.Controls.Add(this.carrePB);
            this.panel8.Controls.Add(this.aboutBT);
            this.panel8.Controls.Add(this.saveBT);
            this.panel8.Controls.Add(this.neoBT);
            this.panel8.Controls.Add(this.tabsizeTB);
            this.panel8.Controls.Add(this.tabColBT);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.dessBT);
            this.panel8.Controls.Add(this.dessCB);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.arrPN);
            this.panel8.Location = new System.Drawing.Point(571, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(183, 546);
            this.panel8.TabIndex = 18;
            // 
            // quitBT
            // 
            this.quitBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBT.Location = new System.Drawing.Point(3, 516);
            this.quitBT.Name = "quitBT";
            this.quitBT.Size = new System.Drawing.Size(75, 23);
            this.quitBT.TabIndex = 24;
            this.quitBT.Text = "Quitter";
            this.quitBT.UseVisualStyleBackColor = true;
            this.quitBT.Click += new System.EventHandler(this.quitBT_Click);
            // 
            // cercleLB
            // 
            this.cercleLB.AutoSize = true;
            this.cercleLB.Location = new System.Drawing.Point(19, 431);
            this.cercleLB.Name = "cercleLB";
            this.cercleLB.Size = new System.Drawing.Size(37, 13);
            this.cercleLB.TabIndex = 23;
            this.cercleLB.Text = "Cercle";
            // 
            // carreLB
            // 
            this.carreLB.AutoSize = true;
            this.carreLB.Location = new System.Drawing.Point(19, 361);
            this.carreLB.Name = "carreLB";
            this.carreLB.Size = new System.Drawing.Size(32, 13);
            this.carreLB.TabIndex = 22;
            this.carreLB.Text = "Carré";
            // 
            // rectLB
            // 
            this.rectLB.AutoSize = true;
            this.rectLB.Location = new System.Drawing.Point(8, 286);
            this.rectLB.Name = "rectLB";
            this.rectLB.Size = new System.Drawing.Size(56, 13);
            this.rectLB.TabIndex = 21;
            this.rectLB.Text = "Rectangle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // rectPB
            // 
            this.rectPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectPB.Image = ((System.Drawing.Image)(resources.GetObject("rectPB.Image")));
            this.rectPB.Location = new System.Drawing.Point(11, 252);
            this.rectPB.Name = "rectPB";
            this.rectPB.Size = new System.Drawing.Size(49, 31);
            this.rectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rectPB.TabIndex = 17;
            this.rectPB.TabStop = false;
            this.rectPB.Click += new System.EventHandler(this.rectangleBT_Click);
            // 
            // cerclePB
            // 
            this.cerclePB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerclePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerclePB.Image = ((System.Drawing.Image)(resources.GetObject("cerclePB.Image")));
            this.cerclePB.Location = new System.Drawing.Point(6, 386);
            this.cerclePB.Name = "cerclePB";
            this.cerclePB.Size = new System.Drawing.Size(57, 42);
            this.cerclePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerclePB.TabIndex = 4;
            this.cerclePB.TabStop = false;
            this.cerclePB.Click += new System.EventHandler(this.cercleBT_Click);
            // 
            // carrePB
            // 
            this.carrePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carrePB.Image = ((System.Drawing.Image)(resources.GetObject("carrePB.Image")));
            this.carrePB.Location = new System.Drawing.Point(11, 307);
            this.carrePB.Name = "carrePB";
            this.carrePB.Size = new System.Drawing.Size(50, 51);
            this.carrePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carrePB.TabIndex = 5;
            this.carrePB.TabStop = false;
            this.carrePB.Click += new System.EventHandler(this.carreTB_Click);
            // 
            // aboutBT
            // 
            this.aboutBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBT.Location = new System.Drawing.Point(96, 516);
            this.aboutBT.Name = "aboutBT";
            this.aboutBT.Size = new System.Drawing.Size(75, 23);
            this.aboutBT.TabIndex = 16;
            this.aboutBT.Text = "A Propos";
            this.aboutBT.UseVisualStyleBackColor = true;
            // 
            // saveBT
            // 
            this.saveBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBT.Location = new System.Drawing.Point(36, 468);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(88, 23);
            this.saveBT.TabIndex = 15;
            this.saveBT.Text = "Sauver";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // neoBT
            // 
            this.neoBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.neoBT.Location = new System.Drawing.Point(83, 356);
            this.neoBT.Name = "neoBT";
            this.neoBT.Size = new System.Drawing.Size(88, 23);
            this.neoBT.TabIndex = 14;
            this.neoBT.Text = "Effacer";
            this.neoBT.UseVisualStyleBackColor = true;
            this.neoBT.Click += new System.EventHandler(this.neoBT_Click);
            // 
            // tabsizeTB
            // 
            this.tabsizeTB.Location = new System.Drawing.Point(81, 287);
            this.tabsizeTB.Name = "tabsizeTB";
            this.tabsizeTB.Size = new System.Drawing.Size(88, 20);
            this.tabsizeTB.TabIndex = 9;
            this.tabsizeTB.Text = "50";
            // 
            // tabColBT
            // 
            this.tabColBT.BackColor = System.Drawing.SystemColors.GrayText;
            this.tabColBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabColBT.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabColBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabColBT.Location = new System.Drawing.Point(81, 259);
            this.tabColBT.Name = "tabColBT";
            this.tabColBT.Size = new System.Drawing.Size(88, 24);
            this.tabColBT.TabIndex = 8;
            this.tabColBT.Text = "TableColor";
            this.tabColBT.UseVisualStyleBackColor = false;
            this.tabColBT.Click += new System.EventHandler(this.tabcolorTB_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("BoomBox", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "JE VEUX DESSINER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dessBT
            // 
            this.dessBT.BackColor = System.Drawing.SystemColors.GrayText;
            this.dessBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dessBT.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessBT.Location = new System.Drawing.Point(81, 38);
            this.dessBT.Name = "dessBT";
            this.dessBT.Size = new System.Drawing.Size(99, 24);
            this.dessBT.TabIndex = 6;
            this.dessBT.Text = "DessColor";
            this.dessBT.UseVisualStyleBackColor = false;
            this.dessBT.Click += new System.EventHandler(this.dessBT_Click);
            // 
            // dessCB
            // 
            this.dessCB.FormattingEnabled = true;
            this.dessCB.ItemHeight = 13;
            this.dessCB.Location = new System.Drawing.Point(81, 68);
            this.dessCB.Name = "dessCB";
            this.dessCB.Size = new System.Drawing.Size(95, 21);
            this.dessCB.TabIndex = 1;
            this.dessCB.Tag = "";
            this.dessCB.Text = "4";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("BoomBox", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESSINATEUR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(471, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(186, 501);
            this.panel9.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(471, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(178, 503);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(471, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(178, 503);
            this.panel11.TabIndex = 1;
            // 
            // arrPN
            // 
            this.arrPN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arrPN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arrPN.Controls.Add(this.panel1);
            this.arrPN.Location = new System.Drawing.Point(-2, 133);
            this.arrPN.Name = "arrPN";
            this.arrPN.Size = new System.Drawing.Size(183, 113);
            this.arrPN.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 113);
            this.panel1.TabIndex = 1;
            // 
            // Esgis_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 547);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.drawPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Esgis_Paint";
            this.Text = "ESGIS PAINT";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerclePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrePB)).EndInit();
            this.panel9.ResumeLayout(false);
            this.arrPN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPN;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox rectPB;
        private System.Windows.Forms.PictureBox cerclePB;
        private System.Windows.Forms.PictureBox carrePB;
        private System.Windows.Forms.Button aboutBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button neoBT;
        private System.Windows.Forms.TextBox tabsizeTB;
        private System.Windows.Forms.Button tabColBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dessBT;
        private System.Windows.Forms.ComboBox dessCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel arrPN;
        private System.Windows.Forms.Label carreLB;
        private System.Windows.Forms.Label rectLB;
        private System.Windows.Forms.Button quitBT;
        private System.Windows.Forms.Label cercleLB;
        private System.Windows.Forms.Panel panel1;
    }
}

