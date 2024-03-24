namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			/*Car myCar = new Car("BMW", 278);

			myCar.DisplayInfo();*/

			VehicleBase vehicle = new VehicleBase("BMW", 278);

			vehicle.DisplayInfo();
		}
	}
}
