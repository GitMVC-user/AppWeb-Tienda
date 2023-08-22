using System.ComponentModel.DataAnnotations;

namespace AppWeb_Tienda.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }

        [Display(Name = "Fecha de la orden:")]
        [Required]
        [StringLength(50)]
        public DateTime FechaOrden { get; set; }
        public decimal Total { get; set;
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
/*
public int CursoID { get; set; }
[Display(Name = "Título del curso:")]
[Required]
[StringLength(50)]
public string Titulo { get; set; }
[Display(Name = "Número de Creditos")]
[Required]
public int Credito { get; set; }
[Display(Name = "Ciclo Académico")]
[Required]
public int Ciclo { get; set; }*/
