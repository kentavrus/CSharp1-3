using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13
{
    internal class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;

        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _dateOfBirth = DateTime.Today;

        private Visibility _buttonVisibility = Visibility.Visible;

        private RelayCommand<object> _submitCommand;

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }


        public Visibility ButtonVisibility
        {
            get { return _buttonVisibility; }
            set
            {
                _buttonVisibility = value;
                OnPropertyChanged();
            }
        }


        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _submitCommand ?? (_submitCommand = new RelayCommand<object>(
                    SubmitImplementation, o => CanExecuteCommand()));
            }
        }


        private async void SubmitImplementation(object obj)
        {
           
            try
            {
                _person = new Person(_firstName, _lastName, _email, _dateOfBirth);

                if (_person.IsBirthday)
                {
                    MessageBox.Show("Ou, today is your day. Happy Birthday for you");
                }
                MessageBox.Show("Name: " + _person.FirstName + " " + _person.LastName + "\n Your Birth day: " + _person.DateOfBirth.Day + "." +
                    _person.DateOfBirth.Month + "." + _person.DateOfBirth.Year + "\n Your age: " + _person.Age + "\n Your email: " + _person.Email + "\n IsAdult: "
                    + _person.IsAdult + "\n Western zodiac: " + _person.WesternSign + "\n Chinnese zodiac: " + _person.ChineseSign);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_firstName) && !string.IsNullOrWhiteSpace(_lastName) && !string.IsNullOrWhiteSpace(_email);
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
