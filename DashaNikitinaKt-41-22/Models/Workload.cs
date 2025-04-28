namespace DashaNikitinaKt_41_22.Models;

public class Workload
{
    public int Id { get; set; } // Первичный ключ
    public int Hours { get; set; } // Количество часов

    // Связь "многие-к-одному" с преподавателями
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; } = null!;
}