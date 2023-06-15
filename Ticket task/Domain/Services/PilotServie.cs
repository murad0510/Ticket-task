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
    public class PilotServie
    {
        private IRepository<Pilot> _repository;

        public PilotServie()
        {
            _repository = new PilotRepository();
        }

        public Pilot GetPilot(int id)
        {
            var pilots = _repository.GetAll();
            var pilot = pilots.FirstOrDefault(c => c.Id == id);

            return pilot;
        }
    }
}
