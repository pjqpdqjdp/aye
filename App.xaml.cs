using MVVMTransferData.Views; //уточните неймспейс

namespace MVVMTransferDataTrofimov;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell(); // Устанавливаем AppShell в качестве MainPage
    }
}

