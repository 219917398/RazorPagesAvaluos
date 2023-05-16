using System.ComponentModel.DataAnnotations;

namespace RazorPagesAvaluos.Models;

public class Avaluo
{
    public int Id { get; set; }

    [Display(Name = "Fecha del avalúo")]
    public DateTime FechaAvaluo { get; set; }
    [Display(Name = "Valuador")]
    public string? Valuador { get; set; }
    [Display(Name = "Solicitante")]
    public string? Solicitante { get; set; }
    [Display(Name = "Propietario del Inmueble")]
    public string? PropietarioInmueble { get; set; }
    [Display(Name = "Proposito del avalúo")]
    public string? PropositoAvaluo { get; set; }

    // public int EstatusAvaluoId { get; set; }
    [Display(Name = "Tipo de Propiedad")]
    public string? TipoPropiedad { get; set; }
    
    [Display(Name = "Calle")]
    public string? Calle { get; set; }
    
    [Display(Name = "Num. Exterior ")]
    public string? NumExterior { get; set; }
    
    [Display(Name = "Num. Interior")]
    public string? NumInterior { get; set; }
    
    [Display(Name = "Conjunto")]
    public string? Conjunto { get; set; }
    
    [Display(Name = "Colonia")]
    public string? Colonia { get; set; }
    
    [Display(Name = "Código Postal")]
    public string? CodigoPostal { get; set; }
    
    [Display(Name = "Ciudad")]
    public string? Ciudad { get; set; }
    
    [Display(Name = "Delegación / Municipio")]
    public string? DelegacionMunicipio { get; set; }
    
    [Display(Name = "Estado")]
    public string? Estado { get; set; }
    
    [Display(Name = "Clasificación Zona")]
    public string? ClasifZona { get; set; }
    
    [Display(Name = "Referencia Proxima Urbana")]
    public string? RefProxUrbana { get; set; }
    
    [Display(Name = "Construcciones Predominantes")]
    public string? ConstruccionesPredom { get; set; }
    
    [Display(Name = "Indice de Saturación")]
    public string? IndiceSaturacion { get; set; }
    
    [Display(Name = "Densidad Población")]
    public string? DensidadPoblacion { get; set; }
    
    [Display(Name = "Nivel Socioeconómico")]   
    public string? NivelSocioeconomico { get; set; }
    
    [Display(Name = "Vías de Acceso")]
    public string? ViasAcceso { get; set; }
    
    [Display(Name = "Intensidad de Flujo Vehicular")]
    public string? IntensidadFlujoVehicular { get; set; }
    
    [Display(Name = "Infraestructura Disponible")]
    public string? InfraestructuraDisponible { get; set; }
    [Display(Name = "Servicios Básicos")]
    public string? ServiciosBasicos { get; set; }
    [Display(Name = "Otros Servicios")]
    public string? OtrosServicios { get; set; }

    [Display(Name = "Equipamiento Urbano")]
    public string? EquipamientoUrbano { get; set; }
    
    [Display(Name = "Comentarios del Entorno")]
    public string? ComentariosEntorno { get; set; }

    [Display(Name = "Calles, Lim., y Orientación")]
    public string? CallesLimOrientacion { get; set; }
    
    [Display(Name = "Dimensiones")]
    public string? Dimensiones { get; set; }

    [Display(Name = "Colindancia ")]
    public string? Colindancia { get; set; }

    [Display(Name = "Configuración")]
    public string? Configuracion { get; set; }

    [Display(Name = "Topografía")]
    public string? Topografia { get; set; }

    [Display(Name = "Uso de Suelo")]
    public string? UsoSuelo { get; set; }

    [Display(Name = "Densidad Habitacional")]
    public string? DensidadHabitacional { get; set; }

    [Display(Name = "Ubicación, Lote y Calle")]
    public string? UbicacionLoteCalle { get; set; }

    [Display(Name = "Restricciones ")]
    public string? Restricciones { get; set; }

    [Display(Name = "Giro")]
    public string? Giro { get; set; }

    [Display(Name = "Num. Niveles ")]
    public string? NumNiveles { get; set; }

    [Display(Name = "Superficies Cubiertas")]
    public string? SuperficiesCubiertas { get; set; }

    [Display(Name = "Areas Accesorias")]
    public string? AreasAccesorias { get; set; }

    [Display(Name = "Superficie Vendible")]
    public string? SuperficieVendible { get; set; }
    
    [Display(Name = "Clase General Inmueble ")]
    public string? ClaseGeneralInmueble { get; set; }
    
    [Display(Name = "Estado de Conservación")]
    public string? EstadoConservacion { get; set; }
    
    [Display(Name = "Edad Construcciones")]
    public string? EdadConstrucciones { get; set; }
    
    [Display(Name = "Vida Util Remanente")]
    public string? VidaUtilRemanente { get; set; }
    
    [Display(Name = "Cimentación")]
    public string? Cimentacion { get; set; }
    
    [Display(Name = "Super Estructura")]
    public string? SuperEstructura { get; set; }
    
    [Display(Name = "Muros")]
    public string? Muros { get; set; }
    
    [Display(Name = "Escaleras")]
    public string? Escaleras { get; set; }
    
    [Display(Name = "Losas Entrepisos ")]
    public string? LosasEntrepisos { get; set; }
    
    [Display(Name = "Losas Azoteas")]
    public string? LosasAzoteas { get; set; }
    
    [Display(Name = "Instalaciones Especiales")]
    public string? InstalacionesEspeciales { get; set; }
    
    [Display(Name = "Elementos Accesorio")]
    public string? ElementosAccesorios { get; set; }
    
    [Display(Name = "Obras Complementarias")]
    public string? ObrasComplementarias { get; set; }
    
    [Display(Name = "Pisos")]
    public string? Pisos { get; set; }
    
    [Display(Name = "Muros")]
    public string? Muros2 { get; set; }
    
    [Display(Name = "Plafones")]
    public string? Plafones { get; set; }
    
    [Display(Name = "Instalaciones Hidráulicas")]
    public string? InstalacionesHidraulicas { get; set; }
    
    [Display(Name = "Instalaciones Sanitarias ")]
    public string? InstalacionesSanitarias { get; set; }
    
    [Display(Name = "Instalaciones Eléctricas")]
    public string? InstalacionesElectricas { get; set; }
    
    [Display(Name = "Puertas")]
    public string? Puertas { get; set; }
    
    [Display(Name = "Closets")]
    public string? Closets { get; set; }
    
    [Display(Name = "Muebles Fijos")]
    public string? MueblesFijos { get; set; }
    
    [Display(Name = "Pisos")]
    public string? Pisos2 { get; set; }
    
    [Display(Name = "Ventanas")]
    public string? Ventanas { get; set; }
    
    [Display(Name = "Vidriería")]
    public string? Vidrieria { get; set; }
    
    [Display(Name = "Cerrajería")]
    public string? Cerrajeria { get; set; }
    
    [Display(Name = "Determinación Valor ")]
    public string? DeterminacionValor { get; set; }
    
    [Display(Name = "Comentarios")]
    public string? Comentarios { get; set; }
    
    [Display(Name = "Calificación")]
    public string? Calificacion { get; set; }

    // public EstatusAvaluo? EstatusAvaluo { get; set; }
    [Display(Name = "Archivos Adjuntos")]
    public ICollection<ArchivosAdjuntos>? ArchivosAdjuntos { get; set; }
}