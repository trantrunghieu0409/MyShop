using ProjectMyShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMyShop
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public BindingList<Phone> Phones { get; set; } = new BindingList<Phone>();
        public BindingList<Phone> SelectedPhones { get; set; } = new BindingList<Phone>();

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
