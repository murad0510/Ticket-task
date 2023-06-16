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
    public class FlightTypeRepository : IFlightTypeRepository
    {
        private TravelDBEntities6 _context;

        public FlightTypeRepository()
        {
            _context = new TravelDBEntities6();
        }

        public void AddData(FlightType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(FlightType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<FlightType> GetAll()
        {
            var result = from f in _context.FlightTypes
                         select f;

            return new ObservableCollection<FlightType>(result);
        }

        public FlightType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(FlightType data)
        {
            throw new NotImplementedException();
        }
    }
}
