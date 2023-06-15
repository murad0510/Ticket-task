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
    public class CityRepository : ICityRepository
    {
        private TravelDBEntities3 _context;

        public CityRepository()
        {
            _context = new TravelDBEntities3();
        }
        public void AddData(City data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAll()
        {
            var result = from c in _context.Cities
                         select c;

            return new ObservableCollection<City>(result);
        }

        public City GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
