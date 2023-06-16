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
        private TravelDBEntities6 _context;

        public TicketRepository()
        {
            _context = new TravelDBEntities6();
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
                         //.Include(nameof(Ticket.Airplane))
                         //.Include(nameof(Ticket.FlightType))
                         select t;

            return new ObservableCollection<Ticket>(result);
        }

        public Ticket GetData(int id)
        {
            var airplanes = GetAll();
            var airplane = airplanes.FirstOrDefault(c => c.Id == id);

            return airplane;
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
