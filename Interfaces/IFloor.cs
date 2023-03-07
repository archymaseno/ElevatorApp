using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Interfaces
{
    public interface IFloor
    {

        int FloorNumber { get; set; }
        int Upward_WaitingList { get; set; }
        int Downward_WaitingList { get; set; }

    }
}
