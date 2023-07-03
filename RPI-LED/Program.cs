using System.Device.Gpio;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello");

        GpioController controller = new GpioController(PinNumberingScheme.Board);

        controller.OpenPin(10,PinMode.Output);

        while (true)
        {
            controller.Write(10,PinValue.High);
            Thread.Sleep(200);
            controller.Write(10,PinValue.Low);
            Thread.Sleep(200);
        }
        
        controller.ClosePin(10);
    }
}