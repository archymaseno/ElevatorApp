using ElevatorApp.Classes;
using ElevatorApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Interfaces
{
    public interface IElevatorSystem
    {
        void AddWaitingPassenger(int passengers, int UserFloor, int destinationFloor);
        Elevator CallElevator(int UserFloor);
        Elevator FindBestElevator(int UserFloor);
        void RunElevator(int UserFloor, Queue<int> FloorQueue);
    }
}
