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
    public class ScheduleRepository : IScheduleRepository
    {

        private TravelDBEntities3 _context;

        public ScheduleRepository()
        {
            _context= new TravelDBEntities3();
        }

        public void AddData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Schedule> GetAll()
        {
            var result = from s in _context.Schedules
                         select s;

            return new ObservableCollection<Schedule>(result);
        }

        public Schedule GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Schedule data)
        {
            throw new NotImplementedException();
        }
    }
}
