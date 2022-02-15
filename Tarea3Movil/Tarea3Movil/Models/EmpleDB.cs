using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Tarea3Movil.Models;
using System.Threading.Tasks;


namespace Tarea3Movil.Models
{
    public class EmpleDB
    {
        readonly SQLiteAsyncConnection db;

        public EmpleDB()
        {
        }

        public EmpleDB(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);
            db.CreateTableAsync<datosEmpleados>();

        }

        public Task<List<datosEmpleados>> listaempleados()
        {

            return db.Table<datosEmpleados>().ToListAsync();
        }

        public Task<datosEmpleados> ObtenerEmpleado(Int32 pcodigo)
        {
            return db.Table<datosEmpleados>().Where(i => i.codigo == pcodigo).FirstOrDefaultAsync();
        }

        public Task<Int32> EmpleadoGuardar(datosEmpleados emple)
        {
            if (emple.codigo != 0)
            {
                return db.UpdateAsync(emple);
            }
            else
            {
                return db.InsertAsync(emple);
            }
        }

        public Task<Int32> EmpleadoBorrar(datosEmpleados emple)
        {
            return db.DeleteAsync(emple);
        }

    }
}
