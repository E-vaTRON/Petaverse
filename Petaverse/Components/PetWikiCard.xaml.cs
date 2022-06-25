using Petaverse.Models;

namespace Petaverse.Components;

public partial class PetWikiCard : ContentView
{
    public static readonly BindableProperty BreedInfoProperty = BindableProperty.Create(nameof(BreedInfo), 
                                                                                        typeof(Models.Breed), typeof(PetWikiCard), new Breed() { BreedName = "Initial Name"});

    public Breed BreedInfo
    {
        get => (Breed)GetValue(PetWikiCard.BreedInfoProperty);
        set => SetValue(PetWikiCard.BreedInfoProperty, value);
    }

    public PetWikiCard()
	{
		InitializeComponent();
	}
}