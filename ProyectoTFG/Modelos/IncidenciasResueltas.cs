using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTFG.Modelos
{
    public class IncidenciasResueltas
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // Utilizar ObjectId para el id
        public ObjectId Id { get; set; }

        [BsonElement("fechaInicio")]
        public DateTime FechaInicio { get; set; }

        [BsonElement("fechaFin")]
        public DateTime FechaFin { get; set; }

        [BsonElement("urgencia")]
        public string Urgencia { get; set; }

        [BsonElement("prioridad")]
        public string Prioridad { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descripcion")]
        public string Descripcion { get; set; }

        [BsonElement("emailTecnico")]
        public string EmailTecnico { get; set; } // Correo electrónico del usuario relacionado

        [BsonElement("idDispositivo")]
        public string IdDispositivo { get; set; } //Id del dispositivo relaccionado

        [BsonElement("estado")]
        public string Estado { get; set; }

        [BsonElement("tipo")]
        public string TipoDispositivo { get; set; }

        [BsonElement("imagenIncidencia")]
        public byte[] ImagenBinaria { get; set; }

    }
}
