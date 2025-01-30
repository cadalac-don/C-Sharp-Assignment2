using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

    public partial class MainWindow : Window
    {

        // Create handlers for each function, these called from hotkey/menu/button
        private CommandHandler cmdNewFace1;
        private CommandHandler cmdNewFace2;
        private CommandHandler cmdNewFace3;
        private CommandHandler cmdNewFace4;
        private CommandHandler cmdNewFace5;
        private CommandHandler cmdNewFace6;
        private CommandHandler cmdNewFace7;
        private CommandHandler cmdNewFace8;
        private CommandHandler cmdNewFace9;
        private CommandHandler cmdNewFace10;
        private CommandHandler cmdNewFace11;
        private CommandHandler cmdNewFace12;
        private CommandHandler cmdNewFace13;
        private CommandHandler cmdNewFace14;
        private CommandHandler cmdNewFace15;
        private CommandHandler cmdNewFace16;
        private CommandHandler cmdNewFace17;
        private CommandHandler cmdNewFace18;
        private CommandHandler cmdNewFace19;

        public MainWindow()
        {
            InitializeComponent();

            hairOne();
            noseTwo();
            mouthThree();

            cmdNewFace1 = new CommandHandler(() => hairOne(), true);
            cmdNewFace2 = new CommandHandler(() => hairTwo(), true);
            cmdNewFace3 = new CommandHandler(() => hairThree(), true);
            cmdNewFace4 = new CommandHandler(() => hairFour(), true);

            cmdNewFace5 = new CommandHandler(() => eyesOne(), true);
            cmdNewFace6 = new CommandHandler(() => eyesTwo(), true);
            cmdNewFace7 = new CommandHandler(() => eyesThree(), true);
            cmdNewFace8 = new CommandHandler(() => eyesFour(), true);

            cmdNewFace9 = new CommandHandler(() => noseOne(), true);
            cmdNewFace10 = new CommandHandler(() => noseTwo(), true);
            cmdNewFace11 = new CommandHandler(() => noseThree(), true);
            cmdNewFace12 = new CommandHandler(() => noseFour(), true);

            cmdNewFace13 = new CommandHandler(() => mouthOne(), true);
            cmdNewFace14 = new CommandHandler(() => mouthTwo(), true);
            cmdNewFace15 = new CommandHandler(() => mouthThree(), true);
            cmdNewFace16 = new CommandHandler(() => mouthFour(), true);

            cmdNewFace17 = new CommandHandler(() => randomFace(), true);
            cmdNewFace18 = new CommandHandler(() => MyImageMethod(), true);
            cmdNewFace19 = new CommandHandler(() => helpMe(), true);

            // Create scope to commands from XAML
            // find "newFaceCMD1" in the XAML
            // find cmdNewFace1 in the code
            DataContext = new
            {
                newFaceCMD1 = cmdNewFace1,
                newFaceCMD2 = cmdNewFace2,
                newFaceCMD3 = cmdNewFace3,
                newFaceCMD4 = cmdNewFace4,
                newFaceCMD5 = cmdNewFace5,
                newFaceCMD6 = cmdNewFace6,
                newFaceCMD7 = cmdNewFace7,
                newFaceCMD8 = cmdNewFace8,
                newFaceCMD9 = cmdNewFace9,
                newFaceCMD10 = cmdNewFace10,
                newFaceCMD11 = cmdNewFace11,
                newFaceCMD12 = cmdNewFace12,
                newFaceCMD13 = cmdNewFace13,
                newFaceCMD14 = cmdNewFace14,
                newFaceCMD15 = cmdNewFace15,
                newFaceCMD16 = cmdNewFace16,
                newFaceCMD17 = cmdNewFace17,
                newFaceCMD18 = cmdNewFace18,
                newFaceCMD19 = cmdNewFace19,
            };

            // Key Bindings
            InputBindings.Add(new KeyBinding(cmdNewFace1, new KeyGesture(Key.F1, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace2, new KeyGesture(Key.F2, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace3, new KeyGesture(Key.F3, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace4, new KeyGesture(Key.F4, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace5, new KeyGesture(Key.F5, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace6, new KeyGesture(Key.F6, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace7, new KeyGesture(Key.F7, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace8, new KeyGesture(Key.F8, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace9, new KeyGesture(Key.F9, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace10, new KeyGesture(Key.F10, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace11, new KeyGesture(Key.F11, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace12, new KeyGesture(Key.F12, ModifierKeys.None)));
            InputBindings.Add(new KeyBinding(cmdNewFace13, new KeyGesture(Key.A, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(cmdNewFace14, new KeyGesture(Key.B, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(cmdNewFace15, new KeyGesture(Key.C, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(cmdNewFace16, new KeyGesture(Key.D, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(cmdNewFace17, new KeyGesture(Key.R, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(cmdNewFace18, new KeyGesture(Key.N, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(cmdNewFace19, new KeyGesture(Key.H, ModifierKeys.Control)));
        }

        /// <summary>
        /// Draw a line on the canvas, using the supplied points.
        /// </summary>
        /// <param name="xLoc1">X1</param>
        /// <param name="yLoc1">Y1</param>
        /// <param name="xLoc2">X2</param>
        /// <param name="yLoc2">Y2</param>

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
        /// 
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
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int rx1 = random.Next(10, 200);
            int ry1 = random.Next(10, 200);
            int rx2 = random.Next(10, 200);
            int ry2 = random.Next(10, 200);
            MyLineMethod(rx1, ry1, rx2, ry2);
        }
        private void help_Button_Click(object sender, RoutedEventArgs e) {

            helpMe();
        }
        private void helpMe() {
            System.Windows.MessageBox.Show("Help is here...");
            string filePath = @"..\..\HelpNDoc tutorial.chm";
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        BitmapImage imgHair1 = new BitmapImage(new Uri("../../../images/hair1.png", UriKind.Relative));
        BitmapImage imgHair2 = new BitmapImage(new Uri("../../../images/hair2.png", UriKind.Relative));
        BitmapImage imgHair3 = new BitmapImage(new Uri("../../../images/hair3.png", UriKind.Relative));
        BitmapImage imgHair4 = new BitmapImage(new Uri("../../../images/hair4.png", UriKind.Relative));

        BitmapImage imgEyes1 = new BitmapImage(new Uri("../../../images/eyes1.png", UriKind.Relative));
        BitmapImage imgEyes2 = new BitmapImage(new Uri("../../../images/eyes2.png", UriKind.Relative));
        BitmapImage imgEyes3 = new BitmapImage(new Uri("../../../images/eyes3.png", UriKind.Relative));
        BitmapImage imgEyes4 = new BitmapImage(new Uri("../../../images/eyes4.png", UriKind.Relative));

        BitmapImage imgNose1 = new BitmapImage(new Uri("../../../images/nose1.png", UriKind.Relative));
        BitmapImage imgNose2 = new BitmapImage(new Uri("../../../images/nose2.png", UriKind.Relative));
        BitmapImage imgNose3 = new BitmapImage(new Uri("../../../images/nose3.png", UriKind.Relative));
        BitmapImage imgNose4 = new BitmapImage(new Uri("../../../images/nose4.png", UriKind.Relative));

        BitmapImage imgMouth1 = new BitmapImage(new Uri("../../../images/mouth1.png", UriKind.Relative));
        BitmapImage imgMouth2 = new BitmapImage(new Uri("../../../images/mouth2.png", UriKind.Relative));
        BitmapImage imgMouth3 = new BitmapImage(new Uri("../../../images/mouth3.png", UriKind.Relative));
        BitmapImage imgMouth4 = new BitmapImage(new Uri("../../../images/mouth4.png", UriKind.Relative));

        private void hairOne() { 
            Image Hair1 = new Image();
            Hair1.Source = imgHair1;
            Hair1.Width = imgHair1.Width;
            Hair1.Height = imgHair1.Height;

            Canvas.SetLeft(Hair1, 50);
            Canvas.SetTop(Hair1, 50);
            myCanvas.Children.Add(Hair1);

            System.Windows.MessageBox.Show("Hair 1");
        }

        private void hairTwo() {
            Image Hair2 = new Image();
            Hair2.Source = imgHair2;
            Hair2.Width = imgHair2.Width;
            Hair2.Height = imgHair2.Height;

            Canvas.SetLeft(Hair2, 50);
            Canvas.SetTop(Hair2, 50);
            myCanvas.Children.Add(Hair2);
            System.Windows.MessageBox.Show("Hair 2");
        }

        private void hairThree() {
            Image Hair3 = new Image();
            Hair3.Source = imgHair3;
            Hair3.Width = imgHair3.Width;
            Hair3.Height = imgHair3.Height;

            Canvas.SetLeft(Hair3, 50);
            Canvas.SetTop(Hair3, 50);
            myCanvas.Children.Add(Hair3);
            System.Windows.MessageBox.Show("Hair 3");
        }
        private void hairFour() {
            Image Hair4 = new Image();
            Hair4.Source = imgHair4;
            Hair4.Width = imgHair4.Width;
            Hair4.Height = imgHair4.Height;

            Canvas.SetLeft(Hair4, 50);
            Canvas.SetTop(Hair4, 50);
            myCanvas.Children.Add(Hair4);
            System.Windows.MessageBox.Show("Hair 4");
        }

        private void eyesOne() {
            Image Eyes1 = new Image();
            Eyes1.Source = imgEyes1;
            Eyes1.Width = imgEyes1.Width;
            Eyes1.Height = imgEyes1.Height;

            Canvas.SetLeft(Eyes1, 50);
            Canvas.SetTop(Eyes1, 250);
            myCanvas.Children.Add(Eyes1);
            System.Windows.MessageBox.Show("Eye 1");
        }
        private void eyesTwo() {
            Image Eyes2 = new Image();
            Eyes2.Source = imgEyes2;
            Eyes2.Width = imgEyes2.Width;
            Eyes2.Height = imgEyes2.Height;

            Canvas.SetLeft(Eyes2, 50);
            Canvas.SetTop(Eyes2, 250);
            myCanvas.Children.Add(Eyes2);
            System.Windows.MessageBox.Show("Eye 2");
        }
        private void eyesThree() {
            Image Eyes3 = new Image();
            Eyes3.Source = imgEyes3;
            Eyes3.Width = imgEyes3.Width;
            Eyes3.Height = imgEyes3.Height;

            Canvas.SetLeft(Eyes3, 50);
            Canvas.SetTop(Eyes3, 250);
            myCanvas.Children.Add(Eyes3);
            System.Windows.MessageBox.Show("Eye 3");
        }
        private void eyesFour() {
            Image Eyes4 = new Image();
            Eyes4.Source = imgEyes4;
            Eyes4.Width = imgEyes4.Width;
            Eyes4.Height = imgEyes4.Height;

            Canvas.SetLeft(Eyes4, 50);
            Canvas.SetTop(Eyes4, 250);
            myCanvas.Children.Add(Eyes4);
            System.Windows.MessageBox.Show("Eye 4");
        }

        private void noseOne() {
            Image Nose1 = new Image();
            Nose1.Source = imgNose1;
            Nose1.Width = imgNose1.Width;
            Nose1.Height = imgNose1.Height;

            Canvas.SetLeft(Nose1, 50);
            Canvas.SetTop(Nose1, 450);
            myCanvas.Children.Add(Nose1);
            System.Windows.MessageBox.Show("Nose 1");
        }
        private void noseTwo() {
            Image Nose2 = new Image();
            Nose2.Source = imgNose2;
            Nose2.Width = imgNose2.Width;
            Nose2.Height = imgNose2.Height;

            Canvas.SetLeft(Nose2, 50);
            Canvas.SetTop(Nose2, 450);
            myCanvas.Children.Add(Nose2);
            System.Windows.MessageBox.Show("Nose 2");
        }
        private void noseThree() {
            Image Nose3 = new Image();
            Nose3.Source = imgNose3;
            Nose3.Width = imgNose3.Width;
            Nose3.Height = imgNose3.Height;

            Canvas.SetLeft(Nose3, 50);
            Canvas.SetTop(Nose3, 450);
            myCanvas.Children.Add(Nose3);
            System.Windows.MessageBox.Show("Nose 3");
        }
        private void noseFour() {
            Image Nose4 = new Image();
            Nose4.Source = imgNose4;
            Nose4.Width = imgNose4.Width;
            Nose4.Height = imgNose4.Height;

            Canvas.SetLeft(Nose4, 50);
            Canvas.SetTop(Nose4, 450);
            myCanvas.Children.Add(Nose4);
            System.Windows.MessageBox.Show("Nose 4");
        }

        private void mouthOne() {
            Image Mouth1 = new Image();
            Mouth1.Source = imgMouth1;
            Mouth1.Width = imgMouth1.Width;
            Mouth1.Height = imgMouth1.Height;

            Canvas.SetLeft(Mouth1, 50);
            Canvas.SetTop(Mouth1, 650);
            myCanvas.Children.Add(Mouth1);

            System.Windows.MessageBox.Show("Mouth 1");
        }
        private void mouthTwo() {
            Image Mouth2 = new Image();
            Mouth2.Source = imgMouth2;
            Mouth2.Width = imgMouth2.Width;
            Mouth2.Height = imgMouth2.Height;

            Canvas.SetLeft(Mouth2, 50);
            Canvas.SetTop(Mouth2, 650);
            myCanvas.Children.Add(Mouth2);
            System.Windows.MessageBox.Show("Mouth 2");
        }
        private void mouthThree() {
            Image Mouth3 = new Image();
            Mouth3.Source = imgMouth3;
            Mouth3.Width = imgMouth3.Width;
            Mouth3.Height = imgMouth3.Height;

            Canvas.SetLeft(Mouth3, 50);
            Canvas.SetTop(Mouth3, 650);
            myCanvas.Children.Add(Mouth3);
            System.Windows.MessageBox.Show("Mouth 3");
        }
        private void mouthFour() {
            Image Mouth4 = new Image();
            Mouth4.Source = imgMouth4;
            Mouth4.Width = imgMouth4.Width;
            Mouth4.Height = imgMouth4.Height;

            Canvas.SetLeft(Mouth4, 50);
            Canvas.SetTop(Mouth4, 650);
            myCanvas.Children.Add(Mouth4);
            System.Windows.MessageBox.Show("Mouth 4");
        }
        private void randomFace() {

            int rx1 = random.Next(1, 200);
            int ry1 = random.Next(1, 200);
            int rx2 = random.Next(1, 200);
            int ry2 = random.Next(1, 200);

            //Hair
            if (ry1 % 4 == 0)
                hairOne();

            else if (ry1 % 4 == 1)
                hairTwo();

            else if (ry1 % 4 == 2)
                hairThree();

            else
                hairFour();

            //eyes
            if (ry1 % 4 == 0)
                eyesOne();

            else if (ry1 % 4 == 1)
                eyesTwo();

            else if (ry1 % 4 == 2)
                eyesThree();
            else
                eyesFour();

            //Nose
            if (rx2 % 4 == 0)
                noseOne();

            else if (rx2 % 4 == 1)
                noseTwo();

            else if (rx2 % 4 == 2)
                noseThree();

            else
                noseFour();

            //Mouth
            if (ry2 % 4 == 0)
                mouthOne();

            else if (ry2 % 4 == 1)
                mouthTwo();

            else if (ry2 % 4 == 2)
                mouthThree();

            else
                mouthFour();

            System.Windows.MessageBox.Show("Random Face Selection");

        }
        private void hairOne_Button_Click(object sender, RoutedEventArgs e)
        {
            hairOne();
        }

        private void hairTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            hairTwo();
        }

        private void hairThree_Button_Click(object sender, RoutedEventArgs e)
        {
            hairTwo();
        }

        private void hairFour_Button_Click(object sender, RoutedEventArgs e)
        {
            hairTwo();
        }
        private void eyesOne_Button_Click(object sender, RoutedEventArgs e)
        {
            eyesOne();
        }

        private void eyesTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            eyesTwo();
        }
        private void eyesThree_Button_Click(object sender, RoutedEventArgs e)
        {
            eyesThree();
        }
        private void eyesFour_Button_Click(object sender, RoutedEventArgs e)
        {
            eyesFour();
        }

        private void noseOne_Button_Click(object sender, RoutedEventArgs e)
        {
            noseOne();
        }

        private void noseTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            noseTwo();
        }

        private void noseThree_Button_Click(object sender, RoutedEventArgs e)
        {
            noseThree();
        }

        private void noseFour_Button_Click(object sender, RoutedEventArgs e)
        {
            noseFour();
        }

        private void mouthOne_Button_Click(object sender, RoutedEventArgs e)
        {
            mouthOne();
        }

        private void mouthTwo_Button_Click(object sender, RoutedEventArgs e)
        {
            mouthTwo();
        }
        private void mouthThree_Button_Click(object sender, RoutedEventArgs e)
        {
            mouthThree();
        }
        private void mouthFour_Button_Click(object sender, RoutedEventArgs e)
        {
            mouthFour();
        }


        private void randomFace_Button_Click(object sender, RoutedEventArgs e) {
            randomFace();
        }

        private void checkBoxHairOne_Checked(object sender, RoutedEventArgs e)
        {
            hairOne();
        }

        private void checkBoxHairTwo_Checked(object sender, RoutedEventArgs e)
        {
            hairTwo();
        }

        private void checkBoxHairThree_Checked(object sender, RoutedEventArgs e)
        {
            hairThree();
        }

        private void checkBoxHairFour_Checked(object sender, RoutedEventArgs e)
        {
            hairFour();
        }

        public void MyImageMethod()
        {
            hairOne();
            eyesOne();
            noseOne();
            mouthOne();
            System.Windows.MessageBox.Show("Default");
        }

        private void Add_Face_Click(object sender, RoutedEventArgs e)
        {
            MyImageMethod();

        }


        private void comboTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(comboTest.SelectedItem.ToString());
            Console.WriteLine("Combo=" + comboTest.SelectedItem.ToString());

            if (comboTest.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Set 1")
                eyesOne();


            if (comboTest.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Set 2")
                eyesTwo();            


            if (comboTest.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Set 3")
                eyesThree();


            if (comboTest.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Set 4")
                eyesFour();

        }

        private void sliderTest_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //MessageBox.Show(e.ToString());
            //MessageBox.Show(sliderTest.Value.ToString());
            Console.WriteLine("Slider=" + sliderTest.Value.ToString());
            Console.WriteLine("Slider e=" + e.ToString());

            double myDouble = double.Parse(sliderTest.Value.ToString());
            int myInt = (int)myDouble;
            if (myInt == 0) {
                mouthOne();  
            }

            if (myInt == 3)
            {
                mouthTwo();
            }

            if (myInt == 6)
            {
                mouthThree();
            }
            if (myInt == 10)
            {
                mouthFour();
            }

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            noseOne();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            noseTwo();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            noseThree();
        }
        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            noseFour();
        }
    }
}
