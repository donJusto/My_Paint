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
    public partial class Esgis_Paint : Form
    {
        public Esgis_Paint()
        {
            InitializeComponent();
            g = drawPN.CreateGraphics();
        }


        bool drawDebut = false;
        Graphics g;
        //nullable int for storing Null value
        int? initX = null;
        int? initY = null;
        bool dessCarre = false;
        bool dessRectangle = false;
        bool drawCercle = false;
        List<Point> draws = new List<Point>();
        Point pt = new Point();
        private void drawPN_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawDebut)
            {
                //Setting the Pen BackColor and line Width
                Pen p = new Pen(dessBT.BackColor, float.Parse(dessCB.Text));
                //Drawing the line.
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
                pt = e.Location;
                draws.Add(pt);

                //draws.add(pt);
            }
        }
        //Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void drawPN_MouseDown(object sender, MouseEventArgs e)
        {
            drawDebut = true;
            if (dessCarre)
            {
                //Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(dessBT.BackColor);
                //setting the width and height same for creating square.
                //Getting the width and Heigt value from Textbox(tabsizeTB)
                g.FillRectangle(sb, e.X, e.Y, int.Parse(tabsizeTB.Text), int.Parse(tabsizeTB.Text));
                //setting drawDebut and dessCarre value to false for creating one graphic on one click.
                drawDebut = false;
                dessCarre = false;
            }
            if (dessRectangle)
            {
                SolidBrush sb = new SolidBrush(dessBT.BackColor);
                //setting the width twice of the height
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(tabsizeTB.Text), int.Parse(tabsizeTB.Text));
                drawDebut = false;
                dessRectangle = false;
            }
            if (drawCercle)
            {
                SolidBrush sb = new SolidBrush(dessBT.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(tabsizeTB.Text), int.Parse(tabsizeTB.Text));
                drawDebut = false;
                drawCercle = false;
            }
            pt = e.Location;
            draws.Add(pt);
        }
        //Fired when the mouse pointer is over the drawPN and a mouse button is released.
        private void drawPN_MouseUp(object sender, MouseEventArgs e)
        {
            drawDebut = false;
            initX = null;
            initY = null;
            pt = e.Location;
            draws.Add(pt);

        }
        //Button for Setting pen Color
        private void dessBT_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of dessBT if user click on OK
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                dessBT.BackColor = c.Color;
            }
        }
        //New 
        private void neoBT_Click(object sender, EventArgs e)
        {
            //Clearing the graphics from the Panel(drawPN)
            g.Clear(drawPN.BackColor);
            //Setting the BackColor of drawPN and tabColBT to White on Clicking New under File Menu
            drawPN.BackColor = Color.White;
            tabColBT.BackColor = Color.White;
        }
        //Setting the Canvas Color
        private void tabcolorTB_Click(object sender, EventArgs e)

        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                drawPN.BackColor = c.Color;
                tabColBT.BackColor = c.Color;
            }
        }

        private void carreTB_Click(object sender, EventArgs e)
        {
            dessCarre = true;
        }

        private void rectangleBT_Click(object sender, EventArgs e)
        {
            dessRectangle = true;
        }

        private void cercleBT_Click(object sender, EventArgs e)
        {
            drawCercle = true;
        }
        //Exit under File Menu
        private void quitBT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //About under Help Menu
        //private void aboutMiniPaintToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    About a = new About();
        //    a.ShowDialog();
        //}


        private void saveBT_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(dessBT.BackColor, float.Parse(dessCB.Text));

            SaveFileDialog saveDialog = new SaveFileDialog();
            Bitmap bitm = new Bitmap(drawPN.Width, drawPN.Height);
            Graphics bitGraphics = Graphics.FromImage(bitm);

            saveDialog.Filter = "Image (*.JPG)|*.JPG";

            //Draw all point to Graphics
            //bitGraphics.DrawLines(p, draws.ToArray());

            //We name the image with words typed by the user
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                bitm.Save(saveDialog.FileName);
                //log.writeSaveAction(saveDialog.FileName);
                MessageBox.Show("Good Job ! \nSave Done!","SAUVEGARDE");
            }
        }
    }
}