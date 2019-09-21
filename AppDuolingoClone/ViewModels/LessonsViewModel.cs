using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;
using Prism.Commands;
using Prism.Navigation;

namespace AppDuolingoClone.ViewModels
{
    public class LessonsViewModel : ViewModelBase, IInitialize
    {
        private readonly ILessonService _lessonService;

        public ICommand NavigateToTrainingCommand { get; private set; }
        public IList<LessonGroup> LessonGroup { get; private set; }

        public LessonsViewModel(ILessonService lessonService)
        {
            _lessonService = lessonService;
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
            LessonGroup = new List<LessonGroup>();
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("O FAB foi selecionado");
        }

        public async void Initialize(INavigationParameters parameters)
        {
            var groups = await GetLessonsGroup();

            foreach (var group in groups)
                LessonGroup.Add(group);
        }

        private async Task<IList<LessonGroup>> GetLessonsGroup()
        {
            return await _lessonService.GetLessonsGroup();
        }
    }
}
