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
    internal class CityService
    {
        private IRepository<City> _repository;
        public CityService()
        {
            _repository = new CityRepository();
        }
        public ObservableCollection<City> GetAllCities()
        {
            return _repository.GetAll();
        }
    }
}
