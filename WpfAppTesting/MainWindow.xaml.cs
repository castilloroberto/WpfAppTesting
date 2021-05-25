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

namespace WpfAppTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Person> listPeople = new List<Person>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            string id = (listPeople.Count() + 1).ToString(); 
            Person person = new Person(id,txt_name.Text,txt_lastname.Text,txt_email.Text,txt_brithday.Text,txt_gender.Text);
            listPeople.Add(person);
            UpdateDatagrid();
        }


        private void UpdateDatagrid()
        {

            foreach (Person person in listPeople)
            {
                dgv_people.Items.Add(person);

            }
        }

    }
}
