using System;
using AppDuolingoClone.Interfaces;
using Prism;

namespace AppDuolingoClone.ViewModels
{
    public class StoriesViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoriesService _storiesService;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        public event EventHandler IsActiveChanged;

        public StoriesViewModel(IStoriesService storiesService)
        {
            _storiesService = storiesService;
        }

        private void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                System.Diagnostics.Debug.WriteLine("Evento da aba");
            }
        }
    }
}
