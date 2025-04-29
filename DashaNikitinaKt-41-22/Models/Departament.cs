﻿using System.Collections.Generic;

namespace DashaNikitinaKt_41_22.Models;

public class Department
{
    public int Id { get; set; } // Первичный ключ

    public string Name { get; set; } = null!; // Название кафедры

    // Связь "один-к-одному" с заведующим кафедрой
    public int HeadOfDepartmentId { get; set; }
    public Teacher HeadOfDepartment { get; set; } = null!;

    // Связь "один-ко-многим" с преподавателями
    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}