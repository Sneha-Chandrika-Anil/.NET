using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp
{
    public class FeaturePhone:Mobile
    {
        public int buttonCount;

        public FeaturePhone(string brand, string model, int buttonCount) : base(brand, model)
        {
            this.buttonCount = buttonCount;
        }
        public override void StartDevice()
        {
            Console.WriteLine("Feature Phone running");
        }
        public override void UseDevice()
        {
            Console.WriteLine("Feature Phone in usage");
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Button Count: {buttonCount}");

        }
    }
}
