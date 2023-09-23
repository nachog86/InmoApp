namespace InmobiliariaBlazorApp.Data
{
    public class Transaccion
    {
        public int TransaccionId { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Monto { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int InmuebleId { get; set; }
        public Inmueble Inmueble { get; set; }
    }
}
