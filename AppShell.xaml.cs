using MVVMTransferData.Views; //уточните неймспейс

namespace MVVMTransferDataTrofimov;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(FirstView), typeof(FirstView));
        Routing.RegisterRoute(nameof(SecondView), typeof(SecondView));
    }
}

