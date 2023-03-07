using ElevatorApp.Enums;
using ElevatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Classes
{
    public class Building
    {
        public int numFloors { get; private set; }
        public int numElevators { get; private set; }
        private List<Elevator> Elevators;
        private List<Floor> Floors;
        public Building(int _numFloors, int _numElevators)
        {
            numFloors = _numFloors;
            numElevators = _numElevators;

            Elevators = new List<Elevator>();
            for (int i = 1; i <= numElevators; i++)
            {
                Elevators.Add(new Elevator(i) { ElevatorId = i });
            }
            Floors = new List<Floor>();
            for (int i = 0; i < Floors.Count; i++)
            {
                Floors.Add(new Floor(i) { FloorNumber = i });
            }
        }
        public List<Elevator> getElevators()
        {
            return Elevators;
        }
        public List<Floor> getFloors()
        {
            return Floors;
        }
    }
}
