namespace MobileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone obj1 = new Smartphone("iPhone","Pro 15","Mac.16");
            FeaturePhone obj2 = new FeaturePhone("Samsung", "S22",10);
            obj1.StartDevice();
            obj2.StartDevice();
            obj1.UseDevice();
            obj2.UseDevice();
            obj1.ShowDetails();
            obj2.ShowDetails();

        }
    }
}
