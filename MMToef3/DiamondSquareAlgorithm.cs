using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMToef3 {
    public class DiamondSquareAlgorithm {
        //breedte van picturebox
        private int width;
        //hoogte van picturbox
        private int height;
        private double[] values;

        //half of width
        private int featuresize =128; //256


        double mijnrandomgetal;

        public double[] Values {
            get {
                return values;
            }
        }

    
        /// <summary>
        /// standaard constructor 
        /// </summary>
        public DiamondSquareAlgorithm() {
            this.width = 512;
            this.height = 512;
            this.values = new double[width * height];
        }

        /// <summary>
        /// niet standaard constructor
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public DiamondSquareAlgorithm(int width,int height) {
            this.width = width;
            this.height = height;
            this.values = new double[width * height];
            for (int y = 0; y < height; y += featuresize) { //featuresize = picturebox width / 2 ?
                for (int x = 0; x < width; x += featuresize) {
                    setSample(x, y, Frand());  //IMPORTANT: frand() is a random function that returns a value between -1 and 1.
                }
            }
            Console.WriteLine(Frand());
                
        }

        public double Frand() {
            Random random = new Random();
            return random.NextDouble() * 2 - 1;
        }

        /// <summary>
        /// dit algoritme zorgt er
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double sample(int x, int y) {
            return values[(x & (width - 1)) + (y & (height - 1)) * width];
        }

        public void setSample(int x, int y, double value) {
            values[(x & (width - 1)) + (y & (height - 1)) * width] = value;
        }

        public void sampleSquare(int x, int y, int size, double value) {
            int hs = size / 2;

            // a     b 
            //
            //    x
            //
            // c     d

            double a = sample(x - hs, y - hs);
            double b = sample(x + hs, y - hs);
            double c = sample(x - hs, y + hs);
            double d = sample(x + hs, y + hs);

            setSample(x, y, ((a + b + c + d) / 4.0) + value);

        }

        public void sampleDiamond(int x, int y, int size, double value) {
            int hs = size / 2;

            //   c
            //
            //a  x  b
            //
            //   d

            double a = sample(x - hs, y);
            double b = sample(x + hs, y);
            double c = sample(x, y - hs);
            double d = sample(x, y + hs);

            setSample(x, y, ((a + b + c + d) / 4.0) + value);
        }

        public void DiamondSquare(int stepsize, double scale) {

            int halfstep = stepsize / 2;

            for (int y = halfstep; y < height + halfstep; y += stepsize) {
                for (int x = halfstep; x < width + halfstep; x += stepsize) {
                    sampleSquare(x, y, stepsize, Frand() * scale);
                }
            }

            for (int y = 0; y < height; y += stepsize) {
                for (int x = 0; x < width; x += stepsize) {
                    sampleDiamond(x + halfstep, y, stepsize, Frand() * scale);
                    sampleDiamond(x, y + halfstep, stepsize, Frand() * scale);
                }
            }
        }

        public void ExecuteAlgorithm() {
            int samplesize = featuresize;

            double scale = 1.0;

            while (samplesize > 1) {

                DiamondSquare(samplesize, scale);

                samplesize /= 2;
                scale /= 2.0;
            }
        }


        
    }
}
