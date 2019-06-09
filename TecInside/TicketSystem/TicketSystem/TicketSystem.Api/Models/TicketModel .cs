using System;
using System.Collections.Generic;
using TicketSystem.Domain.Tickets;
using TicketSystem.Domain.Users;

namespace TicketSystem.Api.Models
{
    public class TicketModel
    {
        public long Id { get; set; }
        public long IdUser { get; set; }
        public string Problem { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }

        public Ticket ToDomain()
        {
            return new Ticket
            {
                Id = this.Id,
                Name = this.Name,
                IdUser = this.IdUser,
                Status = this.Status,
                Problem = this.Problem,

            };
        }

    }



    public static class TicketModelExtensions
    {
        public static TicketModel ToModel(this Ticket domain)
        {
            return new TicketModel
            {
                Id = domain.Id,
                IdUser = domain.IdUser,
                Problem = domain.Problem,
                Status = domain.Status,
                Name = domain.Name,
            };
        }

        public static IEnumerable<TicketModel> ToModel(this IEnumerable<Ticket> tickets)
        {

            var models = new List<TicketModel>();

            foreach(var ticket in tickets)
                
            {
                models.Add(ticket.ToModel());

            }

            return models;

        }

        
    }
}