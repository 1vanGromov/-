using System;
using System.Collections.Generic;

namespace AvaliniaEnd.Models;

public partial class Winner
{
    public int WinnderId { get; set; }

    public int? ParticipantId { get; set; }

    public int? EventId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Participant? Participant { get; set; }
}
