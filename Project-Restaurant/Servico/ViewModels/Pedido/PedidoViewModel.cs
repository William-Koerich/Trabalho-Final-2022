﻿using System.ComponentModel.DataAnnotations;

namespace Servico.ViewModels.Pedido
{
    public abstract class PedidoViewModel
    {

        [Display(Name = nameof(Produto))]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} produto")]
        [MaxLength(50, ErrorMessage = "{0} deve conter no máximo {1} produto")]
        public int? Produto { get; set; }

        [Display(Name = "Observacao")]
        [Required(ErrorMessage = "{0} deve ser preenchido")]
        [MinLength(0, ErrorMessage = "{0} deve conter no mínimo {1} texto")]
        [MaxLength(150, ErrorMessage = "{0} deve conter no máximo {1} texto")]
        public string Observacao { get; set; }

        [Display(Name = nameof(Cliente))]
        [Required(ErrorMessage = "{0} deve conter cliente")]
        [MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} cliente")]
        [MaxLength(1, ErrorMessage = "{0} deve conter no máximo {1} cliente")]
        public int? Cliente { get; set; }

        [Display(Name = nameof(Mesa))]
        [Required(ErrorMessage = "{0} deve conter mesa")]
        [MinLength(1, ErrorMessage = "{0} deve conter no mínimo {1} mesa")]
        [MaxLength(1, ErrorMessage = "{0} deve conter no máximo {1} mesa")]
        public int? Mesa { get; set; }
    }
}