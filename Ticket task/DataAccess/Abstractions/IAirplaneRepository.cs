using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_task.DataAccess.SqlServer;

namespace Ticket_task.DataAccess.Abstractions
{
    public interface IAirplaneRepository : IRepository<Airplane>
    {
    }
}
