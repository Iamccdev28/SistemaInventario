using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class BodegaRepositorio : Repositorio<Bodega>, IBodegaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public BodegaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Actualizar(Bodega bodega)
        {
            var bodegaBd = _db.Bodegas.FirstOrDefault(b => b.Id == bodega.Id);
            if (bodegaBd != null)
            {

                bodega.Nombre = bodegaBd.Nombre;
                bodega.Descripcion = bodegaBd.Descripcion;  
                bodega.Estado = bodegaBd.Estado;            
                _db.SaveChanges();
        }
    }
}
