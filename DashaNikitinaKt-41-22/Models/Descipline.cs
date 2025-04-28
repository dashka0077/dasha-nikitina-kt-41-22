namespace DashaNikitinaKt_41_22.Models;

public class Discipline
{
    public int Id { get; set; } // Первичный ключ
    public string Name { get; set; } = null!; // Название дисциплины

    // Связь "многие-ко-многим" с преподавателями
    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}