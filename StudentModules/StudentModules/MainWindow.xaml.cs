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

namespace StudentModules
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Declare
            string stNum;
            string firstname;
            string lastname;
            int age;
            string method = "None";

            //Assign
            stNum = txtStNumber.Text;
            firstname = txtFirstname.Text;
            lastname = txtLastname.Text;
            age = Convert.ToInt32(txtAge.Text);
            if (rdoFulltime.IsChecked == true)
            {
                method = "Full-time";
            }else if (rdoPartime.IsChecked == true)
            {
                method = "Part-time";
            }

            Student st = new Student(stNum, firstname, lastname, age,method);

            //Use variables
            //lstDisplay.Items.Add(st.ToString());
            Student.Students.Add(st); //Add student into the list

            //Clear controls
            ClearForm();
        }

        public void ClearForm()
        {
            txtAge.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtStNumber.Clear();
            txtStNumber.Focus();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Add(Student.AllStudents());
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            FilterWindow winFilter = new FilterWindow();
            winFilter.ShowDialog();
        }
    }
}
