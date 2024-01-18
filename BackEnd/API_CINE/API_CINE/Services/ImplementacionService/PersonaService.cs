using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionService
{
    public class PersonaService : IPersonaService
    {
        CineContext cinebdContext;

        public PersonaService(CineContext _cinebdContext)
        {
            cinebdContext = _cinebdContext;
        }
        public Task<bool> DeletePersona(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertPersona(PersonaDTO persona)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PersonaDTO>> ListaPersonas()
        {
            var resultado = await cinebdContext.Personas.Select(x => new PersonaDTO
            {
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Telefono = x.Telefono,
                Ci = x.Ci,
                Direccion = x.Direccion
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdatePersona(PersonaDTO persona, int id)
        {
            throw new NotImplementedException();
        }
    }
}
