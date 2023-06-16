using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Ticket_task.Commands;
using Ticket_task.DataAccess.SqlServer;
using Ticket_task.Domain.Services;

namespace Ticket_task.Domain.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {

        public RelayCommand PurchaseButton { get; set; }
        public RelayCommand SelectionChanged { get; set; }
        public RelayCommand SelectionChangedSchedules { get; set; }
        public RelayCommand SelectionChangedAirplanes { get; set; }


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

        private bool schedulesIsEnable;

        public bool SchedulesIsEnable
        {
            get { return schedulesIsEnable; }
            set { schedulesIsEnable = value; OnPropertyChanged(); }
        }

        private City citySelectedItem;

        public City CitySelectedItem
        {
            get { return citySelectedItem; }
            set { citySelectedItem = value; OnPropertyChanged(); }
        }

        private Schedule schedule;

        public Schedule ScheduleSelectedItem
        {
            get { return schedule; }
            set { schedule = value; OnPropertyChanged(); }
        }

        private FlightType flightType;

        public FlightType FlightType
        {
            get { return flightType; }
            set { flightType = value; OnPropertyChanged(); }
        }


        private Airplane airplane;

        public Airplane Airplane
        {
            get { return airplane; }
            set { airplane = value; OnPropertyChanged(); }
        }



        private readonly CityService _cityService;
        private readonly SchedulesService _schedulesService;
        private readonly AirplaneService _airplaneService;
        private readonly PilotServie _pilotServie;
        private readonly FlightTypeService _flightTypeService;
        private readonly TicketService _ticketService;

        public MainWindowViewModel()
        {
            _cityService = new CityService();
            _schedulesService = new SchedulesService();
            _airplaneService = new AirplaneService();
            _pilotServie = new PilotServie();
            _flightTypeService = new FlightTypeService();
            _ticketService = new TicketService();

            if (CitySelectedItem != null)
            {
                SchedulesIsEnable = false;
            }

            CitiesItemSource = _cityService.GetAllCities();


            SelectionChanged = new RelayCommand((obj) =>
            {
                SchedulesIsEnable = true;
                SchedulesItemSource = _schedulesService.GetIdSchedules(CitySelectedItem.Id);
            });

            SelectionChangedSchedules = new RelayCommand((obj) =>
            {
                //try
                //{
                //    AirplanesItemSource = _airplaneService.GetIdAirplanes(ScheduleSelectedItem.Id);
                //}
                //catch (Exception)
                //{
                //}
            });

            SelectionChangedAirplanes = new RelayCommand((obj) =>
            {
                var pilot = _pilotServie.GetPilot((int)Airplane.PilotId);
                PilotName = pilot.Name;
                PilotSurname = pilot.Surname;
            });

            FlightTypeItemSource = _flightTypeService.GetAllFlightTypes();

            var tickets = _ticketService.GetTickets();

            TicketsItemSource = tickets;


            PurchaseButton = new RelayCommand((obj) =>
            {

                Airplane airplane = new Airplane();

                //airplane.ScheduleId = ScheduleSelectedItem.Id;

                airplane.PilotId = Airplane.PilotId;
                //airplane.Pilot = Airplane.Pilot;

                //airplane.Schedule.CityId = CitySelectedItem.Id;
                //airplane.Schedule.City = CitySelectedItem;

                airplane.Name = Airplane.Name;

                _airplaneService.AddAirplane(airplane);


                Ticket ticket = new Ticket();
                ticket.FlightTypeId = FlightType.Id;

                ticket.AirplaneId = airplane.Id;
                ticket.Airplane = airplane;

                _ticketService.AddTicket(ticket);

                var gettickets = _ticketService.GetTickets();

                TicketsItemSource = gettickets;

                MessageBox.Show("Successfully");
            });
        }

        //public void Get()
        //{
        //    //TicketsItemSource = new ObservableCollection<string>();

        //    //for (int i = 0; i < tickets.Count; i++)
        //    //{
        //    //    var s = "";
        //    //    //s.Add(tickets[i].Airplane.);
        //    //    var airplane = _airplaneService.AirplaneGetById(tickets[i].Airplane.Id);
        //    //    s += tickets[i].Airplane.Name;

        //    //    s += " - ";

        //    //    s += tickets[i].Airplane.Pilot.Name;

        //    //    s += " - ";

        //    //    s += tickets[i].Airplane.Pilot.Surname;

        //    //    s += " - ";

        //    //    s += tickets[i].Airplane.Schedule.StartDateTime.ToString();


        //    //}
        //}
    }
}
