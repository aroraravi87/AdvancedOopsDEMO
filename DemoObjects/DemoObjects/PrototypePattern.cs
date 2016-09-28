using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    interface IPrototype
    {
        IPrototype Clone();
    }

    class ColorManager
    {
        private Dictionary<string, IPrototype> _colors = new Dictionary<string, IPrototype>();

        public IPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }


    class Color : IPrototype
    {
        private int _red;
        private int _green;
        private int _blue;
        public Color(int Red, int Green, int Blue)
        {
            _red = Red;
            _green = Green;
            _blue = Blue;
        }

        public IPrototype Clone()
        {
            Console.WriteLine("Clone RGB Color {0,3},{1,3},{2,3}", _red, _green, _blue);
            return this.MemberwiseClone() as IPrototype;
        }
    }


    class PrototypePattern
    {
        public static void Main(string[] args)
        {
            ColorManager objColorManager = new ColorManager();

            objColorManager["Red"] = new Color(255, 0, 0);
            objColorManager["Green"] = new Color(0, 255, 0);
            objColorManager["Blue"] = new Color(0, 0, 255);


            objColorManager["Angry"] = new Color(111, 23, 211);
            objColorManager["Cool"] = new Color(200, 100, 98);
            objColorManager["Sad"] = new Color(45, 23, 100);

            Color c1 = objColorManager["Red"].Clone() as Color;
            Color c2 = objColorManager["Cool"].Clone() as Color;
            Color c3 = objColorManager["Sad"].Clone() as Color;
            
            Console.ReadKey();

        }
    }
}
