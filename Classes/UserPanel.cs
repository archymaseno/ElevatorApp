using ElevatorApp.Enums;
using ElevatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Classes
{
    public class UserPanel
    {

        IElevatorSystem elevatorSystem;
        Elevator elevator;
        int UserFloor { get; set; }
        public bool IsDoorOpen { get; set; }
        public UserPanel(int _UserFloor, IElevatorSystem _elevatorSystem)
        {
            UserFloor = _UserFloor;
            elevatorSystem = _elevatorSystem;

        }
        public Elevator CallElevator(int UserFloor)
        {
            elevator = elevatorSystem.CallElevator(UserFloor);
            return elevator;
        }
        public void SetNumberOfPassengers(int passengers, int Userfloor, int destinationFloor)
        {
            elevatorSystem.AddWaitingPassenger(passengers, Userfloor, destinationFloor);
        }
        //public void Force_OpenDoor()
        //{
        //    if (elevSys.IsDoorOpen)
        //    {
        //        elevSys.OpenDoor(elev);
        //        Thread.Sleep(3000);
        //        elevSys.CloseDoor(elev);
        //    }
        //}
        public void DisplayStatus(string Message)
        {
            throw new NotImplementedException();
        }


    }
}
