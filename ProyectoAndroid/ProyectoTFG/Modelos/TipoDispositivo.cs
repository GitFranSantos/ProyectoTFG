using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTFG.Modelos
{
    public class TipoDispositivo
    {

        [BsonId]
        [BsonElement("tipo")]
        public string TiposDisp { get; set; }

    }
}
