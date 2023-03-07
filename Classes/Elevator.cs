using ElevatorApp.Enums;
using ElevatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Classes
{
    public class Elevator
    {
        public int numFloors;

        public int ElevatorId;
        private int ElevatorFloor;
        public int Capacity;
        private string ElevatorMessage;
        public bool IsMoving;
        public bool IsDoorOpen;
        public State ElevatorState;
        public Directions Direction;
        private int PassengerCount;





        public Elevator(int _ElevatorId)
        {
            ElevatorMessage = "";
            ElevatorId = _ElevatorId;
            Capacity = 10;
            ElevatorFloor = 0;
            IsMoving = false;
            IsDoorOpen = false;
            ElevatorState = State.Idle;
            Direction = Directions.None;
            PassengerCount = 0;
            
        }
        public Directions getDirection()
        {
            return Direction;
        }
        public int getFloorNumber()
        {
            return ElevatorFloor;
        }
        public State getElevatorState()
        {
            return ElevatorState;
        }
        public void OpenDoor()
        {
            ElevatorMessage = $"Floor {ElevatorFloor} Door Opening";
            IsDoorOpen = true;
            Console.WriteLine(ElevatorMessage);
            Thread.Sleep(2000);
        }
        public void CloseDoor()
        {
            ElevatorMessage = $"Floor {ElevatorFloor} Door Closing";
            IsDoorOpen = false;
            Console.WriteLine(ElevatorMessage);
            Thread.Sleep(2000);
        }
        public void MoveUp(int fromFloor, int toFloor)
        {
            ElevatorMessage = $"Elevator {ElevatorId} at Floor {fromFloor} {Directions.GoingUp}";
            Console.WriteLine(ElevatorMessage);
            while (fromFloor < toFloor)
            {

                ElevatorFloor = fromFloor++;
                if (fromFloor != toFloor)
                {
                    ElevatorMessage = $"Floor {fromFloor} {Directions.GoingUp}";
                    Console.WriteLine(ElevatorMessage);
                }
                ElevatorMessage = $"At Floor {fromFloor} ";
            }
        }
        public void MoveDown(int fromFloor, int toFloor)
        {
            ElevatorMessage = $"Elevator {ElevatorId}  at Floor {fromFloor} {Directions.GoingDown}";
            Console.WriteLine(ElevatorMessage);
            while (fromFloor > toFloor)
            {
                fromFloor--;
                ElevatorFloor = fromFloor;
                if (fromFloor != toFloor)
                {
                    ElevatorMessage = $"Floor {fromFloor} {Directions.GoingDown}";
                    Console.WriteLine(ElevatorMessage);
                }

                ElevatorMessage = $"Stopped At Floor {fromFloor} ";
            }
        }

        public void AddPassenger(int FloorNum, int Passengers)
        {
            PassengerCount += FloorNum;
        }
        public void RemovePassenger(int FloorNum, int Passengers)
        {
            PassengerCount -= Passengers;
        }
        public int getPassengerCount()
        {
            return PassengerCount;
        }



    }
}
