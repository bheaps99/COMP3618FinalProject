using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
using DomainClasses;
using Repository2;
using ViewModel2;


namespace SamuraiBattleView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            bool db = false;
            using (var connection = new OleDbConnection(@"Server = (localdb)\mssqllocaldb; Trusted_Connection = True; "))
            {
                try
                {
                    connection.Open();
                    db = true;
                }
                catch (Exception e) { }
            }
            IRepository repository;
            if (db) repository = new DBRepository();
            else repository = new CSVRepository();



                

            InitializeComponent();
            DataContext = new SamuraiBattleViewModel(repository);
        }
    }
}
