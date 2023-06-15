using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_task.DataAccess.Abstractions;
using Ticket_task.DataAccess.Concrete;
using Ticket_task.DataAccess.SqlServer;

namespace Ticket_task.Domain.Services
{
    public class TicketService
    {
        private IRepository<Ticket> _repository;

        public TicketService()
        {
            _repository = new TicketRepository();
        }

        public ObservableCollection<Ticket> GetTickets()
        {
            return _repository.GetAll();
        }

        public void AddTicket(Ticket ticket)
        {
            _repository.AddData(ticket);
        }

        public Ticket GetTicket(int id)
        {
            return _repository.GetData(id);
        }
    }
}
