namespace InmobiliariaBlazorApp.Data
{
    public class UsuarioFavorito
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int InmuebleId { get; set; }
        public Inmueble Inmueble { get; set; }
    }
}
