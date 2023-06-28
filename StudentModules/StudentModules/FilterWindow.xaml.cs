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
using System.Windows.Shapes;

namespace StudentModules
{
    /// <summary>
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        public FilterWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
            string strSearch;
            Student myStudent = new Student();
            List<Student> stList = new List<Student>();

            if (txtSearchText.Text.Length == 0)
            {
                MessageBox.Show("Please enter text to search","Student App",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtSearchText.Focus();
            }
            else
            {
                strSearch = txtSearchText.Text;

                if (cmbSearchType.SelectedItem.ToString().Equals("Student number"))
                {
                    myStudent = Student.GetStudent(strSearch);
                    lstDisplay.Items.Add(myStudent.ToString());
                }
                else if (cmbSearchType.SelectedItem.ToString().Equals("Lastname"))
                {
                    stList = Student.GetStudentByLastname(strSearch);
                    lstDisplay.Items.Add(Student.GetStudentsData(stList));

                }
                else if (cmbSearchType.SelectedItem.ToString().Equals("Age"))
                {

                }
                else if (cmbSearchType.SelectedItem.ToString().Equals("Method of Study"))
                {

                }
            }

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbSearchType.Items.Add("Student number");
            cmbSearchType.Items.Add("Lastname");
            cmbSearchType.Items.Add("Age");
            cmbSearchType.Items.Add("Method of Study");
        }

        private void cmbSearchType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtSearchText.Clear();
            txtSearchText.Focus();
        }
    }
}
