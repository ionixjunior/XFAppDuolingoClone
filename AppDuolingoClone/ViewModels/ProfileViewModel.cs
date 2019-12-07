using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;
using Prism;
using Prism.Navigation;

namespace AppDuolingoClone.ViewModels
{
    public class ProfileViewModel : ViewModelBase, IActiveAware
    {
        private readonly IAchievementsService _achievementsService;

        public ObservableCollection<Achievement> Achievements { get; private set; }

        public ProfileViewModel(IAchievementsService achievementsService)
        {
            _achievementsService = achievementsService;

            Achievements = new ObservableCollection<Achievement>();
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        private async void RaiseIsActivatedChanged()
        {
            await RaiseIsActivatedChangedAsync();
        }

        private async Task RaiseIsActivatedChangedAsync()
        {
            if (IsActive)
            {
                if (Achievements.Count == 0)
                {
                    var achievements = await _achievementsService.GetAchievementsAsync();

                    foreach (var achievement in achievements)
                        Achievements.Add(achievement);
                }
            }
        }
    }
}
