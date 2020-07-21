using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp3.ViewModels.Base
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _numberA;
        public int NumberA
        {
            get { return _numberA; }
            set
            {
                _numberA = value;
                OnPropertyChanged(""); // уведомление View о том, что изменилась функция
            }
        }

        private int _numberB;
        public int NumberB
        {
            get { return _numberB; }
            set
            {
                _numberB = value;
                OnPropertyChanged(""); // уведомление View о том, что изменилась функция
            }
        }
        private int _numberC;
        public int NumberC
        {
            get { return _numberC; }
            set
            {
                _numberC = value;
                OnPropertyChanged(""); // уведомление View о том, что изменилась функция
            }
        }
        private int _numberX;
        public int NumberX
        {
            get { return _numberX; }
            set
            {
                _numberX = value;
                OnPropertyChanged(""); // уведомление View о том, что изменилась функция
            }
        }
    }


}
