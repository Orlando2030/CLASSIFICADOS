using BUSINESS.Models;
using System.ComponentModel.DataAnnotations;

namespace APP.ViewModels
{
    public class PedidoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public IEnumerable<Anuncio> Anuncio { get; set; }
    }
}
