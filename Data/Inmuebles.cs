namespace InmobiliariaBlazorApp.Data
{
    public class Inmueble
    {
        public int InmuebleId { get; set; }
        public string Direccion { get; set; }
        public int NumeroHabitaciones { get; set; }
        public int NumeroBaños { get; set; }
        public bool TieneCochera { get; set; }
        public bool TieneAscensor { get; set; }
        public decimal? MetrosCubiertos { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string TipoInmueble { get; set; } // Casa, Departamento
        public string Estado { get; set; } //alquilado, vendido, Disponible, etc
        public decimal? AreaTerreno { get; set; }

        public string Amenidades { get; set; } // Aire acondicionado, piscina, etc

        //Ubicacion
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
       
       //Media
       public ICollection<Imagen> Imagenes { get; set; } = new List<Imagen>();
        public ICollection<Video> Videos { get; set; } = new List<Video>();


        // Clave foránea
        public int PropietarioId { get; set; }
        
        // Propiedad de navegación
        public Usuario Propietario { get; set; }
        
        // Propiedad de navegación para la relación muchos a muchos con usuarios
        public ICollection<UsuarioInmueble> UsuarioInmuebles { get; set; }
        public ICollection<Transaccion> Transacciones { get; set; } = new List<Transaccion>();
        public ICollection<UsuarioFavorito> UsuariosFavoritos { get; set; } = new List<UsuarioFavorito>();
        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();

       
    }
}








        



        