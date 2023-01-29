namespace ObserverPattern
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var sensor = new Sensor();
            var numericDisplay = new NumericDisplay();

            sensor.Subscribe(numericDisplay);
            await sensor.StartDetection();

            var t = 1;
            Assert.Equal(9, numericDisplay.AllTemperature.Count);

        }
    }
}