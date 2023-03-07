//Passenger needs to 
/*
 * call elevator with the PassengerFloor, DestinedFloor --App to Determine the direction and the closest Elevator from a pool of Elevators
 * Enter the Elevator
 * Leave the Elevator
 */


using ElevatorApp.Classes;
using ElevatorApp.Enums;
using ElevatorApp.Interfaces;

Console.WriteLine("Our building has 10 floors and 1 Elevators");
Building building = new Building(10, 10);


UserPanel userPanel = new UserPanel(2, new ElevatorSystem());
userPanel.CallElevator(2);
userPanel.SetNumberOfPassengers(1,2,5);


//New Instance of the Elevator
//Elevator elevator = new Elevator();

////Passenger Floor
//Console.WriteLine("Select your current Floor");
//int PassengerFloor = int.Parse(Console.ReadLine());
//elevator.CallElevator(PassengerFloor);

////Number of new Passengers
//Console.WriteLine("How many passenger entered?");
//int BoardingPassengers = int.Parse(Console.ReadLine().ToString());
//elevator.EnterElevator(BoardingPassengers);

////Number of Exiting passengers
//Console.WriteLine("How many passenger Exit?");
//int AlightingPassengers = int.Parse(Console.ReadLine().ToString());
//elevator.ExitElevator(AlightingPassengers);


////Destination Floor
//Console.WriteLine("Select your Destination Floor");
//int DestinationFloor = int.Parse(Console.ReadLine());
//elevator.SendElevator(DestinationFloor);
////Number of new Passengers
//Console.WriteLine("How many passenger entered?");
//int ReBoardingPassengers = int.Parse(Console.ReadLine().ToString());
//elevator.EnterElevator(BoardingPassengers);

////Number of Exiting passengers
//Console.WriteLine("How many passenger Exit?");
//int ReAlightingPassengers = int.Parse(Console.ReadLine().ToString());
//elevator.ExitElevator(AlightingPassengers);



