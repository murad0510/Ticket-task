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
    public class AirplaneRepository : IAirplaneRepository
    {
        private TravelDBEntities3 _context;

        public AirplaneRepository()
        {
            _context = new TravelDBEntities3();
        }

        public void AddData(Airplane data)
        {
            _context.Airplanes.Add(data);
            _context.SaveChanges();
        }

        public void DeleteData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Airplane> GetAll()
        {
            var resul = from a in _context.Airplanes
                        select a;

            return new ObservableCollection<Airplane>(resul);
        }

        public Airplane GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Airplane data)
        {
            throw new NotImplementedException();
        }
    }
}
