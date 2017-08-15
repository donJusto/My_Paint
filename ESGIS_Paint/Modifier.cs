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

namespace ESGIS_Paint
{
    public partial class Modifier : Form
    {

        public Modifier()
        {
            InitializeComponent();

        }

        private void droitePB_Click(object sender, EventArgs e)
        {
            rotatePB.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            rotatePB.Refresh();
        }



        private void gauchePB_Click(object sender, EventArgs e)
        {
            rotatePB.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            rotatePB.Refresh();

        }



        private void mutePB_Click(object sender, EventArgs e)
        {
            menuF pagemenuF = new menuF();
            pagemenuF.Stop();
        }

        private void soundPB_Click(object sender, EventArgs e)
        {
            menuF pagemenuF = new menuF();
            pagemenuF.Play();

        }

        private void Modifier_Load(object sender, EventArgs e)
        {

        }

        private void openPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisis une image";
            ofd.Multiselect = false;
            ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string[] fichier = ofd.FileNames;
                int x = 10;
                int y = 10;
                foreach (string img in fichier)
                {
                    rotatePB.Image = Image.FromFile(img);
                    rotatePB.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SaveFileDialog safe = new SaveFileDialog();
            safe.Title = "Sélectionner un safeacement";
            safe.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            DialogResult dr1 = safe.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                rotatePB.Image.Save(safe.FileName);
            }
        }

        private void quitPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tu es sûr de vouloir déjà partir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}