using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Domain.Repository;

namespace TicketSystem.Domain.Tickets
{
    public class Ticket
    {

        public long Id { get; set; }
        public long IdUser { get; set; }
        public string Problem { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }

        public ITicketRepository Repository { get; set; }

        public void Add()
        {
            if (Repository == null)
                throw new ArgumentNullException("Sem Repositório no Dominio.");

            Repository.Add(this);
        }

        public void Update()
        {
            if (Repository == null)
                throw new ArgumentNullException("Repositorio de contato nao referenciado.");

            Repository.Update(this);
        }


    }
}
