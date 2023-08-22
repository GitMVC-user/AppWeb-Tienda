using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AppWeb_Tienda.Models
{
    public class DetallePedido
    {
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
        [Display(Name = "Subtotal:")]
        [Required]
        [StringLength(50)]
        public float SubTotal { get; set; }
      
    }
}
