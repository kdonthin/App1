using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.Models
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (value != _firstName )
                {
                    _firstName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string LastName
        { 
            get 
            { 
                return _lastName; 
            } 
            set 
            { 
                if (value != _lastName)
                { 
                    _lastName = value;
                    OnPropertyChanged();
                } 
            } 
        }

        internal void OnPropertyChanged([CallerMemberName] string member="")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(member));
            }
        }
    }
}