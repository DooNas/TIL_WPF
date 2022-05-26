using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfControllerStudy;

namespace WpfControllerStudy.ViewModels
{
    class MainViewModel:INotifyPropertyChanged
    {
        private int progressValue;
        public ICommand TestClick { get; set; }

        public MainViewModel()
        {
            TestClick = new RelayCommand<object>(ExecuteMyButton, CanMyButton);
        }

        public int ProgressValue
        {
            get { return progressValue; }
            set { 
                progressValue = value; 
                NotifyPropertyChanged(nameof(ProgressValue));
            }
        }

        bool CanMyButton(object parameter)
        {
            if(parameter == null)
            {
                return true;
            }
            return parameter.ToString().Equals("ABC")? true : false;
        }
        void ExecuteMyButton(object parameter)
        {
            MessageBox.Show(parameter.ToString() + "AAA");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
