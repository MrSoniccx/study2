using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa.Model
{
    [Table("Pasajeros")]
    public class Pasajero
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
    }
}
