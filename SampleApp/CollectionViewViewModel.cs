using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp;

public partial class CollectionViewViewModel : ObservableObject
{
    [ObservableProperty]
    private string? productName;

    public string? ProductDescription { get; set; }
}
