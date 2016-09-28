using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
namespace DemoObjects
{
    class MEF
    {

        [Import()]
        public string Name
        {
            get;
            set;
        }


        public static void Main(string[] args)
        {
            MEF objMef = new MEF();
            objMef.Compose();
            Console.Read();

        }

        public void Compose()
        {
            AssemblyCatalog catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            CompositionContainer compositionContainer = new CompositionContainer(catalog);
            compositionContainer.ComposeParts(this);
            Console.WriteLine(ExportClass.Message);

        }
    }

    static class ExportClass
    {
        [Export()]
        public static string Message
        {
            get
            {
                return "Message coming from managed extensibility framework";
            }
        }
    }
}
