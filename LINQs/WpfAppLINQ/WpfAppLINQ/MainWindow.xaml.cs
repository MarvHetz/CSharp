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

namespace WpfAppLINQ
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void TestDel(string s);

        public MainWindow()
        {
            InitializeComponent();

            TestDel del = new TestDel(name => listBoxLinQ.Items.Add("Hello "+name));

            del("Ingrid");
        }
        private void DoSomething(string name)
        {
            listBoxLinQ.Items.Add("Hello" + name);
        }
    }
}
