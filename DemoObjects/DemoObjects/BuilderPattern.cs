using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{

    interface IVehicleBuilder
    {

        // Gets vehicle instance
        Vehicle Vehicle { get; }

        // builder methods
        void BuildFrame();
        void BuildEngine();
        void BuildWheels();
        void BuildDoors();
    }
    class MotorVehicle : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public MotorVehicle()
        {
            _vehicle = new Vehicle("Motor");
        }
        public void BuildFrame()
        {
            _vehicle["frame"] = "Motor Frame";
        }

        public void BuildEngine()
        {
            _vehicle["engine"] = "500cc";
        }

        public void BuildWheels()
        {
            _vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            _vehicle["doors"] = "0";
        }
    }

    class CarVehicle : IVehicleBuilder
    {


        private Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public CarVehicle()
        {
            _vehicle = new Vehicle("Car");
        }
        public void BuildFrame()
        {
            _vehicle["frame"] = "Car Frame";
        }

        public void BuildEngine()
        {
            _vehicle["engine"] = "2500cc";
        }

        public void BuildWheels()
        {
            _vehicle["wheels"] = "5";
        }

        public void BuildDoors()
        {
            _vehicle["doors"] = "4";
        }
    }

    class TruckVehicle : IVehicleBuilder
    {


        private Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public TruckVehicle()
        {
            _vehicle = new Vehicle("Truck");
        }
        public void BuildFrame()
        {
            _vehicle["frame"] = "Truck Frame";
        }

        public void BuildEngine()
        {
            _vehicle["engine"] = "8400cc";
        }

        public void BuildWheels()
        {
            _vehicle["wheels"] = "8";
        }

        public void BuildDoors()
        {
            _vehicle["doors"] = "2";
        }
    }

    class RacerVehicle : IVehicleBuilder
    {

        private Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        }

        public RacerVehicle()
        {
          _vehicle=new Vehicle("Racer");  
        }


        public void BuildFrame()
        {
            _vehicle["frame"]="5";
        }

        public void BuildEngine()
        {
            _vehicle["engine"] = "900CC";
        }

        public void BuildWheels()
        {
            _vehicle["wheels"] = "5";
        }

        public void BuildDoors()
        {
            _vehicle["doors"] = "2";
        }
    }

    class Vehicle
    {
        private string _vehicleType;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        public Vehicle(string VehicleType)
        {
            _vehicleType = VehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void show()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine("Frame : {0}", _parts["frame"]);
            Console.WriteLine("Engine : {0}", _parts["engine"]);
            Console.WriteLine("Doors : {0}", _parts["doors"]);
            Console.WriteLine("Wheels : {0}", _parts["wheels"]);
        }
    }

    class Vehicleshop
    {
        public void Constuct(IVehicleBuilder _objVehicleBuilder)
        {
            _objVehicleBuilder.BuildFrame();
            _objVehicleBuilder.BuildEngine();
            _objVehicleBuilder.BuildWheels();
            _objVehicleBuilder.BuildDoors();
        }
    }

    class BuilderPattern
    {
        public static void Main(string[] args)
        {
            IVehicleBuilder _vehicleBuilder;
            Vehicleshop objVehicleshop=new Vehicleshop();

            
            _vehicleBuilder = new TruckVehicle();
            objVehicleshop.Constuct(_vehicleBuilder);
            _vehicleBuilder.Vehicle.show();

            _vehicleBuilder = new CarVehicle();
            objVehicleshop.Constuct(_vehicleBuilder);
            _vehicleBuilder.Vehicle.show();


            _vehicleBuilder = new MotorVehicle();
            objVehicleshop.Constuct(_vehicleBuilder);
            _vehicleBuilder.Vehicle.show();

            _vehicleBuilder=new RacerVehicle();
            objVehicleshop.Constuct(_vehicleBuilder);
            _vehicleBuilder.Vehicle.show();

            Console.Read();
        }
    }
}
