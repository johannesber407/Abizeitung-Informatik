using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Test
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BigInteger Msg;
            {
                Msg = 4 * 37 * 47 * 1319 * BigInteger.Parse("54422961495680441") * BigInteger.Parse("10598036006505363683")* BigInteger.Parse("177186256976360266285996337") * 9039101130330683;
                Msg = (Msg + BigInteger.Pow(98989, 17)) * 9 * 251 * 1367 * 23827 * 1877 + BigInteger.Parse("82264184889839299603") * BigInteger.Pow(10,100);
                Msg = ((70 * Msg + BigInteger.Pow(987654321, 13)) * 280 + BigInteger.Pow(123456789, 15)) * 350;
                Decode(Msg);
            }
        }
        private string Decode(BigInteger Msg)
        {
            byte[] Binary = Msg.ToByteArray();
            MessageBox.Show(Encoding.ASCII.GetString(Binary));
            return Encoding.ASCII.GetString(Binary);
        }
    }
}
