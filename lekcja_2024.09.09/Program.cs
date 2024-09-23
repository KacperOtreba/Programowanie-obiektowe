namespace lekcja_2024._09._09;
class Program
{
    public abstract class Shape
    {
        public abstract float CalculateArea();
        public abstract float CalculatePerimeter();
        internal void DisplayInfo()
        {
            System.Console.WriteLine("To jest kształt");
        }
    }
    public class Rectangle : Shape
    {
        private float width;
        private float height;
        public void SetDimension(float w, float h)
        {
            width = w;
            height = h;
        }
        public override float CalculateArea()
        {
            return width * height;
        }
        public override float CalculatePerimeter()
        {
            return 2 * (width + height);
        }
    }
    public class Circle : Shape
    {
        private float radius;
        public Circle(float r)
        {
            radius = r;
        }
        public void SetRadius(float r)
        {
            radius = r;
        }
        public override float CalculateArea()
        {
            return (float)Math.Round(Math.PI * radius * radius, 2);
        }
        public override float CalculatePerimeter()
        {
            return (float)Math.Round(2 * Math.PI * radius, 2);
        }
    }
    public class Triangle : Shape
    {
        private float sideA;
        private float sideB;
        private float sideC;

        public Triangle(float sidea, float sideb, float sidec)
        {
            sideA = sidea;
            sideB = sideb;
            sideC = sidec;
        }
        public override float CalculateArea()
        {
            float s = (sideA + sideB + sideC) / 2;
            return (float)Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
        public override float CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Prostokąt");
            Console.WriteLine("2. Koło");
            Console.WriteLine("3. Trójkąt");
            Console.WriteLine("4. Trapez");
            Console.WriteLine("5. Kula");
            Console.WriteLine("6. Wyjście");
            System.Console.Write("Wybierz kształt do obliczenia: ");
            int choice = int.Parse(Console.ReadLine()!);

            switch (choice)
            {
                case 1:
                    Rectangle rectangle = new Rectangle();
                    System.Console.Write("Podaj szerokość: ");
                    float RectWidth = float.Parse(Console.ReadLine()!);
                    System.Console.Write("Podaj wysokość: ");
                    float RectHeight = float.Parse(Console.ReadLine()!);
                    rectangle.SetDimension(RectWidth, RectHeight);
                    System.Console.WriteLine("Powierzchnia prostokąta {0}", rectangle.CalculateArea());
                    System.Console.WriteLine("Obwód prostokąta {0}", rectangle.CalculatePerimeter());
                    break;
                case 2:
                    float CircleRadius = GetValidInput("Podaj promień: ");
                    Circle circle = new Circle(CircleRadius);
                    System.Console.WriteLine("Powierzchnia koła {0}", circle.CalculateArea());
                    System.Console.WriteLine("Obwód koła {0}", circle.CalculatePerimeter());
                    break;
                case 3:
                    float sideA, sideB, sideC;
                    do
                    {
                        sideA = GetValidInput("Podaj długość boku A: ");
                        sideB = GetValidInput("Podaj długość boku B: ");
                        sideC = GetValidInput("Podaj długość boku C: ");
                        if (!IsValidTriangle(sideA, sideB, sideC))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("\nNieprawidłowe dane, spróbuj ponownie.\n");
                            Console.ResetColor();
                        }

                    }
                    while (!IsValidTriangle(sideA, sideB, sideC));
                    Triangle tri = new Triangle(sideA, sideB, sideC);
                    System.Console.WriteLine($"Powierzchnia trójkąta: {tri.CalculateArea()}");
                    System.Console.WriteLine($"Obwód trójkąta: {tri.CalculatePerimeter()}");
                    tri.DisplayInfo();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór spróbuj ponownie.");
                    break;
            }
        }
    }

    private static bool IsValidTriangle(float sideA, float sideB, float sideC)
    {
        return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideA + sideC > sideB);
    }

    public static float GetFloatFromUser()
    {
        float result;
        while (!float.TryParse(Console.ReadLine(), out result) && result < 0) //
        {
            Console.WriteLine("Nieprawidłowe dane, spróbuj ponownie");
        }
        return result;
    }
    public static float GetValidInput(string prompt)
    {
        float result;
        while (true)
        {
            System.Console.Write(prompt);
            if (float.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                return result;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nieprawidłowe dane. Spróbuj ponownie");
                Console.ResetColor();
            }
        }
    }
}
