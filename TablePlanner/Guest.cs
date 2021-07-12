using Prism.Mvvm;

namespace TablePlanner
{
    public class Guest : BindableBase
    {
        private string _name;
        private bool _coming;
        private bool _alcohol;
        private string _dietaryRequirements;
        private bool _highChair;

        public Guest(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public bool Coming
        {
            get => _coming;
            set => SetProperty(ref _coming, value);
        }

        public bool Alcohol
        {
            get => _alcohol;
            set => SetProperty(ref _alcohol, value);
        }

        public string DietaryRequirements
        {
            get => _dietaryRequirements;
            set => SetProperty(ref _dietaryRequirements, value);
        }

        public bool HighChair
        {
            get => _highChair;
            set => SetProperty(ref _highChair, value);
        }
    }
}