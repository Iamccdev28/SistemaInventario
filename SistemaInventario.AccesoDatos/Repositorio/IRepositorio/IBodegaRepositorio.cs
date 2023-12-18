﻿using SistemaInventario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public interface IBodegaRepositorio : IRepositorio<Bodega>
    {

        void Actualizar(Bodega bodega);
    }
}
