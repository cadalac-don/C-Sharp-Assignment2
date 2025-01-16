using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace M01_First_WPF_Proj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 3 slashes creates the comment header
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Draw a line on the canvas, using the supplied points.
        /// </summary>
        /// <param name="xLoc1">X1</param>
        /// <param name="yLoc1">Y1</param>
        /// <param name="xLoc2">X2</param>
        /// <param name="yLoc2">Y2</param>
        


        public void MyLineMethod(int xLoc1, int yLoc1, int xLoc2, int yLoc2)
        {
            // Add line to Grid
            Line myLine = new Line();
            myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            myLine.X1 = xLoc1;
            myLine.Y1 = yLoc1;
            myLine.X2 = xLoc2 + 50;
            myLine.Y2 = yLoc2 + 50;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            myCanvas.Children.Add(myLine);
            //myGrid.Children.Add(myLine);

        }

        /// <summary>
        /// Random Number generator for line positions.
        /// </summary>
        Random random = new Random();

        /// <summary>
        /// Event Handler for button.  Not renamed, so lots of work to 
        /// name it properly now (but not impossible).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int rx1 = random.Next(10, 200);
            int ry1 = random.Next(10, 200);
            int rx2 = random.Next(10, 200);
            int ry2 = random.Next(10, 200);
            MyLineMethod(rx1, ry1, rx2, ry2);
        }

        BitmapImage imgHair1 = new BitmapImage(new Uri("../../../images/hair1.png", UriKind.Relative));
        BitmapImage imgHair2 = new BitmapImage(new Uri("../../../images/hair2.png", UriKind.Relative));
        BitmapImage imgEyes1 = new BitmapImage(new Uri("../../../images/eyes1.png", UriKind.Relative));
        BitmapImage imgEyes2 = new BitmapImage(new Uri("../../../images/eyes2.png", UriKind.Relative));
        BitmapImage imgNose1 = new BitmapImage(new Uri("../../../images/nose1.png", UriKind.Relative));
        BitmapImage imgNose2 = new BitmapImage(new Uri("../../../images/nose2.png", UriKind.Relative));
        BitmapImage imgMouth1 = new BitmapImage(new Uri("../../../images/mouth1.png", UriKind.Relative));
        BitmapImage imgMouth2 = new BitmapImage(new Uri("../../../images/mouth2.png", UriKind.Relative));

        private void hairOne_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Hair1 = new Image();
            Hair1.Source = imgHair1;
            Hair1.Width = imgHair1.Width;
            Hair1.Height = imgHair1.Height;

            Canvas.SetLeft(Hair1, 50);
            Canvas.SetTop(Hair1, 50);
            myCanvas.Children.Add(Hair1);
        }

        private void hairTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Hair2 = new Image();
            Hair2.Source = imgHair2;
            Hair2.Width = imgHair2.Width;
            Hair2.Height = imgHair2.Height;

            Canvas.SetLeft(Hair2, 50);
            Canvas.SetTop(Hair2, 50);
            myCanvas.Children.Add(Hair2);
        }

        private void eyesOne_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Eyes1 = new Image();
            Eyes1.Source = imgEyes1;
            Eyes1.Width = imgEyes1.Width;
            Eyes1.Height = imgEyes1.Height;

            Canvas.SetLeft(Eyes1, 50);
            Canvas.SetTop(Eyes1, 250);
            myCanvas.Children.Add(Eyes1);
        }

        private void eyesTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Eyes2 = new Image();
            Eyes2.Source = imgEyes2;
            Eyes2.Width = imgEyes2.Width;
            Eyes2.Height = imgEyes2.Height;

            Canvas.SetLeft(Eyes2, 50);
            Canvas.SetTop(Eyes2, 250);
            myCanvas.Children.Add(Eyes2);
        }

        private void noseOne_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Nose1 = new Image();
            Nose1.Source = imgNose1;
            Nose1.Width = imgNose1.Width;
            Nose1.Height = imgNose1.Height;

            Canvas.SetLeft(Nose1, 50);
            Canvas.SetTop(Nose1, 450);
            myCanvas.Children.Add(Nose1);
        }

        private void noseTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Nose2 = new Image();
            Nose2.Source = imgNose2;
            Nose2.Width = imgNose2.Width;
            Nose2.Height = imgNose2.Height;

            Canvas.SetLeft(Nose2, 50);
            Canvas.SetTop(Nose2, 450);
            myCanvas.Children.Add(Nose2);
        }

        private void mouthOne_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Mouth1 = new Image();
            Mouth1.Source = imgMouth1;
            Mouth1.Width = imgMouth1.Width;
            Mouth1.Height = imgMouth1.Height;

            Canvas.SetLeft(Mouth1, 50);
            Canvas.SetTop(Mouth1, 650);
            myCanvas.Children.Add(Mouth1);
        }


        private void mouthTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            Image Mouth2 = new Image();
            Mouth2.Source = imgMouth2;
            Mouth2.Width = imgMouth2.Width;
            Mouth2.Height = imgMouth2.Height;

            Canvas.SetLeft(Mouth2, 50);
            Canvas.SetTop(Mouth2, 650);
            myCanvas.Children.Add(Mouth2);
        }

        private void randomFace_Button_Click(object sender, RoutedEventArgs e) {

            int rx1 = random.Next(1, 200);
            int ry1 = random.Next(1, 200);
            int rx2 = random.Next(1, 200);
            int ry2 = random.Next(1, 200);

            Image Hair1 = new Image();
            Hair1.Source = imgHair1;
            Hair1.Width = imgHair1.Width;
            Hair1.Height = imgHair1.Height;

            Image Hair2 = new Image();
            Hair2.Source = imgHair2;
            Hair2.Width = imgHair2.Width;
            Hair2.Height = imgHair2.Height;

            if (ry1 % 2 == 0)
            {
                Canvas.SetLeft(Hair1, 50);
                Canvas.SetTop(Hair1, 50);
                myCanvas.Children.Add(Hair1);
            }
            else
            {
                Canvas.SetLeft(Hair2, 50);
                Canvas.SetTop(Hair2, 50);
                myCanvas.Children.Add(Hair2);
            }

            Image Eyes1 = new Image();
            Eyes1.Source = imgEyes1;
            Eyes1.Width = imgEyes1.Width;
            Eyes1.Height = imgEyes1.Height;

            Image Eyes2 = new Image();
            Eyes2.Source = imgEyes2;
            Eyes2.Width = imgEyes2.Width;
            Eyes2.Height = imgEyes2.Height;

            if (ry1 % 2 == 0)
            {
                Canvas.SetLeft(Eyes1, 50);
                Canvas.SetTop(Eyes1, 250);
                myCanvas.Children.Add(Eyes1);
            }
            else { 
                Canvas.SetLeft(Eyes2, 50);
                Canvas.SetTop(Eyes2, 250);
                myCanvas.Children.Add(Eyes2);
                }


            Image Nose1 = new Image();
            Nose1.Source = imgNose1;
            Nose1.Width = imgNose1.Width;
            Nose1.Height = imgNose1.Height;

            Image Nose2 = new Image();
            Nose2.Source = imgNose2;
            Nose2.Width = imgNose2.Width;
            Nose2.Height = imgNose2.Height;

            if (rx2 % 2 == 0)
            {
                Canvas.SetLeft(Nose1, 50);
                Canvas.SetTop(Nose1, 450);
                myCanvas.Children.Add(Nose1);
            }
            else
            {
                Canvas.SetLeft(Nose2, 50);
                Canvas.SetTop(Nose2, 450);
                myCanvas.Children.Add(Nose2);
            }

            Image Mouth2 = new Image();
            Mouth2.Source = imgMouth2;
            Mouth2.Width = imgMouth2.Width;
            Mouth2.Height = imgMouth2.Height;

            Image Mouth1 = new Image();
            Mouth1.Source = imgMouth1;
            Mouth1.Width = imgMouth1.Width;
            Mouth1.Height = imgMouth1.Height;

            if (ry2 % 2 == 0)
            {
                Canvas.SetLeft(Mouth1, 50);
                Canvas.SetTop(Mouth1, 650);
                myCanvas.Children.Add(Mouth1);
            }
            else
            {
                Canvas.SetLeft(Mouth2, 50);
                Canvas.SetTop(Mouth2, 650);
                myCanvas.Children.Add(Mouth2);
            }
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            int rx1 = random.Next(10, 200);
            int ry1 = random.Next(10, 200);
            int rx2 = random.Next(10, 200);
            int ry2 = random.Next(10, 200);
            MyLineMethod(rx1, ry1, rx2, ry2);
        }

        public void MyImageMethod(int xLoc1, int yLoc1)
        {
            Image Hair1 = new Image();
            Hair1.Source = imgHair1;
            Hair1.Width = imgHair1.Width;
            Hair1.Height = imgHair1.Height;

            Canvas.SetLeft(Hair1, 50);
            Canvas.SetTop(Hair1, 50);
            myCanvas.Children.Add(Hair1);

            Image Eyes1 = new Image();
            Eyes1.Source = imgEyes1;
            Eyes1.Width = imgEyes1.Width;
            Eyes1.Height = imgEyes1.Height;

            Canvas.SetLeft(Eyes1, 50);
            Canvas.SetTop(Eyes1, 250);
            myCanvas.Children.Add(Eyes1);

            Image Nose1 = new Image();
            Nose1.Source = imgNose1;
            Nose1.Width = imgNose1.Width;
            Nose1.Height = imgNose1.Height;

            Canvas.SetLeft(Nose1, 50);
            Canvas.SetTop(Nose1, 450);
            myCanvas.Children.Add(Nose1);

            Image Mouth1 = new Image();
            Mouth1.Source = imgMouth1;
            Mouth1.Width = imgMouth1.Width;
            Mouth1.Height = imgMouth1.Height;

            Canvas.SetLeft(Mouth1, 50);
            Canvas.SetTop(Mouth1, 650);
            myCanvas.Children.Add(Mouth1);
        }

        /// <summary>
        /// Button to add the image, which happens to be a face
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Face_Click(object sender, RoutedEventArgs e)
        {
            int rx1 = random.Next(10, 200);
            int ry1 = random.Next(10, 200);
            MyImageMethod(rx1, ry1);

        }

        private void buttonTest_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button was pressed...");
        }

        private void comboTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(comboTest.SelectedItem.ToString());
            Console.WriteLine("Combo=" + comboTest.SelectedItem.ToString());
        }

        private void sliderTest_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(sliderTest.Value.ToString());
            Console.WriteLine("Slider=" + sliderTest.Value.ToString());
            Console.WriteLine("Slider e=" + e.ToString());

        }

        private void combo_02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
