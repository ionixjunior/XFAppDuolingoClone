using System;
using System.Windows.Input;
using Prism.Commands;

namespace AppDuolingoClone.ViewModels
{
    public class LessonsViewModel : ViewModelBase
    {
        public ICommand NavigateToTrainingCommand { get; private set; }

        public LessonsViewModel()
        {
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("O FAB foi selecionado");
        }
    }
}
