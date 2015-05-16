using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMToef3 {
    public partial class Form1 : Form {
        

        public Form1() {
            InitializeComponent();
            DiamondSquareAlgorithm diamondSquareAlgorithm = new DiamondSquareAlgorithm(pictureBox_fractaal.Width,pictureBox_fractaal.Height);
            diamondSquareAlgorithm.ExecuteAlgorithm();
            Bitmap bitmap = new Bitmap(pictureBox_fractaal.Width, pictureBox_fractaal.Height);
            double[] values = diamondSquareAlgorithm.Values;
            int i = 0;
            for (int y = 0; y < bitmap.Height; y++) {
                for (int x = 0; x < bitmap.Width; x++) {
                    int rgbvalue =  Convert.ToInt32(Math.Abs(values[i]) * 60);
                    Color c = Color.FromArgb(rgbvalue, rgbvalue, 30);
                    bitmap.SetPixel(y, x, c);
                    i++;

                }
            }
            pictureBox_fractaal.Image = bitmap;
        }




        private void comboBox_landschappen_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
