using System.ComponentModel.DataAnnotations;

namespace RazorPagesAvaluos.Models
{
    public class ArchivosAdjuntos
    {
        public int Id { get; set; }
        public int AvaluoId { get; set; }
        public string? NombreArchivo { get; set; }
        public string? TipoArchivo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public byte[]? Archivo { get; set; }

        public Avaluo? Avaluo { get; set; }
    }
}
