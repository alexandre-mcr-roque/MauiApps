using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoDataBinding.Models
{
    public class Product : INotifyPropertyChanged
    {
        private string _name = null!;
        private decimal _price;
        private int _stock;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public int Stock
        {
            get => _stock;
            set
            {
                _stock = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
