namespace MVVMTransferData.Models;

// Ссылок: 12
public class Lesson
{
    // Ссылок: 1
    public string ClassroomName { get; set; }
    // Ссылок: 1
    public string TeacherName { get; set; }
    // Ссылок: 1
    public string SubjectName { get; set; }
    // Ссылок: 1
    public TimeSpan StartAt { get; set; }
    // Ссылок: 1
    public TimeSpan EndAt { get; set; }

    // Ссылок: 1
    public Lesson(
        string classroomName,
        string teacherName,
        string subjectName,
        TimeSpan startAt,
        TimeSpan endAt)
    {
        ClassroomName = classroomName;
        TeacherName = teacherName;
        SubjectName = subjectName;
        StartAt = startAt;
        EndAt = endAt;
    }
}