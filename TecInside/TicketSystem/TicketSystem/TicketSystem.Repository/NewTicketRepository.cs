using Calmo.Data.SQLServer;
using System.Collections.Generic;
using TicketSystem.Domain.Repository;
using TicketSystem.Domain.Users;
using TicketSystem.Repository.DTO;
using TicketSystem.Domain.Tickets;

namespace TicketSystem.Repository
{
    public class NewTicketRepository : Calmo.Data.Repository, ITicketRepository 
    {
        public IEnumerable<Ticket> List (string IdUser)
        {
            var result = this.Data.Db().WithParameters(new { IdUser }).List<TicketDTO>("JUBA_GetTicket");
            return result.ToDomain();
                
        }
        public void Add(Ticket ticket)
        {
            var parameters = new
            {
                Id_user = ticket.IdUser,
                problem = ticket.Problem,
                status = ticket.Status
            };
            this.Data.Db().WithParameters(parameters).Execute("JUBA_NewTicket");
        }

        public IEnumerable<Ticket> ListById(long IdUser)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Ticket ticket)
        {
            var parameters = new
            {
                Id = ticket.Id,
                status = ticket.Status
            };

            this.Data.Db().WithParameters(parameters).Execute("JUBA_UpdateTicket");
        }
    }
}
