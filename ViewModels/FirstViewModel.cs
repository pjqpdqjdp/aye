    using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMTransferData.Models;
using MVVMTransferData.Views;
using MVVMTransferDataTrofimov;

namespace MVVMTransferData.ViewModels;
[QueryProperty(nameof(InputtedLessonFromSecondView), "lessonFromSecondView")] // Связываем с параметром lessonFromSecondView
public partial class FirstViewModel : ObservableObject
{
    [ObservableProperty]
    private string _classroomName;

    [ObservableProperty]
    private string _teacherName;

    [ObservableProperty]
    private string _subjectName;

    [ObservableProperty]
    private TimeSpan _startAt;

    [ObservableProperty]
    private TimeSpan _endAt;

    [ObservableProperty]
    
    private Lesson _inputtedLessonFromSecondView;

    partial void OnInputtedLessonFromSecondViewChanged(Lesson value)
    {
        // Этот код будет автоматически вызван при изменении InputtedLessonFromSecondView                            
        if (value != null)
        {
            ClassroomName = value.ClassroomName;
            TeacherName = value.TeacherName;
            SubjectName = value.SubjectName;
            StartAt = value.StartAt;
            EndAt = value.EndAt;
        }
        else
        {
            //Обработка случая если value == null
        }
    }

    [RelayCommand]
    private async Task GoToSecondViewAsync()
    {
        if (string.IsNullOrWhiteSpace(ClassroomName))
        {
            await AppShell.Current.DisplayAlert("Ошибка", "Пожалуйста, введите название аудитории.", "OK");
            return;
        }

        Lesson lesson = new Lesson(ClassroomName, TeacherName, SubjectName, StartAt, EndAt);
        var navigationParameter = new Dictionary<string, object>
        {
            { nameof(SecondViewModel.InputLesson), lesson }
        };

        await Shell.Current.GoToAsync(nameof(SecondView), navigationParameter);
    }
}