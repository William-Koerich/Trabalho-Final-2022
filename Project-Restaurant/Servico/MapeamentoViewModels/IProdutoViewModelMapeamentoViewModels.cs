﻿using Repositorio.Entidades;
using Servico.ViewModels.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.MapeamentoViewModels
{
    public interface IProdutoViewModelMapeamentoViewModels
    {
        ProdutoEditarViewModel ConstruirCom(Produto produto);
    }
}
