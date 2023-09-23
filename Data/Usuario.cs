namespace InmobiliariaBlazorApp.Data
{
   public class Usuario
{
    public int UsuarioId { get; set; }
    public string Auth0UserId { get; set; } // Almacenar el identificador de usuario de Auth0
    public string Nombre { get; set; }
    public string Email { get; set; }
    public string Rol { get; set; } // Propietario, Consumidor, Comercial, Admin
    
    // Propiedades de navegación
    public ICollection<Inmueble> InmueblesPropios { get; set; }
    public ICollection<UsuarioInmueble> UsuarioInmuebles { get; set; }
}
    }


