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
        Image pictureObj;
        FileStream picture_stream;
        FileInfo img;
        Journal log;

        public Modifier()
        {
            InitializeComponent();
            log = new Journal();

        }

    }
}
