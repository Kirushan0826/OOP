class Program
{
    public static void Main(string[] args)
    {
        // encapsulation - getter and setter
        Car car = new Car(400);

        car.Speed = 1000000000;

        Console.WriteLine(car.Speed);

        // Polymorphism
        Jeep jeep = new Jeep();
        Bicycle bicycle = new Bicycle();
        Ship ship = new Ship();

        Vehicle[] vehicles = { car, bicycle, ship};

        foreach(Vehicle vehicle in vehicles)
        {
            vehicle.go();
        } 

        //interface
        car.applyAccelerator();
        bicycle.applyBreak();

        jeep.applyBreak();
        jeep.applyAccelerator();

    }
}
