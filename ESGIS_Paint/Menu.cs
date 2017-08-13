using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESGIS_Paint
{
    public partial class menuF : Form
    {
        public menuF()
        {
            InitializeComponent();
        }

        private void paintPN_Paint(object sender, PaintEventArgs e)
        {
        }

        private void menuF_Load(object sender, EventArgs e)
        {
            esgispaintLB1.Location = esgispaintLB2.Location = esgispaintLB3.Location = new Point(50, 30);
            esgispaintLB1.Font = esgispaintLB2.Font = esgispaintLB3.Font = new System.Drawing.Font("Microsoft Sans Serif",
                    24F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));
            //
            //giving different color to the middile label(label2)
            //
            this.esgispaintLB2.ForeColor = System.Drawing.Color.Blue;
        }

        private void accPB_Click(object sender, EventArgs e)
        {
            Esgis_Paint draw = new Esgis_Paint();
            draw.Show();
            this.Hide();
        }

        private void modifPB_Click(object sender, EventArgs e)
        {
            Modifier modif = new Modifier();
            modif.Show();
            this.Hide();
        }
    }
}
