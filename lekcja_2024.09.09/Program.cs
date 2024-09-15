namespace lekcja_2024._09._09;
class Program
{
    public class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }
        public virtual float CalculatePerimeter()
        {
            return 0;
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
        private float Height;
        private float Base;
        public Triangle(float h, float b)
        {
            Height = h;
            Base = b;
        }
        public override float CalculateArea()
        {
            return (float)Math.Round((Base * Height) / 2, 2);
        }
        public float CalculatePerimeter(float a, float b, float c)
        {
            return (float)Math.Round(a + b + c, 2);
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
                    float Height = GetValidInput("Podaj wysokość: ");
                    float Base = GetValidInput("Podaj długość podstawy: ");
                    float a = GetValidInput("Podaj 1 bok trójkąta: ");
                    float c = GetValidInput("Podaj 2 bok trójkąta: ");
                    Triangle triangle = new Triangle(Height, Base);
                    System.Console.WriteLine("Powierzchnia trójkąta {0}", triangle.CalculateArea());
                    System.Console.WriteLine("Obwód trójkąta {0}", triangle.CalculatePerimeter(a, Base, c));
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Nieprawidłowy wybór spróbuj ponownie.");
                    break;
            }
        }
    }
    public static float GetFloatFromUsername()
    {
        float result;
        while (!float.TryParse(Console.ReadLine(), out result) && result > 0)
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
            System.Console.WriteLine(prompt);
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
