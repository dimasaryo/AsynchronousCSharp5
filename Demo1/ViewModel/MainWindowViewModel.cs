using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Demo1
{
    class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<string> _output;

        public MainWindowViewModel()
        {
            _output = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Output
        {
            get 
            {
                return _output;
            }
            set
            {
                if (_output != value)
                {
                    _output = value;
                    OnPropertyChanged("Output");
                }
            }
        }

        public ICommand ProcessCommand
        {
            get
            {
                return new RelayCommand(new Action( async () => {
                    await CallLongProcess();
                    _output.Add( "Program Finish" );
                }), CanExecuteProcess);
                
            }
        }

        private bool CanExecuteProcess()
        {
            return true;
        }

        private bool CancelCanExecute
        {
            get
            {
                return true;
            }
        }

        private async Task LongProcess()
        {
            System.Threading.Thread.Sleep(5000);
        }

        private async Task CallLongProcess()
        {
            await LongProcess();
            _output.Add("Long Process Finish");
        }
    }
}
