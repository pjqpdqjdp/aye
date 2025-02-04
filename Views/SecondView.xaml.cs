using MVVMTransferData.ViewModels;

namespace MVVMTransferData.Views;

// Ссылок: 8
public partial class SecondView : ContentPage
{
    // Ссылок: 0
    public SecondView()
    {
        InitializeComponent();
        BindingContext = new SecondViewModel();
    }
}