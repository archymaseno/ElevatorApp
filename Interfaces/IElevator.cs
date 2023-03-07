using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorApp.Enums;

namespace ElevatorApp.Interfaces
{
    public interface IElevator
    {
        int ElevatorId { get; } 
        int Capacity { get; set; }
        int ElevatorFloor { get; set; }
        bool IsMoving { get; set; }
        State ElevatorState { get; set; }
        Directions Direction { get; set; }
        int CurrentLoad { get; set; }
    }
}
