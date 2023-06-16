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
    public class PilotRepository : IPilotRepository
    {
        private TravelDBEntities7 _context;

        public PilotRepository()
        {
            _context = new TravelDBEntities7();
        }

        public void AddData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Pilot> GetAll()
        {
            var result = from p in _context.Pilots
                         select p;

            return new ObservableCollection<Pilot>(result);
        }

        public Pilot GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Pilot data)
        {
            throw new NotImplementedException();
        }
    }
}
