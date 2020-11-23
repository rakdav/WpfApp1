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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x1 = double.Parse(X1.Text);
                double y1 = double.Parse(Y1.Text);
                double x2 = double.Parse(X2.Text);
                double y2 = double.Parse(Y2.Text);
                MyPoint p1 = new MyPoint(x1,y1);
                MyPoint p2 = new MyPoint(x2, y2);
                Vector v1 = new Vector(p1,p2);
                Result.Text = v1.Length().ToString()+Environment.NewLine;

                double x3 = double.Parse(X3.Text);
                double y3 = double.Parse(Y3.Text);
                double x4 = double.Parse(X4.Text);
                double y4 = double.Parse(Y4.Text);
                MyPoint p3 = new MyPoint(x3, y3);
                MyPoint p4 = new MyPoint(x4, y4);
                Vector v2 = new Vector(p3, p4);
                Result.Text += v2.Length().ToString()+Environment.NewLine;

                Vector v3 = v1 + v2;
                Result.Text += v3.Length().ToString()+Environment.NewLine;

                Vector v4 = v1 - v2;
                Result.Text += v4.Length().ToString() + Environment.NewLine;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
