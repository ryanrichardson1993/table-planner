using System.Collections.Generic;
using Prism.Mvvm;

namespace TablePlanner
{
    public class Table : BindableBase
    {
        private List<Guest> _guests;

        public List<Guest> Guests
        {
            get => _guests;
            set => SetProperty(ref _guests, value);
        }
    }
}