using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfaceService
{
    public interface IPersonaService
    {
        public Task<bool> InsertPersona(PersonaDTO persona);
        public Task<bool> UpdatePersona(PersonaDTO persona, int id);
        public Task<bool> DeletePersona(int id);
        public Task<List<PersonaDTO>> ListaPersonas();
    }
}
