using ElevatorApp.Enums;
using ElevatorApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Classes
{


    public class ElevatorSystem : IElevatorSystem
    {
        public int[] selectedFloors;
        private int numFloors;
        private int numElevators;
        private List<Elevator> Elevators;
        private List<Floor> Floors;
        private Elevator? SelectedElevator;
        private string SystemMessage;
        private int WaitingList;
        private Queue<int>? FloorsQueue;


        public ElevatorSystem()
        {
            Elevators = new List<Elevator>();
            Floors = new List<Floor>();
            FloorsQueue = new Queue<int>();

            Building bld = new Building(10, 10);
            numElevators = bld.getElevators().Count;
            Elevators = bld.getElevators();
            Floors = bld.getFloors();
            numFloors = bld.getFloors().Count;
            SystemMessage = "";
            selectedFloors = new int[numFloors];
            SelectedElevator = null;

        }
        public Elevator CallElevator(int UserFloor)
        {
            Elevator elev = FindBestElevator(UserFloor);
            SelectedElevator = elev;
            return elev;
        }
        public Elevator FindBestElevator(int UserFloor)
        {
            Elevator BestElevator = null;
            int distance = int.MaxValue;

            foreach (Elevator e in Elevators)
            {
                Directions direction = e.getDirection();
                State state = e.getElevatorState();
                int ElevFloor = e.getFloorNumber();
                int capacity = e.Capacity;

                int elevatorDistance = Math.Abs(e.getFloorNumber() - UserFloor);

                if (state == State.NotInService)
                {
                    continue;
                }
                if (capacity <= e.getPassengerCount())
                {
                    continue;
                }

                if (ElevFloor == UserFloor & direction == Directions.None) //This is the best
                {
                    if (elevatorDistance < distance)
                    {
                        BestElevator = e;
                        distance = elevatorDistance;
                    }
                }
            }

            if (BestElevator == null)  // We have not got an elevator but we dont want to miss out completely
            {
                foreach (Elevator e in Elevators)
                {
                    Directions direction = e.getDirection();
                    State state = e.getElevatorState();
                    int ElevFloor = e.getFloorNumber();
                    int PassengersCount = e.getPassengerCount();
                    if (e.getPassengerCount() < 10) // //To avoid missing the Elevator forever   (:-D   You better even go opposite direction at first than to miss out the free ride downstairs
                    {
                        int elevatorDistance = Math.Abs(e.getFloorNumber() - UserFloor);
                        if (elevatorDistance < distance)
                        {
                            BestElevator = e;
                            distance = elevatorDistance;
                        }
                    }
                }
            }
            return BestElevator;
        }
        public void AddWaitingPassenger(int passengers, int UserFloor, int destinationFloor)
        {
            Floor PassengerFloor = new Floor(UserFloor);
            PassengerFloor.AddPassenger(passengers);
            QueueDestinationFloors(UserFloor, destinationFloor);
        }
        private void QueueDestinationFloors(int UserFloor, int DestinationFloor)
        {
            FloorsQueue.Enqueue(DestinationFloor);
            RunElevator(UserFloor, FloorsQueue);
        }

        public void RunElevator(int UserFloor, Queue<int> FloorQueue)
        {
            int elevatorFloor = SelectedElevator.getFloorNumber();
            int FromFloor = elevatorFloor;
            int ToFloor = UserFloor;

            while (FloorsQueue.Count > 0)
            {
                if (FromFloor == ToFloor)
                {
                    SelectedElevator.OpenDoor();
                    SelectedElevator.IsMoving = false;
                    SelectedElevator.ElevatorState = State.StoppedAtFloor;
                    SelectedElevator.Direction = Directions.None;
                    SelectedElevator.CloseDoor();

                }
                else if (FromFloor < ToFloor)
                {
                    SelectedElevator.IsMoving = true;
                    SelectedElevator.Direction = Directions.GoingUp;
                    SelectedElevator.MoveUp(FromFloor, ToFloor);
                }
                else
                {
                    SelectedElevator.MoveDown(FromFloor, ToFloor);
                    SelectedElevator.IsMoving = true;
                    SelectedElevator.Direction = Directions.GoingDown;
                }
                FloorsQueue.Dequeue();
            }

        }



    }
}
