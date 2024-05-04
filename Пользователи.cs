using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;

namespace trpo_bibl;


public partial class Пользователи
{
   
    public int IdПользователя { get; set; }

    public string? Статус { get; set; }

    public string? Фамилия { get; set; }

    public string? Имя { get; set; }

    public string? Отчество { get; set; }

    public string? Телефон { get; set; }

    public string? Email { get; set; }

    public string Пароль { get; set; } = null!;

    public virtual ICollection<Заказы> Заказыs { get; set; } = new List<Заказы>();
}
