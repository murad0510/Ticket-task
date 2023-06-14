using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_task.Commands;
using Ticket_task.DataAccess.SqlServer;

namespace Ticket_task.Domain.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

        public RelayCommand PurchaseButton { get; set; }



        private ObservableCollection<Ticket> ticketsItemSource;

        public ObservableCollection<Ticket> TicketsItemSource
        {
            get { return ticketsItemSource; }
            set { ticketsItemSource = value; OnPropertyChanged(); }
        }

        private ObservableCollection<City> citiesItemSource;

        public ObservableCollection<City> CitiesItemSource
        {
            get { return citiesItemSource; }
            set { citiesItemSource = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Schedule> schedulesItemSource;

        public ObservableCollection<Schedule> SchedulesItemSource
        {
            get { return schedulesItemSource; }
            set { schedulesItemSource = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Airplane> airplanesItemSource;

        public ObservableCollection<Airplane> AirplanesItemSource
        {
            get { return airplanesItemSource; }
            set { airplanesItemSource = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FlightType> flightTypeItemSource;

        public ObservableCollection<FlightType> FlightTypeItemSource
        {
            get { return flightTypeItemSource; }
            set { flightTypeItemSource = value; OnPropertyChanged(); }
        }

        private string pilotName;

        public string PilotName
        {
            get { return pilotName; }
            set { pilotName = value; OnPropertyChanged(); }
        }

        private string pilotSurname;

        public string PilotSurname
        {
            get { return pilotSurname; }
            set { pilotSurname = value; OnPropertyChanged(); }
        }


        public MainWindowViewModel()
        {
            PurchaseButton = new RelayCommand((obj) =>
            {

            });
        }
    }
}
