using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfControllerStudy.ViewModels;

namespace WpfControllerStudy
{
    internal class TestClickCommand : ICommand
    {
        
        public event EventHandler CanExecuteChanged;
        private bool rtnCan = true;
        private MainViewModel _mainViewModel;

        public TestClickCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public bool CanExecute(object parameter)    //연결 여부
        {
            return rtnCan;
        }

        public void Execute(object parameter)
        {
            rtnCan = false;
            MessageBox.Show(_mainViewModel.ProgressValue + " ");
        }
    }
}
