namespace API_CINE.Modelos.DTO
{
    public class UsuarioDTO
    {
        public string Usuario1 { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = null!;
    }
}
