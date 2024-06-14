using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTFG.Modelos
{
    public class Usuario
    {

        // El atributo BsonId indica que esta propiedad será la clave primaria en MongoDB.
        [BsonId]
        // El atributo BsonElement permite mapear la propiedad a un campo específico en MongoDB.
        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("rol")]
        public string Rol { get; set; }

        [BsonElement("tema")]
        public string Tema { get; set; } // Nueva propiedad para el tema

        [BsonElement("tamFuente")]
        public double TamFuente { get; set; } // Nueva propiedad para el tamaño de fuente


        [BsonElement("imagenPerfil")]
        public byte[] ImagenPerfil { get; set; } // Nueva propiedad para la URL de la imagen

        [BsonElement("contador")]
        public int ContadorNuevasInci { get; set; }

        [BsonElement("filasAntes")]
        public int FilasAntes { get; set; }

        [BsonElement("filasActuales")]
        public int FilasActuales { get; set; }


        [BsonElement("idsActuales")]
        public List<string> IdsActuales { get; set; }

        [BsonElement("idsAntes")]
        public List<string> IdsAntes { get; set; }

    }
}
