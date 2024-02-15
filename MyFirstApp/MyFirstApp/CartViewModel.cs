using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyFirstApp
{
    public class CartViewModel : INotifyPropertyChanged
    {
        public CartViewModel()
        {
            AddCommand = new Command(() =>
            {
                Result = Add().ToString();

            });
            SubstractCommand = new Command(() =>
            {
                Result = Sub().ToString();

            });
            MultiplicationCommand = new Command(() =>
            {
                Result = Mult().ToString();

            });
            DivisionCommand = new Command(() =>
            {
                Result = Div().ToString();

            });
        }
        int _num1;
        int _num2;
        string _result;
        public int Num1
        {
            get => _num1;
            set
            {
                _num1 = value;
                var args = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public int Num2
        {
            get => _num2;

            set
            {
                _num2 = value;
                var args = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string Result
        {
            get => _result;

            set
            {
                _result = value;
                var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public int Add()
        {
            return Num1 + Num2;
        }
        public int Sub()
        {
            return Num1 - Num2;
        }
        public int Mult()
        {
            return Num1 * Num2;
        }
        public int Div()
        {
            return Num1 / Num2;
        }
        public Command AddCommand { get; }
        public Command SubstractCommand { get; }
        public Command MultiplicationCommand { get; }
        public Command DivisionCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }

}
