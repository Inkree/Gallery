using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Picture : Form
    {
        public int counter = 0;
        List<string> image = new List<string>();
        public Picture(List<string> img)
        {
            InitializeComponent();
             image = img;
            pictureBox1.Image = Image.FromFile(image[0]);
        }

        private void buttonForwardImg_Click(object sender, EventArgs e)
        {
            if(counter +1 < image.Count)
            counter++;
            pictureBox1.Image = Image.FromFile(image[counter]);
        }
    }
}
