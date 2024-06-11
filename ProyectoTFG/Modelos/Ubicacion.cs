using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTFG.Modelos
{
    public class Ubicacion
    {

        [BsonId]
        [BsonElement("ubicacion")]
        public string NombreUbicacion { get; set; }

    }
}
