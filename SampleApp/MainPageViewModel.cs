using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace SampleApp;

public partial class MainPageViewModel : ObservableObject
{
    public ObservableCollection<CollectionViewViewModel> ProductList { get; set; }
    public MainPageViewModel()
    {
        ProductList = [];
        ProductList.Add(new CollectionViewViewModel
        {
            ProductName = "Monkey Doll",
            ProductDescription="Mokey like eating banana."
        });
        ProductList.Add(new CollectionViewViewModel
        {
            ProductName = "Kitty Doll",
            ProductDescription="Kitty like drinking milk."
        });
    }

    [RelayCommand]
    private async Task UserClick(CollectionViewViewModel item)
    {
        await Application.Current!.Windows[0]!.Page!.DisplayAlertAsync(item.ProductName, item.ProductDescription, "ok");
    }
}
