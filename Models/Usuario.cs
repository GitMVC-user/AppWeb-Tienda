using System.ComponentModel.DataAnnotations;

namespace AppWeb_Tienda.Models
{
    public class Usuario
    { 
        public int UsuarioID { get; set; }

        public int PedidoID { get; set; }
        public int ProductoID { get; set; }
        [Display(Name = "Cantidad:")]
        [Required]
        [StringLength(50)]
        public int Cantidad { get; set; }
        [Display(Name = "Fecha de la orden:")]
        [Required]
        [StringLength(50)]
        public float PrecioUnidad { get; set; }
        [Display(Name = "Fecha de la orden:")]
        [Required]
        [StringLength(50)]
        public float SubTotal { get; set; }

    }
}
