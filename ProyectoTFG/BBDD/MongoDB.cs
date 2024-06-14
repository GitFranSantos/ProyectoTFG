using MongoDB.Driver;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTFG.Modelos;
using MongoDB.Bson;
using System.Text.RegularExpressions;
using ProyectoTFG.Vistas;
using Microsoft.Extensions.Configuration;
using Microsoft.Maui.ApplicationModel.Communication;

namespace ProyectoTFG.BBDD
{
    public class MongoDB
    {
        private readonly string _connectionString = "mongodb+srv://fjsantosestudios:XI04Z055YlOuuxq5@pruebatfg.cqagqcu.mongodb.net/?retryWrites=true&w=majority&appName=PruebaTFG";
        private readonly string _databaseName = "Proytecto";
        private IMongoDatabase _database;
        public MongoDB()
        {
            Conexion();
        }
        //Conexion a la bdd
        public void Conexion()
        {
            if (_database == null)
            {
                var client = new MongoClient(_connectionString);
                var settings = MongoClientSettings.FromConnectionString(_connectionString);
                //var client = new MongoClient(settings);
                _database = client.GetDatabase(_databaseName);
                settings.WaitQueueSize = 500;
                
            }
        }
        // obtener la colección de usuarios
        private IMongoCollection<Usuario> ObtenerColeccionUsuarios()
        {
            return _database.GetCollection<Usuario>("Usuarios");
        }
        // obtener la colección de incidencias
        private IMongoCollection<Incidencia> ObtenerColeccionIncidencias()
        {
            return _database.GetCollection<Incidencia>("Incidencias");
        }
        // obtener la colección de dispositivos
        private IMongoCollection<Dispositivo> ObtenerColeccionDispositivos()
        {
            return _database.GetCollection<Dispositivo>("Dispositivos");
        }
        // obtener la colección de fabricantes
        private IMongoCollection<Fabricante> ObtenerColeccionFabs()
        {
            return _database.GetCollection<Fabricante>("Fabricantes");
        }
        // obtener la colección de ubicacion
        private IMongoCollection<Ubicacion> ObtenerColeccionUbi()
        {
            return _database.GetCollection<Ubicacion>("Ubicaciones");
        }
        // obtener la colección de tipos
        private IMongoCollection<TipoDispositivo> ObtenerColeccionTipos()
        {
            return _database.GetCollection<TipoDispositivo>("Tipos");
        }

        // obtener la colección de incidencias resueltas
        private IMongoCollection<IncidenciasResueltas> ObtenerColeccionInciResueltas()
        {
            return _database.GetCollection<IncidenciasResueltas>("IncidenciasResueltas");
        }
        //insertar incidencia resueltas
        public async Task InsertarIncidenciaResuelta(IncidenciasResueltas nueva)
        {
            var coleccion = ObtenerColeccionInciResueltas();

            await coleccion.InsertOneAsync(nueva);
        }
        //insertar usuario
        public async Task InsertarUsuario(Usuario usuario)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();

            // Hashear la contraseña antes de guardarla
            usuario.Password = BCrypt.Net.BCrypt.HashPassword(usuario.Password);

            await coleccionUsuarios.InsertOneAsync(usuario);
        }
        //insertar incidencia
        public async Task InsertarIncidencia(Incidencia incidencia)
        {
            var coleccionIncidencias = ObtenerColeccionIncidencias();

            await coleccionIncidencias.InsertOneAsync(incidencia);
        }
        //insertar dispositivo
        public async Task InsertarDispositivo(Dispositivo dispositivo)
        {
            var coleccionIncidencias = ObtenerColeccionDispositivos();

            await coleccionIncidencias.InsertOneAsync(dispositivo);
        }
        //insertar fabricante
        public async Task InsertarFab(Fabricante fab)
        {
            var coleccionFabs = ObtenerColeccionFabs();

            await coleccionFabs.InsertOneAsync(fab);
        }
        //insertar ubicacion
        public async Task InsertarUbi(Ubicacion ubi)
        {
            var coleccionUbi = ObtenerColeccionUbi();

            await coleccionUbi.InsertOneAsync(ubi);
        }
        //insertar tipo
        public async Task InsertarTipo(TipoDispositivo tipo)
        {
            var coleccionTipos = ObtenerColeccionTipos();

            await coleccionTipos.InsertOneAsync(tipo);
        }
        

        
        
        //obtener lista de tipos string
        public async Task<List<string>> ObtenerListaTiposString()
        {
            var coleccionTipos = ObtenerColeccionTipos();
            var filter = Builders<TipoDispositivo>.Filter.Empty; // Filtro vacío para seleccionar todos los documentos
            var projection = Builders<TipoDispositivo>.Projection.Include("_id"); // Proyección para incluir solo la propiedad "email"

            var tiposExistentes = await coleccionTipos.Find(filter).Project(projection).ToListAsync();

            return tiposExistentes.Select(doc => doc["_id"].AsString).ToList();
        }
        //obtener lista de ubicaciones string
        public async Task<List<string>> ObtenerListaUbiString()
        {
            var coleccion = ObtenerColeccionUbi();
            var filter = Builders<Ubicacion>.Filter.Empty; // Filtro vacío para seleccionar todos los documentos
            var projection = Builders<Ubicacion>.Projection.Include("_id"); // Proyección para incluir solo la propiedad "email"

            var ubiExistentes = await coleccion.Find(filter).Project(projection).ToListAsync();

            return ubiExistentes.Select(doc => doc["_id"].AsString).ToList();
        }
        //obtener lista de fabricantes string
        public async Task<List<string>> ObtenerListaFabString()
        {
            var coleccion = ObtenerColeccionFabs();
            var filter = Builders<Fabricante>.Filter.Empty; // Filtro vacío para seleccionar todos los documentos
            var projection = Builders<Fabricante>.Projection.Include("_id"); // Proyección para incluir solo la propiedad "email"

            var fabExistentes = await coleccion.Find(filter).Project(projection).ToListAsync();

            return fabExistentes.Select(doc => doc["_id"].AsString).ToList();
        }
        // obtener todos lista usuarios
        public async Task<List<Usuario>> ObtenerListaUsuarios()
        {
           return await ObtenerColeccionUsuarios().Find(_ => true).ToListAsync();
        }
        //obtener lista de dispositivos
        public async Task<List<Dispositivo>> ObtenerListaDispositivos()
        {
            return await ObtenerColeccionDispositivos().Find(_ => true).ToListAsync();
        }
        //obtener lista de incidencias
        public async Task<List<Incidencia>> ObtenerListaIncidencias()
        {
            return await ObtenerColeccionIncidencias().Find(_ => true).ToListAsync();
        }
        //obtener una lista de fabs
        public async Task<List<Fabricante>> ObtenerListaFabs()
        {
            return await ObtenerColeccionFabs().Find(_ => true).ToListAsync();
        }
        //obtener una lista de fabs
        public async Task<List<Ubicacion>> ObtenerListaUbi()
        {
            return await ObtenerColeccionUbi().Find(_ => true).ToListAsync();
        }
        //obtener una lista de tipos
        public async Task<List<TipoDispositivo>> ObtenerListaTipos()
        {
            return await ObtenerColeccionTipos().Find(_ => true).ToListAsync();
        }
        //obtener lista de emails
        public async Task<List<string>> ObtenerListaEmails()
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filter = Builders<Usuario>.Filter.Empty; // Filtro vacío para seleccionar todos los documentos
            var projection = Builders<Usuario>.Projection.Include("_id"); // Proyección para incluir solo la propiedad "email"

            var emailsExistentes = await coleccionUsuarios.Find(filter).Project(projection).ToListAsync();

            return emailsExistentes.Select(doc => doc["_id"].AsString).ToList();
        }
        //obtener el rol del usuario
        public async Task<string> ObtenerRolUsuario(string email)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();

            var filtro = Builders<Usuario>.Filter.Eq("_id", email);

            // Proyección para devolver solo el campo "rol"
            var proyeccion = Builders<Usuario>.Projection.Include("rol").Exclude("_id");

            var documento = await coleccionUsuarios.Find(filtro).Project(proyeccion).FirstOrDefaultAsync();

            if (documento != null && documento.Contains("rol"))
            {
                return documento["rol"].AsString;
            }

            return null; // O lanza una excepción si prefieres manejarlo así
        }
        

        //obtener una incidencia por su id
        public async Task<Incidencia> ObtenerIncidencia(string id)
        {
            var coleccion = ObtenerColeccionIncidencias();
            var filtro = Builders<Incidencia>.Filter.Eq(u => u.Id, id);
            var incidencia = await coleccion.Find(filtro).FirstOrDefaultAsync();

            if (incidencia != null)
            {
                return incidencia;
            }
            else
            {
                // Manejar el caso en que el usuario no exista
                return null;
            }
        }
        //obtener dispositivo por su id
        public async Task<Dispositivo> ObtenerDispositivo(string id)
        {
            var coleccion = ObtenerColeccionDispositivos();
            var filtro = Builders<Dispositivo>.Filter.Eq(u => u.Id, id);
            var dispositivo = await coleccion.Find(filtro).FirstOrDefaultAsync();

            if (dispositivo != null)
            {
                return dispositivo;
            }
            else
            {
                // Manejar el caso en que el usuario no exista
                return null;
            }
        }
        //obtener usuarios filtrados
        public async Task<List<Usuario>> ObtenerUsuariosFiltrados(string textoBusqueda)
        {
            var filtro = Builders<Usuario>.Filter.Regex(u => u.Email, new BsonRegularExpression("^" + textoBusqueda, "i"));
            return await ObtenerColeccionUsuarios().Find(filtro).ToListAsync();
        }
        //obtener dispositivos filtrados
        public async Task<List<Dispositivo>> ObtenerDispositivosFiltrados(string textoBusqueda)
        {
            var filtro = Builders<Dispositivo>.Filter.Regex(u => u.Tipo, new BsonRegularExpression("^" + textoBusqueda, "i"));
            return await ObtenerColeccionDispositivos().Find(filtro).ToListAsync();
        }

        //obtener tamFuente del usuario
        public async Task<double> ObtenerTamFuente(string email)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccion.Find(filtro).FirstOrDefaultAsync();

            if (usuario != null)
            {
                return usuario.TamFuente;
            }
            else
            {
                // Manejar el caso en que el usuario no exista
                return 0;
            }
        }
        //obtener el tema del usuario
        public async Task<string> ObtenerTema(string email)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccion.Find(filtro).FirstOrDefaultAsync();

            if (usuario != null)
            {
                return usuario.Tema;
            }
            else
            {
                // Manejar el caso en que el usuario no exista
                return null;
            }
        }

        //Obtener imagen del usuario
        public async Task<byte[]> ObtenerImagenPerfil(string email)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);

            // Buscar el documento del usuario que coincide con el filtro
            var usuario = await coleccion.Find(filtro).FirstOrDefaultAsync();

            // Verificar si se encontró el usuario y retornar la imagen guardada
            return usuario?.ImagenPerfil;
        }
        //actualizar incidencia
        public async Task ActualizarIncidencia(string id, string nuevoEstado)
        {
            var coleccion = ObtenerColeccionIncidencias();
            var filtro = Builders<Incidencia>.Filter.Eq(u => u.Id, id);

            // Crear la actualización para los campos de configuración
            var actualizacion = Builders<Incidencia>.Update
                .Set(u => u.Estado, nuevoEstado);

            // Realizar la actualización en la base de datos
            await coleccion.UpdateOneAsync(filtro, actualizacion);
        }
        //actualizar incidencia fecha fin
        public async Task ActualizarIncidenciaFin(string id, DateTime fechaFin)
        {
            var coleccion = ObtenerColeccionIncidencias();
            var filtro = Builders<Incidencia>.Filter.Eq(u => u.Id, id);

            // Crear la actualización para los campos de configuración
            var actualizacion = Builders<Incidencia>.Update
                .Set(u => u.FechaFin, fechaFin);

            // Realizar la actualización en la base de datos
            await coleccion.UpdateOneAsync(filtro, actualizacion);
        }
        //actualizar contraseña usuario
        public async Task<bool> ActualizarContraseñaUsuario(string email, string nuevaContraseña)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);

            // Hashear la nueva contraseña antes de actualizarla
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(nuevaContraseña);

            var actualizacion = Builders<Usuario>.Update.Set(u => u.Password, hashedPassword);
            var resultado = await coleccion.UpdateOneAsync(filtro, actualizacion);

            return resultado.ModifiedCount > 0;
        }
        //actualizar configuracion usuario
        public async Task ActualizarConfiguracionUsuario(string email, string nuevoTema, double nuevoTamLetra)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);

            // Crear la actualización para los campos de configuración
            var actualizacion = Builders<Usuario>.Update
                .Set(u => u.Tema, nuevoTema)
                .Set(u => u.TamFuente, nuevoTamLetra);

            // Realizar la actualización en la base de datos
            await coleccion.UpdateOneAsync(filtro, actualizacion);
        }
        //actualizar tecnico incidencia
        public async Task AsignarTecnico(string id, string tecnico)
        {
            var coleccion = ObtenerColeccionIncidencias();
            var filtro = Builders<Incidencia>.Filter.Eq(u => u.Id, id);

            // Crear la actualización para los campos de configuración
            var actualizacion = Builders<Incidencia>.Update
                .Set(u => u.EmailTecnico, tecnico);

            // Realizar la actualización en la base de datos
            await coleccion.UpdateOneAsync(filtro, actualizacion);
        }

        //comprobar si existe el tipo
        public async Task<bool> ExisteTipo(string nuevoTipo)
        {
            if (string.IsNullOrWhiteSpace(nuevoTipo))
            {
                throw new ArgumentNullException(nameof(nuevoTipo), "El correo electrónico no puede ser nulo o vacío.");
            }

            var listaTipos = await ObtenerListaTiposString();
            return listaTipos.Contains(nuevoTipo);
        }
        //comprobar si existe ubicacion
        public async Task<bool> ExisteUbi(string nuevaUbi)
        {
            if (string.IsNullOrWhiteSpace(nuevaUbi))
            {
                throw new ArgumentNullException(nameof(nuevaUbi), "El correo electrónico no puede ser nulo o vacío.");
            }

            var listaTipos = await ObtenerListaTiposString();
            return listaTipos.Contains(nuevaUbi);
        }
        //comprobar si existe el fabricante
        public async Task<bool> ExisteFab(string nuevoFab)
        {
            if (string.IsNullOrWhiteSpace(nuevoFab))
            {
                throw new ArgumentNullException(nameof(nuevoFab), "El correo electrónico no puede ser nulo o vacío.");
            }

            var listaTipos = await ObtenerListaTiposString();
            return listaTipos.Contains(nuevoFab);
        }

        //comprobar contraseña con usuario
        public async Task<bool> ComprobarPassUsuario(string email, string pass)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccion.Find(filtro).FirstOrDefaultAsync();

            if (usuario != null && pass != null)
            {
                // Verificar la contraseña usando BCrypt
                return BCrypt.Net.BCrypt.Verify(pass, usuario.Password);
            }
            else
            {
                return false;
            }
        }
        //comprobar si existe el email
        public async Task<bool> ExisteEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(nameof(email), "El correo electrónico no puede ser nulo o vacío.");
            }

            var listaCorreos = await ObtenerListaEmails(); 
            return listaCorreos.Contains(email);
        }
        //validar el formato del email
        public async Task<bool> EmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Expresión regular para validar el formato del correo electrónico y el dominio
                var emailPattern = @"^[^@\s]+@(educastillalamancha|a|"")\.(com|es|net|"")$";
                return Regex.IsMatch(email, emailPattern);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        //eliminar incidencia
        public async Task<bool> EliminarIncidencia(string id)
        {
            var coleccionIncidencias = ObtenerColeccionIncidencias();
            var filtro = Builders<Incidencia>.Filter.Eq("Id", ObjectId.Parse(id));
            var resultado = await coleccionIncidencias.DeleteOneAsync(filtro);
            return resultado.DeletedCount > 0;
        }
        //eliminiar usuario
        public async Task<bool> EliminarUsuario(string email)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var resultado = await coleccionUsuarios.DeleteOneAsync(filtro);
            return resultado.DeletedCount > 0;
        }
        //eliminiar dispositivo
        public async Task<bool> EliminarDispositivo(string id)
        {
            var coleccion = ObtenerColeccionDispositivos();
            var filtro = Builders<Dispositivo>.Filter.Eq(u => u.Id, id);
            var resultado = await coleccion.DeleteOneAsync(filtro);
            return resultado.DeletedCount > 0;
        }
        //guardar imagen perfil
        public async Task<bool> GuardarImagen(string email, byte[] imagenBytes)
        {
            var coleccion = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);

            var actualizacion = Builders<Usuario>.Update.Set(u => u.ImagenPerfil, imagenBytes);
            var resultado = await coleccion.UpdateOneAsync(filtro, actualizacion);

            return resultado.ModifiedCount > 0;
        }
        //guardar imagen incidencia binaria
        public async Task<bool> GuardarImagenBinaria(string id, byte[] imagenBytes)
        {
            var coleccion = ObtenerColeccionIncidencias();
            var filtro = Builders<Incidencia>.Filter.Eq(u => u.Id, id);

            var actualizacion = Builders<Incidencia>.Update.Set(u => u.ImagenBinaria, imagenBytes);
            var resultado = await coleccion.UpdateOneAsync(filtro, actualizacion);

            return resultado.ModifiedCount > 0;
        }
        //ordenar listas incidencias
        public async Task<List<Incidencia>> OrdenarFechaDesc(List<Incidencia> incidencias)
        {
            return incidencias.OrderByDescending(incidencia => incidencia.FechaInicio).ToList();
        }

        public async Task<List<Incidencia>> OrdenarFechaAsc(List<Incidencia> incidencias)
        {
            return incidencias.OrderBy(incidencia => incidencia.FechaInicio).ToList();
        }

        public async Task<List<Incidencia>> OrdenarTipoDesc(List<Incidencia> incidencias)
        {
            return incidencias.OrderByDescending(incidencia => incidencia.TipoDispositivo).ToList();
        }

        public async Task<List<Incidencia>> OrdenarTipoAsc(List<Incidencia> incidencias)
        {
            return incidencias.OrderBy(incidencia => incidencia.TipoDispositivo).ToList();
        }

        public async Task<List<Incidencia>> OrdenarUrgenciaDesc(List<Incidencia> incidencias)
        {
            return incidencias.OrderByDescending(incidencia => incidencia.Urgencia).ToList();
        }

        public async Task<List<Incidencia>> OrdenarUrgenciaAsc(List<Incidencia> incidencias)
        {
            return incidencias.OrderBy(incidencia => incidencia.Urgencia).ToList();
        }

        public async Task<List<Incidencia>> OrdenarEstadoDesc(List<Incidencia> incidencias)
        {
            return incidencias.OrderByDescending(incidencia => incidencia.Estado).ToList();
        }

        public async Task<List<Incidencia>> OrdenarEstadoAsc(List<Incidencia> incidencias)
        {
            return incidencias.OrderBy(incidencia => incidencia.Estado).ToList();
        }
        
        //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
        public async Task<int?> ObtenerFilasActuales(string email)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccionUsuarios.Find(filtro).FirstOrDefaultAsync();

            if (usuario != null)
            {
                return usuario.FilasActuales;
            }
            else
            {
                return null;
            }
        }

        public async Task<int?> ObtenerFilasAntes(string email)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccionUsuarios.Find(filtro).FirstOrDefaultAsync();

            if (usuario != null)
            {
                return usuario.FilasAntes;
            }
            else
            {
                return null;
            }
        }

        public async Task ActualizarFilasActuales(string email, int filasAntesSalir)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var update = Builders<Usuario>.Update.Set(u => u.FilasActuales, filasAntesSalir);
            await coleccionUsuarios.UpdateOneAsync(filtro, update);
        }

        public async Task ActualizarFilasAntes(string email, int filasAlEntrar)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var update = Builders<Usuario>.Update.Set(u => u.FilasAntes, filasAlEntrar);
            await coleccionUsuarios.UpdateOneAsync(filtro, update);
        }

        public async Task ActualizarTodosFilasAntes(int filasAlEntrar)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var update = Builders<Usuario>.Update.Set(u => u.FilasAntes, filasAlEntrar);
            await coleccionUsuarios.UpdateManyAsync(Builders<Usuario>.Filter.Empty, update);
        }

        public async Task ActualizarIdsIncidenciasActuales(string email, List<string> idsActuales)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var update = Builders<Usuario>.Update.Set(u => u.IdsActuales, idsActuales);
            await coleccionUsuarios.UpdateOneAsync(filtro, update);
        }

        public async Task ActualizarIdsIncidenciasAntes(string email, List<string> idsAntes)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var update = Builders<Usuario>.Update.Set(u => u.IdsAntes, idsAntes);
            await coleccionUsuarios.UpdateOneAsync(filtro, update);
        }

        public async Task<List<string>> ObtenerIdsIncidenciasActuales(string email)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccionUsuarios.Find(filtro).FirstOrDefaultAsync();
            return usuario?.IdsActuales ?? new List<string>();
        }

        public async Task<List<string>> ObtenerIdsIncidenciasAntes(string email)
        {
            var coleccionUsuarios = ObtenerColeccionUsuarios();
            var filtro = Builders<Usuario>.Filter.Eq(u => u.Email, email);
            var usuario = await coleccionUsuarios.Find(filtro).FirstOrDefaultAsync();
            return usuario?.IdsAntes ?? new List<string>();
        }

    }
}
