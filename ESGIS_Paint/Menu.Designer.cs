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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuF));
            this.esgispaintLB1 = new System.Windows.Forms.Label();
            this.esgispaintLB2 = new System.Windows.Forms.Label();
            this.esgispaintLB3 = new System.Windows.Forms.Label();
            this.modifPB = new System.Windows.Forms.PictureBox();
            this.accdessPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accdessPB)).BeginInit();
            this.SuspendLayout();
            // 
            // esgispaintLB1
            // 
            this.esgispaintLB1.Font = new System.Drawing.Font("Myriad Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esgispaintLB1.Location = new System.Drawing.Point(24, 214);
            this.esgispaintLB1.Name = "esgispaintLB1";
            this.esgispaintLB1.Size = new System.Drawing.Size(389, 85);
            this.esgispaintLB1.TabIndex = 0;
            this.esgispaintLB1.Text = "ESGIS PAINT";
            // 
            // esgispaintLB2
            // 
            this.esgispaintLB2.Font = new System.Drawing.Font("Myriad Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esgispaintLB2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.esgispaintLB2.Location = new System.Drawing.Point(24, 214);
            this.esgispaintLB2.Name = "esgispaintLB2";
            this.esgispaintLB2.Size = new System.Drawing.Size(389, 85);
            this.esgispaintLB2.TabIndex = 1;
            this.esgispaintLB2.Text = "ESGIS PAINT";
            // 
            // esgispaintLB3
            // 
            this.esgispaintLB3.Font = new System.Drawing.Font("Myriad Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esgispaintLB3.Location = new System.Drawing.Point(24, 214);
            this.esgispaintLB3.Name = "esgispaintLB3";
            this.esgispaintLB3.Size = new System.Drawing.Size(389, 85);
            this.esgispaintLB3.TabIndex = 2;
            this.esgispaintLB3.Text = "ESGIS PAINT";
            // 
            // modifPB
            // 
            this.modifPB.Image = ((System.Drawing.Image)(resources.GetObject("modifPB.Image")));
            this.modifPB.Location = new System.Drawing.Point(38, 55);
            this.modifPB.Name = "modifPB";
            this.modifPB.Size = new System.Drawing.Size(98, 87);
            this.modifPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifPB.TabIndex = 3;
            this.modifPB.TabStop = false;
            this.modifPB.Click += new System.EventHandler(this.modifPB_Click);
            // 
            // accdessPB
            // 
            this.accdessPB.Image = ((System.Drawing.Image)(resources.GetObject("accdessPB.Image")));
            this.accdessPB.Location = new System.Drawing.Point(265, 55);
            this.accdessPB.Name = "accdessPB";
            this.accdessPB.Size = new System.Drawing.Size(80, 94);
            this.accdessPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accdessPB.TabIndex = 4;
            this.accdessPB.TabStop = false;
            this.accdessPB.Click += new System.EventHandler(this.accPB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "OUVRIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESSINER";
            // 
            // menuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accdessPB);
            this.Controls.Add(this.modifPB);
            this.Controls.Add(this.esgispaintLB3);
            this.Controls.Add(this.esgispaintLB2);
            this.Controls.Add(this.esgispaintLB1);
            this.Name = "menuF";
            this.Text = "ACCUEIL";
            this.Load += new System.EventHandler(this.menuF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modifPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accdessPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label esgispaintLB1;
        private System.Windows.Forms.Label esgispaintLB2;
        private System.Windows.Forms.Label esgispaintLB3;
        private System.Windows.Forms.PictureBox modifPB;
        private System.Windows.Forms.PictureBox accdessPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}