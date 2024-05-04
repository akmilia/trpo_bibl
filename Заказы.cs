using System;
using System.Collections.Generic;

namespace trpo_bibl;

public partial class Заказы
{
    public int IdЗаказы { get; set; }

    public int ПользователиIdПользователя { get; set; }

    public DateTime? Срок { get; set; }

    public int КнигиIdКнига { get; set; }

    public virtual Книги IdЗаказыNavigation { get; set; } = null!;

    public virtual Пользователи ПользователиIdПользователяNavigation { get; set; } = null!;
}
