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
    public class FlightTypeService
    {
        private IRepository<FlightType> _repository;

        public FlightTypeService()
        {
            _repository = new FlightTypeRepository();
        }

        public ObservableCollection<FlightType> GetAllFlightTypes()
        {
            return _repository.GetAll();
        }
    }
}
