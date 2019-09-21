using System;
using System.Windows.Input;
using AppDuolingoClone.Interfaces;
using Prism.Commands;

namespace AppDuolingoClone.ViewModels
{
    public class LessonsViewModel : ViewModelBase
    {
        public ICommand NavigateToTrainingCommand { get; private set; }

        public LessonsViewModel(ILessonService lessonService)
        {
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("O FAB foi selecionado");
        }
    }
}
