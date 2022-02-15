﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Tarea3Movil.Models
{
    public class datosEmpleados
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }

        public Int32 edad { get; set; }

        [MaxLength(100)]
        public string correo { get; set; }

        [MaxLength(100)]
        public string direccion { get; set; }

    }
}
