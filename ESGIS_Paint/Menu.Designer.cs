namespace ESGIS_Paint
{
    partial class menuF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuF));
            this.esgispaintLB1 = new System.Windows.Forms.Label();
            this.esgispaintLB2 = new System.Windows.Forms.Label();
            this.esgispaintLB3 = new System.Windows.Forms.Label();
            this.modifPB = new System.Windows.Forms.PictureBox();
            this.accdessPB = new System.Windows.Forms.PictureBox();
            this.animTM = new System.Windows.Forms.Timer(this.components);
            this.soundPB = new System.Windows.Forms.PictureBox();
            this.mutePB = new System.Windows.Forms.PictureBox();
            this.ouvrirTT = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.quitPB = new System.Windows.Forms.PictureBox();
            this.logPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modifPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accdessPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPB)).BeginInit();
            this.SuspendLayout();
            // 
            // esgispaintLB1
            // 
            this.esgispaintLB1.Font = new System.Drawing.Font("Myriad Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esgispaintLB1.Location = new System.Drawing.Point(48, 218);
            this.esgispaintLB1.Name = "esgispaintLB1";
            this.esgispaintLB1.Size = new System.Drawing.Size(389, 85);
            this.esgispaintLB1.TabIndex = 0;
            this.esgispaintLB1.Text = "ESGIS PAINT";
            // 
            // esgispaintLB2
            // 
            this.esgispaintLB2.Font = new System.Drawing.Font("Myriad Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esgispaintLB2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.esgispaintLB2.Location = new System.Drawing.Point(48, 218);
            this.esgispaintLB2.Name = "esgispaintLB2";
            this.esgispaintLB2.Size = new System.Drawing.Size(389, 85);
            this.esgispaintLB2.TabIndex = 1;
            this.esgispaintLB2.Text = "ESGIS PAINT";
            // 
            // esgispaintLB3
            // 
            this.esgispaintLB3.Font = new System.Drawing.Font("Myriad Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esgispaintLB3.Location = new System.Drawing.Point(63, 218);
            this.esgispaintLB3.Name = "esgispaintLB3";
            this.esgispaintLB3.Size = new System.Drawing.Size(423, 85);
            this.esgispaintLB3.TabIndex = 2;
            this.esgispaintLB3.Text = "ESGIS PAINT";
            // 
            // modifPB
            // 
            this.modifPB.Image = ((System.Drawing.Image)(resources.GetObject("modifPB.Image")));
            this.modifPB.Location = new System.Drawing.Point(24, 91);
            this.modifPB.Name = "modifPB";
            this.modifPB.Size = new System.Drawing.Size(98, 95);
            this.modifPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifPB.TabIndex = 3;
            this.modifPB.TabStop = false;
            this.ouvrirTT.SetToolTip(this.modifPB, "OUVRIR");
            this.modifPB.Click += new System.EventHandler(this.modifPB_Click);
            // 
            // accdessPB
            // 
            this.accdessPB.Image = ((System.Drawing.Image)(resources.GetObject("accdessPB.Image")));
            this.accdessPB.Location = new System.Drawing.Point(163, 92);
            this.accdessPB.Name = "accdessPB";
            this.accdessPB.Size = new System.Drawing.Size(80, 94);
            this.accdessPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accdessPB.TabIndex = 4;
            this.accdessPB.TabStop = false;
            this.ouvrirTT.SetToolTip(this.accdessPB, "DESSINER");
            this.accdessPB.Click += new System.EventHandler(this.accPB_Click);
            // 
            // soundPB
            // 
            this.soundPB.Image = ((System.Drawing.Image)(resources.GetObject("soundPB.Image")));
            this.soundPB.Location = new System.Drawing.Point(324, 306);
            this.soundPB.Name = "soundPB";
            this.soundPB.Size = new System.Drawing.Size(35, 31);
            this.soundPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soundPB.TabIndex = 7;
            this.soundPB.TabStop = false;
            this.soundPB.Click += new System.EventHandler(this.soundPB_Click);
            // 
            // mutePB
            // 
            this.mutePB.Image = ((System.Drawing.Image)(resources.GetObject("mutePB.Image")));
            this.mutePB.Location = new System.Drawing.Point(365, 306);
            this.mutePB.Name = "mutePB";
            this.mutePB.Size = new System.Drawing.Size(39, 31);
            this.mutePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mutePB.TabIndex = 8;
            this.mutePB.TabStop = false;
            this.mutePB.Click += new System.EventHandler(this.mutePB_Click);
            // 
            // ouvrirTT
            // 
            this.ouvrirTT.Tag = "Ouvrir";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Tag = "mon tag";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "titre";
            // 
            // quitPB
            // 
            this.quitPB.Image = ((System.Drawing.Image)(resources.GetObject("quitPB.Image")));
            this.quitPB.Location = new System.Drawing.Point(382, 91);
            this.quitPB.Name = "quitPB";
            this.quitPB.Size = new System.Drawing.Size(89, 94);
            this.quitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quitPB.TabIndex = 9;
            this.quitPB.TabStop = false;
            this.ouvrirTT.SetToolTip(this.quitPB, "QUITTER");
            this.quitPB.Click += new System.EventHandler(this.quitPB_Click);
            // 
            // logPB
            // 
            this.logPB.Image = ((System.Drawing.Image)(resources.GetObject("logPB.Image")));
            this.logPB.Location = new System.Drawing.Point(271, 91);
            this.logPB.Name = "logPB";
            this.logPB.Size = new System.Drawing.Size(79, 94);
            this.logPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logPB.TabIndex = 11;
            this.logPB.TabStop = false;
            this.ouvrirTT.SetToolTip(this.logPB, "JOURNAL");
            this.logPB.Click += new System.EventHandler(this.logPB_Click);
            // 
            // menuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 359);
            this.Controls.Add(this.logPB);
            this.Controls.Add(this.quitPB);
            this.Controls.Add(this.mutePB);
            this.Controls.Add(this.soundPB);
            this.Controls.Add(this.accdessPB);
            this.Controls.Add(this.modifPB);
            this.Controls.Add(this.esgispaintLB3);
            this.Controls.Add(this.esgispaintLB2);
            this.Controls.Add(this.esgispaintLB1);
            this.Name = "menuF";
            this.Text = "ACCUEIL";
            ((System.ComponentModel.ISupportInitialize)(this.modifPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accdessPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label esgispaintLB1;
        private System.Windows.Forms.Label esgispaintLB2;
        private System.Windows.Forms.Label esgispaintLB3;
        private System.Windows.Forms.PictureBox modifPB;
        private System.Windows.Forms.PictureBox accdessPB;
        private System.Windows.Forms.Timer animTM;
        private System.Windows.Forms.PictureBox soundPB;
        private System.Windows.Forms.PictureBox mutePB;
        private System.Windows.Forms.ToolTip ouvrirTT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox quitPB;
        private System.Windows.Forms.PictureBox logPB;
    }
}