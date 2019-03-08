using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ProductManagement.Models
{
    public class ProdutoViewModel
    {
        public Int32 ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Produto")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "A quantidade do produto é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade do Produto")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
        [Display(Name = "Preço")]
        public Decimal Preco { get; set; }
    
    }
}