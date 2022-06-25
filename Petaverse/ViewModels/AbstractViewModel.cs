using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Petaverse.Models;

namespace Petaverse.ViewModels;

    public partial class AbstractViewModel : ObservableObject
    {
        [ObservableProperty]
        int count;

        [ObservableProperty]
        Breed breedInfoInViewModel;

        [ICommand]
        void IncrementCount()
        {
            Count += 10;
            BreedInfoInViewModel.BreedName = $"Breed Number {Count}";
        }


        public AbstractViewModel()
        {
            BreedInfoInViewModel = new Breed();
        }
    }
