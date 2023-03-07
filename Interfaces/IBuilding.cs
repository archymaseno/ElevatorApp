using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorApp.Classes;
namespace ElevatorApp.Interfaces
{
    public interface IBuilding
    {
        public int numFloors { get; set; }
        public int numElevators { get; set; }
        public List<Elevator> Elevators { get; set; }

    }
}
