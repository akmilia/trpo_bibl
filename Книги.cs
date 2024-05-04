using System;
using System.Collections.Generic;

namespace trpo_bibl;

public partial class Книги
{
    public int IdКнига { get; set; }

    public string? Название { get; set; }

    public string? Автор { get; set; }

    public string? Жанр { get; set; }

    public string? ГодИздания { get; set; }

    public string? Статус { get; set; }

    public int? КолВо { get; set; }

    public virtual Заказы? Заказы { get; set; }
}
