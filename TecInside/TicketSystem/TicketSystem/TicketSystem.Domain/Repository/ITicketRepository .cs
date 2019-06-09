using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Domain.Tickets;

namespace TicketSystem.Domain.Repository
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> List(string Status);
        IEnumerable<Ticket> ListById(long IdUser);
        void Add(Ticket ticket);
        void Update(Ticket ticket);
    }
}
