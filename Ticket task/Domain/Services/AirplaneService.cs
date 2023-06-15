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
    public class AirplaneService
    {
        private IRepository<Airplane> _repository;

        public AirplaneService()
        {
            _repository = new AirplaneRepository();
        }

        public ObservableCollection<Airplane> GetIdAirplanes(int scheduleId)
        {
            var result=from a in _repository.GetAll()
                       where a.ScheduleId == scheduleId
                       select a;

            return new ObservableCollection<Airplane>(result);
        }

        public void AddAirplane(Airplane airplane)
        {
            _repository.AddData(airplane);
        }
    }
}
