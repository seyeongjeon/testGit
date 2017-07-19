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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int re;
        int l_value, r_value;

        double originalWidth, originalHeight;
        ScaleTransform scale = new ScaleTransform();
        public MainWindow()
        {
            InitializeComponent();

            textBox.Text = "";
            textBox.TextAlignment = TextAlignment.Right;
            textBox.FontSize = 19;

            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            originalWidth = this.Width;
            originalHeight = this.Height;

            if (this.WindowState == WindowState.Maximized)
            {
                ChangeSize(this.ActualWidth, this.ActualHeight);
            }
            this.SizeChanged += new SizeChangedEventHandler(MainWindow_SizeChanged);
        }
        void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChangeSize(e.NewSize.Width, e.NewSize.Height);
        }
        private void ChangeSize(double width, double heigt)
        {
            scale.ScaleX = width / originalWidth;
            scale.ScaleY = heigt / originalHeight;

            FrameworkElement rootElement = this.Content as FrameworkElement;
            rootElement.LayoutTransform = scale;
        }

        private void close_event(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox.TextAlignment = TextAlignment.Right;
            textBox.FontSize = 19;
        }

        private void clos_DragEnter(object sender, DragEventArgs e)
        {
            textBox.Text = "";
            textBox.TextAlignment = TextAlignment.Right;
            textBox.FontSize = 19;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            String add = "";

            if(btn.Name == "button1")
            {
                add = "1";
            }
            else if(btn.Name == "button2")
            {
                add = "2";
            }
            else if (btn.Name == "button3")
            {
                add = "3";
            }
            else if (btn.Name == "button4")
            {
                add = "4";
            }
            else if (btn.Name == "button5")
            {
                add = "5";
            }
            else if (btn.Name == "button6")
            {
                add = "6";
            }
            else if (btn.Name == "button7")
            {
                add = "7";
            }
            else if (btn.Name == "button8")
            {
                add = "8";
            }
            else if (btn.Name == "button9")
            {
                add = "9";
            }
            else if (btn.Name == "button_division")
            {
                add = "/";
            }
            else if (btn.Name == "button_minus")
            {
                add = "-";
            }
            else if (btn.Name == "button_plus")
            {
                add = "+";
            }
            else if (btn.Name == "button_result")
            {

                textBox.Clear();
                add = "re";
            }

            textBox.AppendText(add);

        }
    }
}
