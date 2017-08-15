using ESGIS_Paint.Class_log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESGIS_Paint

{
    public partial class menuF : Form

    {
        Log log;

        SoundPlayer player = new SoundPlayer(@"sound.wav");
        string s = "ESGIS PAINT";
        string[] l;
        int i = 0, j = 0;
        public menuF()
        {
            InitializeComponent();
            log = new Log();
            log.connectionAction();

        }
        public void Play()
        {
            player.Play();
        }
        public void Stop()
        {
            player.Stop();
        }
        private void paintPN_Paint(object sender, PaintEventArgs e)
        {
        }

        private void menuF_Load(object sender, EventArgs e)
        {

            esgispaintLB1.Location = esgispaintLB2.Location = esgispaintLB3.Location = new Point(24, 214);
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

        private void animTM_Tick(object sender, EventArgs e)
        {
            //adding the characters one by one to the label2
            if (i < s.Length - 1)
                esgispaintLB2.Text += l[i].ToString();

            //starting the third label after 3 charaters of label2 adding
            if (i >= 3 && i <= 20)
            {
                if (i <= s.Length + 2)
                    esgispaintLB3.Text += l[j].ToString();
                j++;
            }
            if (j <= s.Length)
                i++;
            else
            {
                i = j = 0;
                esgispaintLB3.Text = esgispaintLB2.Text = "";
            }
        }

        private void mutePB_Click(object sender, EventArgs e)

        {
            Stop();

        }

        private void modifPB_Click(object sender, EventArgs e)
        {
            Modifier modif = new Modifier();
            this.Hide();
            modif.Show();

            }

        private void quitPB_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Tu es sûr de vouloir déjà partir?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                log.disconnectionAction();
                this.Dispose();

            }
        }

        private void logPB_Click(object sender, EventArgs e)
        {
            log.openFile();
        }

        private void soundPB_Click(object sender, EventArgs e)
        {
            Play();
        }
    }
}
