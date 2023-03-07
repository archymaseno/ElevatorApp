using ElevatorApp.Enums;
using ElevatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Classes
{

    public class Floor
    {
        public int FloorNumber;
        private List<int> waitingPassengers;
        public Floor(int _FloorNumber)
        {
            FloorNumber = _FloorNumber;
            waitingPassengers = new List<int>();
        }

        public void AddPassenger(int passenger)
        {
            waitingPassengers.Add(passenger);
        }
        public List<int> GetWaitingPassengers()
        {
            return waitingPassengers;
        }
        public void CallElevator(Elevator elevator)
        {

        }

    }
}
