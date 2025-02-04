using MVVMTransferData.ViewModels;

namespace MVVMTransferData.Views;

// Ссылок: 5
public partial class FirstView : ContentPage
{
    // Ссылок: 0
    public FirstView()
    {
        InitializeComponent();
        BindingContext = new FirstViewModel();
    }
}