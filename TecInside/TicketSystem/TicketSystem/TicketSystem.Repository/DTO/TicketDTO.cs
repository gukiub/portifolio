using System.Collections.Generic;
using System.Linq;
using TicketSystem.Domain.Tickets;
using TicketSystem.Domain.Users;

namespace TicketSystem.Repository.DTO
{
    public class TicketDTO
    {
        public long Id { get; set; }
        public long Id_User { get; set; }
        public string name { get; set; }
        public string Status { get; set; }
        public string Problem { get; set; }
        

        public Ticket ToDomain()
        {
            return new Ticket
            {
                Id = this.Id,
                Name = this.name,
                IdUser = this.Id_User,
                Status = this.Status,
                Problem = this.Problem,
                
            };
        }
    }

    public static class TicketDTOExtensions
    {
        public static IEnumerable<Ticket> ToDomain(this IEnumerable<TicketDTO> dtos)
        {
            return dtos.Select(d => d.ToDomain());
        }
    }
}
