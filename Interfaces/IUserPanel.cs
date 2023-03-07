using ElevatorApp.Classes;
using ElevatorApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Interfaces
{
    public interface IUserPanel
    {
        public Elevator CallElevator(int UserFloor);
        public void SetNumberOfPassengers();
        public void Force_OpenDoor();
        public void DisplayStatus(string Message);
    }
}
