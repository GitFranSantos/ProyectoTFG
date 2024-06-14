using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTFG.Modelos
{
    public class Dispositivo
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ubicacion")]
        public string Ubicacion { get; set; }

        [BsonElement("estado")]
        public string Estado { get; set; }

        [BsonElement("tipo")]
        public string Tipo { get; set; }

        [BsonElement("fabricante")]
        public string Fabricante { get; set; }

        [BsonElement("modelo")]
        public string Modelo { get; set; }

        [BsonElement("comentarios")]
        public string Comentarios { get; set; }

    }
}
