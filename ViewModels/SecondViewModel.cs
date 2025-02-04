using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMTransferData.Models;
using MVVMTransferData.ViewModels;
using MVVMTransferDataTrofimov;


namespace MVVMTransferData.ViewModels;

[QueryProperty(nameof(InputLesson), nameof(InputLesson))]
public partial class SecondViewModel : ObservableObject
{
    [ObservableProperty]
    private Lesson _inputLesson;


    [RelayCommand]
    private async Task GoBackToFirstViewAsync()
    {
        // Проверяем, что InputLesson не null
        if (InputLesson == null)
        {
            // Обрабатываем случай, когда InputLesson равен null
            await AppShell.Current.DisplayAlert("Ошибка", "Нечего передавать обратно. InputLesson равен null.", "ОК");
            await Shell.Current.GoToAsync("..");  // Просто возвращаемся назад, если нет данных для передачи
            return;
        }

        // Создаем словарь для передачи данных через навигацию
        var navigationParameters = new Dictionary<string, object>
        {
            { "lessonFromSecondView", InputLesson } // Ключ с именем параметра
        };


        // Выполняем навигацию назад с передачей параметров
        await Shell.Current.GoToAsync("..", navigationParameters);
    }
}