using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        //EVENTOS
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false); // esse bool seria para incluir os palestrantes que estão referenciadas na tabela de eventos
        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes = false); 
        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}
