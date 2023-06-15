using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_task.DataAccess.Abstractions;
using Ticket_task.DataAccess.SqlServer;

namespace Ticket_task.DataAccess.Concrete
{
    public class TicketRepository : ITicketRepository
    {
        private TravelDBEntities3 _context;

        public TicketRepository()
        {
            _context = new TravelDBEntities3();
        }

        public void AddData(Ticket data)
        {
            _context.Tickets.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Ticket> GetAll()
        {
            var result = from t in _context.Tickets
                         select t;

            return new ObservableCollection<Ticket>(result);
        }

        public Ticket GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
