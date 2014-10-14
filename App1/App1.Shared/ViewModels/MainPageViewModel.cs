using System;
using System.Collections.Generic;
using System.Text;
using App1.Models;
using App1.Common;

namespace App1.ViewModels
{
    public class MainPageViewModel
    {
        private RelayCommand _updateNameCommand;

        public Customer MyCustomer { get; set; }

        public MainPageViewModel()
        {
            MyCustomer = new Customer() { FirstName = "Kishore", LastName = "Donthineni" };
        }

        public void UpdateName()
        {
            MyCustomer.FirstName = "Radhika" ;
        }

        public RelayCommand UpdateNameCommand
        {
            get
            {
                if ( _updateNameCommand == null)
                {
					_updateNameCommand = new RelayCommand(UpdateName);
                }

                return _updateNameCommand;
            }

            set
            {
                _updateNameCommand = value;
            }
        }
    }
}
