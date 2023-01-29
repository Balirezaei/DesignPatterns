// See https://aka.ms/new-console-template for more information
using CompositObserver;

Console.WriteLine("Hello, World!");


var batch = GetSensor();
var display = new NumericDisplay();
batch.Subscribe(display);

Console.ReadLine();




static SensorBatch GetSensor()
{
    var sensor1 = new Sensor();
    var sensor2 = new Sensor();

    var batch = new SensorBatch();

    sensor1.Subscribe(batch);
    sensor2.Subscribe(batch);
    sensor1.StartDetection();
    sensor2.StartDetection();
    return batch;
}