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
using WpfControllerStudy.Models;
using WpfControllerStudy.ViewModels;

namespace WpfControllerStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainviewmodel;
        public MainWindow()
        {
            InitializeComponent();
            mainviewmodel = new MainViewModel();
            mainviewmodel.ProgressValue = 30;
            DataContext = mainviewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*            List<User> MyList1 = new List<User>();

                        lbTest.Content = "안녕하세요 버튼을 눌렀군요.";
                        //MessageBox.Show(CheckBoxTest.IsChecked + "");
                        //MessageBox.Show(textbox1.Text);
                        User userA = new User();
                        userA.Name = "Jaejun";
                        userA.UserAge = 24;
                        userA.UserImg = "D:\\Project_For_Coding\\language\\C#\\WPF\\WpfControllerStudy\\WpfControllerStudy\\img\\photo1.jpg";

                        User userB = new User();
                        userB.Name = "jinho";
                        userB.UserAge = 14;
                        userB.UserImg = "D:\\Project_For_Coding\\language\\C#\\WPF\\WpfControllerStudy\\WpfControllerStudy\\img\\photo1.jpg";

                        MyList1.Add(userA);
                        MyList1.Add(userB);

                        ListView_modelTest.ItemsSource = MyList1;*/
            mainviewmodel.ProgressValue = 100;
        }
    }
}
