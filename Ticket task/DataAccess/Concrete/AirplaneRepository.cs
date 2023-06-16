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
    public class AirplaneRepository : IAirplaneRepository
    {
        private TravelDBEntities6 _context;

        public AirplaneRepository()
        {
            _context = new TravelDBEntities6();
        }

        public void AddData(Airplane data)
        {
            //_context.Airplanes.Add(data);
            _context.Entry(data).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Airplane> GetAll()
        {
            var resul = from a in _context.Airplanes
                        //.Include(nameof(Airplane.Schedule))
                        //.Include(nameof(Airplane.PilotId))

                        select a;

            return new ObservableCollection<Airplane>(resul.Distinct());
        }

        public Airplane GetData(int id)
        {
            var airplanes = GetAll();
            var airplane = airplanes.FirstOrDefault(c => c.Id == id);

            return airplane;
        }

        public void UpdateData(Airplane data)
        {
            throw new NotImplementedException();
        }
    }
}
