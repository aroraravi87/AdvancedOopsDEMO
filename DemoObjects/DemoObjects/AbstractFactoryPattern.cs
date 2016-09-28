using System;
using System.Runtime.Remoting.Messaging;

namespace DemoObjects
{
    #region Interface Declaration

    interface ICar
    {
        IBaseModel GetBaseModel();
        ITopModel GeTopModel();

    }

    interface IBaseModel
    {
        string DisplayBaseModel();
    }

    interface ITopModel
    {
        string DisplayTopModel();
    }

    #endregion

    #region Vehicle Class Object Creation

    class clsMaruti : ICar
    {

        public IBaseModel GetBaseModel()
        {
            return new clsSwift();
        }

        public ITopModel GeTopModel()
        {
            return new clsCiaz();
        }
    }

    class clsAudi : ICar
    {

        public IBaseModel GetBaseModel()
        {
            return new clsAudiA4();
        }

        public ITopModel GeTopModel()
        {
            return new clsAudiA7();
        }
    }

    class clsLuxury : ICar
    {

        public IBaseModel GetBaseModel()
        {
            return new clsjaguar();
        }

        public ITopModel GeTopModel()
        {
            return new clsLamborghini();
        }
    }
    #endregion

    #region Class Implement individal interface.
    class clsSwift : IBaseModel
    {

        public string DisplayBaseModel()
        {
            return "Swift";
        }
    }

    class clsCiaz : ITopModel
    {

        public string DisplayTopModel()
        {
            return "Ciaz";
        }
    }

    class clsAudiA4 : IBaseModel
    {

        public string DisplayBaseModel()
        {
            return "Audi A4";
        }
    }
    class clsAudiA7 : ITopModel
    {

        public string DisplayTopModel()
        {
            return "Audi A7";
        }
    }

    class clsjaguar : IBaseModel
    {
        public string DisplayBaseModel()
        {
            return "Jaguar";
        }
    }

    class clsLamborghini : ITopModel
    {

        public string DisplayTopModel()
        {
            return "Lamborghini";
        }
    }
    #endregion

    #region Selector class with Main entry point
    class ChoiceVehicle
    {
        public string GetVehicleDetails(int carType)
        {
            ICar objCar = null;
            switch (carType)
            {
                case 0:
                    objCar = new clsMaruti();
                    break;
                case 1:
                    objCar = new clsAudi();
                    break;
                case 2:
                    objCar = new clsLuxury();
                    break;
            }
            string output = string.Format("Base Car is {0} and Top Model is {1} ",
                objCar.GetBaseModel().DisplayBaseModel(), objCar.GeTopModel().DisplayTopModel());
            return output;
        }
    }

    class AbstractFactoryPattern
    {
        public static void Main(string[] args)
        {
            ChoiceVehicle ovjChoiceVehicle = new ChoiceVehicle();
            string value = ovjChoiceVehicle.GetVehicleDetails(2);
            Console.WriteLine("Display Model of {0}", value);
            Console.Read();
        }
    }
    #endregion

}
