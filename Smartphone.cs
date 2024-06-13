using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp
{
    public class Smartphone:Mobile
    {
        public string osVersion;

        public Smartphone(string brand,string model,string osVersion):base(brand,model)
        {
            this.osVersion = osVersion;
        }
        public override void StartDevice()
        {
            Console.WriteLine("Smart Phone running");
        }
        public override void UseDevice()
        {
            Console.WriteLine("Smart Phone in usage");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"os Version: {osVersion}");

        }
    }
}
