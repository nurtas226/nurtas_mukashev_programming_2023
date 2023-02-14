using System;
using System.Collections.Generic;
using System.IO;
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

namespace InvoicesManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class Data
        {
            public decimal Price;
            public DateTime Date;
            public string ExpenseType;

            public Data(decimal price, DateTime date, string expenseType)
            {
                this.Price = price;
                this.Date = date;
                this.ExpenseType = expenseType;
            }

            ~Data() { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = Box.Text;

            if (File.Exists(filePath))
            {

                List<Data> invDataList = new List<Data>();
                using (StreamReader reader = new StreamReader(filePath))
                {

                    string temp = reader.ReadLine();
                    var dates = new HashSet<DateTime>();
                    string[] tempSpl = temp.Split(';');
                    string text;
                    string wholeText = "";
                    string[] arr = new string[3];

                    wholeText += tempSpl[0] + "\t\t" + tempSpl[1] + "\t\t" + tempSpl[2] + "\n";
                    while (!reader.EndOfStream)
                    {
                        text = reader.ReadLine();
                        arr = text.Split(';');
                        wholeText += arr[0] + "\t\t" + arr[1] + "\t" + arr[2] + "\n";


                    }

                    FBox.Text = (wholeText);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error");
            }
        }
    }
    
}
