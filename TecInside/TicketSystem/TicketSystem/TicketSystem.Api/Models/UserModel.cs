using System;
using TicketSystem.Domain.Users;

namespace TicketSystem.Api.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public long Id { get; set;}
    }

    public static class UserModelExtensions
    {
        public static UserModel ToModel(this User domain)
        {
            return new UserModel
            {
                Id = domain.Id,
                Name = domain.Name,
                Type = domain.Type.GetDescription(),
                TypeId = (int)domain.Type
            };
        }
    }
}