namespace API_CINE.Modelos.DTO
{
    public class PersonaDTO
    {
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Telefono { get; set; }
        public int Ci { get; set; }
        public string Direccion { get; set; } = null!;
    }
}
