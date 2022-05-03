using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //PALESTRANTE
        Task<Palestrante[]> GetAllPalestranteByNomeAsync(string nome, bool includeEventos); // esse bool seria para incluir os palestrantes que estão referenciadas na tabela de eventos
        Task<Palestrante[]> GetAllEPalestranteAsync( bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos);
    }
}
