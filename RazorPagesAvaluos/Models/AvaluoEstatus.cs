﻿namespace RazorPagesAvaluos.Models
{
    public class AvaluoEstatus
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public virtual ICollection<Avaluo> Avaluos { get; set; } = new List<Avaluo>();
    }
}
