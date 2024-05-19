using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfItemControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();

            employees = new()
            {
                new(){ Name = "Bobby", Age = 27, Company = "Yandex" },
                new(){ Name = "Sammy", Age = 41, Company = "Mail Group" },
                new(){ Name = "Bobby Fisher", Age = 52, Company = "Yandex" },
                new(){ Name = "Jimmy", Age = 33, Company = "Ozon" },
                new(){ Name = "Tommy", Age = 24, Company = "Yandex" },
                new(){ Name = "Bobby Junior", Age = 15, Company = "Mail Group" }
            };

            listViewEmployees.ItemsSource = employees;

            //foreach(var e in employees)
            //    listBoxEmployees.Items.Add(e);

            //listBoxEmployees.ItemsSource = employees;
            //comboBoxEmployees.ItemsSource = employees;

            //listBox.Items.Add(new TextBlock(new Run("Hello world")));
            //Employee employee = new() { Name = "Sammy", Age = 29 };
            //listBox.Items.Add(employee);
        }

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    employees.Add(new Employee()
        //    {
        //        Name = txtEmployeeName.Text,
        //        Age = Int32.Parse(txtEmployeeAge.Text)
        //    });
        //    //listBoxEmployees.Items.Refresh();
        //    comboBoxEmployees.Items.Refresh();

            
        //}

        //private void listBoxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string str = "";

        //    //foreach (Employee empl in listBoxEmployees.SelectedItems)
        //    //    str += empl + "\n";
        //    MessageBox.Show(str);
        //}

        //private void comboBoxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //string? str = comboBoxEmployees.SelectedValue.ToString();
        //    //MessageBox.Show(str);
        //}
    }
}