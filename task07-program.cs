//using System;

//#region Part01

//// Car Class
//class Car
//{
//    public int Id { get; set; }
//    public string Brand { get; set; }
//    public double Price { get; set; }

//    public Car() { }

//    public Car(int id)
//    {
//        Id = id;
//    }

//    public Car(int id, string brand)
//    {
//        Id = id;
//        Brand = brand;
//    }

//    public Car(int id, string brand, double price)
//    {
//        Id = id;
//        Brand = brand;
//        Price = price;
//    }
//}

//// Calculator Class
//class Calculator
//{
//    public int Sum(int a, int b) => a + b;
//    public int Sum(int a, int b, int c) => a + b + c;
//    public double Sum(double a, double b) => a + b;
//}

//// Parent & Child (Constructor Chaining)
//class Parent
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Parent(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    public virtual int Product() => X * Y;

//    public override string ToString() => $"({X}, {Y})";
//}

//class Child : Parent
//{
//    public int Z { get; set; }

//    public Child(int x, int y, int z) : base(x, y)
//    {
//        Z = z;
//    }

//    public new int Product() => X * Y * Z;

//    public override string ToString() => $"({X}, {Y}, {Z})";
//}

//// IShape
//interface IShape
//{
//    double Area { get; }
//    void Draw();
//    void PrintDetails()
//    {
//        Console.WriteLine($"Area: {Area}");
//    }
//}

//class Rectangle : IShape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double w, double h)
//    {
//        Width = w;
//        Height = h;
//    }

//    public double Area => Width * Height;

//    public void Draw()
//    {
//        Console.WriteLine("Drawing Rectangle");
//    }
//}

//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public Circle(double r)
//    {
//        Radius = r;
//    }

//    public double Area => Math.PI * Radius * Radius;

//    public void Draw()
//    {
//        Console.WriteLine("Drawing Circle");
//    }
//}

//// IMovable
//interface IMovable
//{
//    void Move();
//}

//class CarMovable : IMovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Car is moving");
//    }
//}

//// IReadable & IWritable
//interface IReadable
//{
//    void Read();
//}

//interface IWritable
//{
//    void Write();
//}

//class File : IReadable, IWritable
//{
//    public void Read()
//    {
//        Console.WriteLine("Reading File");
//    }

//    public void Write()
//    {
//        Console.WriteLine("Writing File");
//    }
//}

//// Shape Abstract
//abstract class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing Shape");
//    }

//    public abstract double CalculateArea();
//}

//class Rectangle2 : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle2(double w, double h)
//    {
//        Width = w;
//        Height = h;
//    }

//    public override void Draw()
//    {
//        Console.WriteLine("Drawing Rectangle");
//    }

//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//#endregion

//class Program
//{
//    static void Main()
//    {
//        // Car Constructors
//        Car c1 = new Car();
//        Car c2 = new Car(1);
//        Car c3 = new Car(2, "BMW");
//        Car c4 = new Car(3, "Audi", 500000);

//        // Calculator
//        Calculator calc = new Calculator();
//        Console.WriteLine(calc.Sum(2, 3));
//        Console.WriteLine(calc.Sum(2, 3, 4));
//        Console.WriteLine(calc.Sum(2.5, 3.5));

//        // Constructor Chaining
//        Child child = new Child(2, 3, 4);
//        Console.WriteLine(child.Product());
//        Parent parentRef = child;
//        Console.WriteLine(parentRef.Product());

//        // Polymorphism ToString
//        Parent p = new Parent(5, 6);
//        Console.WriteLine(p);
//        Console.WriteLine(child);

//        // IShape
//        Rectangle rect = new Rectangle(4, 5);
//        rect.Draw();
//        rect.PrintDetails();

//        Circle circle = new Circle(3);
//        circle.Draw();
//        circle.PrintDetails();

//        // IMovable
//        IMovable movable = new CarMovable();
//        movable.Move();

//        // Multiple Interfaces
//        File file = new File();
//        file.Read();
//        file.Write();

//        // Abstract & Virtual
//        Rectangle2 r2 = new Rectangle2(7, 8);
//        r2.Draw();
//        Console.WriteLine(r2.CalculateArea());
//    }
//}
