using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEvento(int Evento,Evento eventoId);
        Task<bool> DeleteEvento(int eventoId);

        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false); // esse bool seria para incluir os palestrantes que estão referenciadas na tabela de eventos
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);

    }
}
