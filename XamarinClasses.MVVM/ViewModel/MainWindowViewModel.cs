﻿using XamarinClasses.MVVM.Model;
using XamarinClasses.MVVM.Services;
using XamarinClasses.MVVM.Services.Interfaces;
using XamarinClasses.MVVM.ViewModel.Base;
using XamarinClasses.MVVM.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinClasses.MVVM.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged("Name"); }
        }

        private List<Drink> _drinks;
        public List<Drink> Drinks
        {
            get
            {
                return _drinks;
            }
            set
            {
                _drinks = value; RaisePropertyChanged("Drinks");
            }
        }


        private IDrinkService _drinkService;

        public MainWindowViewModel()
        {
            Name = "Hello";
            _drinkService = new DrinkService();
        }

        public ICommand CommandChangeName
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Name = "Hello MVVM";
                });
            }
        }

        public ICommand CommandRefreshDrinks
        {
            get
            {
                return new RelayCommand(() =>
                {
                    Drinks = _drinkService.CreateDrinks();
                });
            }
        }

    }
}
