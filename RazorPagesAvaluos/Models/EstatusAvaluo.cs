using System.ComponentModel.DataAnnotations;

namespace RazorPagesAvaluos.Models
{
    public class EstatusAvaluo
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public ICollection<Avaluo>? Avaluos { get; set; }
    }
}
