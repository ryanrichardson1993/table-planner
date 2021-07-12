using System.Collections.Generic;
using Prism.Commands;
using Prism.Mvvm;

namespace TablePlanner
{
    public class GuestsViewModel : BindableBase
    {
        private readonly GuestsDataAccess _guestsDataAccess;
        private List<Guest> _guests;
        private List<Table> _tables = new List<Table>
        {
            new Table { Guests = new List<Guest> { new Guest("Fake"), new Guest("Fake") }},
            new Table { Guests = new List<Guest> { new Guest("Fake") }},
            new Table { Guests = new List<Guest> { new Guest("Fake"), new Guest("Fake"), new Guest("Fake") }},
            new Table { Guests = new List<Guest> ()},
            new Table { Guests = new List<Guest> { new Guest("Fake"), new Guest("Fake"), new Guest("Fake"), new Guest("Fake") }},
            new Table { Guests = new List<Guest> { new Guest("Fake") }},
            new Table { Guests = new List<Guest> { new Guest("Fake") }},
            new Table { Guests = new List<Guest> { new Guest("Fake") }}
        };

        public List<Guest> Guests
        {
            get => _guests;
            set => SetProperty(ref _guests, value);
        }

        public List<Table> Tables
        {
            get => _tables;
            set => SetProperty(ref _tables, value);
        }

        //public int TableCount
        //{
        //    get => Tables.Count;
        //    set => UpdateTableCount(value);
        //}

        //private void UpdateTableCount(int newTableCount)
        //{
        //    if (newTableCount == TableCount)
        //    {
        //        return;
        //    }
            
        //    if(newTableCount > TableCount)
        //}

        public DelegateCommand LoadFileCommand { get; set; }

        public GuestsViewModel(GuestsDataAccess guestsDataAccess)
        {
            this._guestsDataAccess = guestsDataAccess;
            
            LoadFileCommand = new DelegateCommand(LoadFile);
        }

        private void LoadFile()
        {
            Guests = _guestsDataAccess.GetProductsFromCsv();
        }
    }
}
