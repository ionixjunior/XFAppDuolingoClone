using System;
using System.Linq;
using System.Collections.Generic;
using AppDuolingoClone.Interfaces;
using AppDuolingoClone.Models;
using Prism;

namespace AppDuolingoClone.ViewModels
{
    public class StoreViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoreService _storeService;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        public event EventHandler IsActiveChanged;

        public List<StoreItemGroup> Groups { get; private set; }

        public StoreViewModel(IStoreService storeService)
        {
            _storeService = storeService;
            Groups = new List<StoreItemGroup>();
        }

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                if (!Groups.Any())
                {
                    var storeGroups = await _storeService.GetItems();
                    Groups.AddRange(storeGroups);
                }
            }
        }
    }
}
