using Calmo.Data.SQLServer;
using System.Collections.Generic;
using TicketSystem.Domain.Repository;
using TicketSystem.Domain.Users;
using TicketSystem.Repository.DTO;
using TicketSystem.Domain.Tickets;

namespace TicketSystem.Repository
{
    public class TicketRepository : Calmo.Data.Repository
    {
        public IEnumerable<Ticket> List (string status)
        {
            var result = this.Data.Db().WithParameters(new { status }).List<TicketDTO>("JUBA_GetTicket");
            return result.ToDomain();   
                
        }
        public IEnumerable<Ticket> ListById(long userid)
        {
            var result = this.Data.Db().WithParameters(new { id_name = userid }).List<TicketDTO>("JUBA_GetTicketbyIDUser");
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
