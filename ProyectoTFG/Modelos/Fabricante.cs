using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTFG.Modelos
{
    public class Fabricante
    {

        [BsonId]
        [BsonElement("fabricante")]
        public string NombreFabricante { get; set; }

    }
}
