using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_task.DataAccess.Abstractions;
using Ticket_task.DataAccess.SqlServer;

namespace Ticket_task.DataAccess.Concrete
{
    public class TicketRepository : ITicketRepository
    {
        private TravelDBEntities7 _context;

        public TicketRepository()
        {   
            _context = new TravelDBEntities7();
        }

        public void AddData(Ticket data)
        {
            _context.Entry(data).State = EntityState.Added;
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
