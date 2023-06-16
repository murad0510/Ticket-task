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

        private TravelDBEntities4 _context;

        public ScheduleRepository()
        {
            _context= new TravelDBEntities4();
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
                         //.Include(nameof(Schedule.City))
                         select s;

            return new ObservableCollection<Schedule>(result);
        }

        public Schedule GetData(int id)
        {
            var schedule = GetAll();
            var schedules = schedule.FirstOrDefault(c => c.Id == id);

            return schedules;
        }

        public void UpdateData(Schedule data)
        {
            throw new NotImplementedException();
        }
    }
}
