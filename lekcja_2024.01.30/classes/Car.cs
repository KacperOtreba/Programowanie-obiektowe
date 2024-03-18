namespace lekcja_2024._01._30.classes{
    enum Color{
        Red,
        Blue,
        Green,
        Black,
        White
    }

    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Year { get; private set; }
        public Color Color { get; private set;}

        public void ShowInformation()
        {
            System.Console.WriteLine($"This is {Brand} {Model}, from {Year} in color {Color}");
        }
    }
}