using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_task.DataAccess.Abstractions;
using Ticket_task.DataAccess.Concrete;
using Ticket_task.DataAccess.SqlServer;

namespace Ticket_task.Domain.Services
{
    public class SchedulesService
    {
        private IRepository<Schedule> _repository;

        public SchedulesService()
        {
            _repository = new ScheduleRepository();
        }

        public ObservableCollection<Schedule> GetIdSchedules(int id)
        {
            var result = from s in _repository.GetAll()
                         where s.CityId == id
                         select s;

            return new ObservableCollection<Schedule>(result);
        }
    }
}
