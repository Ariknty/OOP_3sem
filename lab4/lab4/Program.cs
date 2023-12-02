using Microsoft.VisualBasic;
using System;


// Интерфейс с одноименным методом
public interface ICommonFunctionality
{
    void CommonMethod();
}

// Абстрактный класс с одноименным методом
public abstract class AbstractCommonClass
{
    // Абстрактный метод с одноименным методом
    public abstract void CommonMethod();
}
public abstract class Figure : AbstractCommonClass, ICommonFunctionality
{ 
    public abstract double Area(); // Виртуальный метод для расчета площади
    public abstract void Draw();   // Виртуальный метод для отрисовки фигуры

    public override string ToString()
    {
        return "фигура";
    }

    // Реализация одноименного метода из интерфейса
    public override void CommonMethod()
    {
        Console.WriteLine("Общий метод для всех фигур");
    }
}


public class Rectangle : Figure
{

    public double Width { get; set; }
    public double Height { get; set; }


    public override double Area()
    {
        return Width * Height;
    }

    public override void Draw()
    {
        Console.WriteLine("Рисуем прямоугольник шириной и высотой");
    }

    public override string ToString()
    {
        return "Прямоугольник";
    }
}
public class Style : AbstractCommonClass, ICommonFunctionality
{
    public override string ToString()
    {
        return "Оформление";
    }

    // Реализация одноименного метода из интерфейса
    public override void CommonMethod()
    {
        Console.WriteLine("Общий метод для стилей");
    }
}
public partial class Control : Rectangle
{
    public override string ToString()
    {
        return "Контроль";
    }
}

public sealed class Button : Control
{
    public override string ToString()
    {
        return "Кнопка";
    }
}

public class Menu : Control
{
    public override string ToString()
    {
        return "Меню";
    }
}

public class Window : Control
{
    public override string ToString()
    {
        return "Окно";
    }
}


public class Printer
{
    public void IAmPrinting(Control someObj)
    {
        Console.WriteLine(someObj.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Пример использования одноименного метода из интерфейса
        ICommonFunctionality commonFunctionality = new Style();
        commonFunctionality.CommonMethod();

        Menu menu = new Menu();
        Button button = new Button();
        Window window = new Window();

        Figure[] figures = new Figure[] { menu, button, window};
       

        Printer printer = new Printer();

        printer.IAmPrinting(menu);
        printer.IAmPrinting(button);
        printer.IAmPrinting(window);

        Figure figure = new Rectangle();
        if (window is ICommonFunctionality)
        {
            Console.WriteLine("Объект sofa поддерживает интерфейс ICommonFunctionality.");
            ICommonFunctionality cloneableWindow = window as ICommonFunctionality;
            cloneableWindow.CommonMethod();
        }

        if (window is AbstractCommonClass)
        {
            Console.WriteLine("Объект sofa является экземпляром абстрактного класса AbstractCommonClass.");
            AbstractCommonClass baseWindow = window as AbstractCommonClass;
            baseWindow.CommonMethod();
        }


    }
}











/*
// Абстрактный класс Фигура
public abstract class Figure
{
    public abstract double Area(); // Виртуальный метод для расчета площади
    public abstract void Draw();   // Виртуальный метод для отрисовки фигуры

    public override string ToString()
    {
        return "фигура";
    }

}

// Класс Прямоугольник, наследуется от Фигуры
public class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }

    public override void Draw()
    {
        Console.WriteLine("Рисуем прямоугольник шириной и высотой");
    }

    public override string ToString()
    {
        return "Это прямоугольник со шириной и высотой";
    }
}

// Абстрактный класс Оформление
public abstract class Decoration
{
    public abstract void Decorate(); // Виртуальный метод для оформления
}

// Класс Элемент управления, наследуется от Оформления
public class UIControl : Decoration
{
    public override void Decorate()
    {
        Console.WriteLine("Оформление элемента управления");
    }
    public override string ToString()
    {
        return "Элемент управления";
    }
}

// Плотный (sealed) класс Кнопка, наследуется от Элемента управления
public sealed class Button : UIControl
{
    public void Click()
    {
        Console.WriteLine("Кнопка");
    }
    public override string ToString()
    {
        return "Кнопка";
    }
}

// Интерфейс Меню
public interface IMenu
{
    void Display();
}

// Класс Окно, реализует интерфейс Меню
public class Window : IMenu
{
    public void Display()
    {
        Console.WriteLine("Окно");
    }
}


// Дополнительный класс Printer с полиморфным методом IAmPrinting
public class Printer
{
    public void IAmPrinting(Decoration someObj)
    {
        Console.WriteLine(someObj.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов различных классов
        Figure rectangle = new Rectangle { Width = 5, Height = 10 };
        Decoration uiControl = new UIControl();
        UIControl button = new Button();
        IMenu window = new Window();


        // Массив ссылок на разнотипные объекты
        Decoration[] figures = { uiControl, button};

        // Создание объекта Printer
        Printer printer = new Printer();
        printer.IAmPrinting(uiControl);
        printer.IAmPrinting(button);

        IMenu imenu = new Window();
        if (window is IMenu)
        {
            Console.WriteLine("Объект window поддерживает интерфейс IMenu.");
            IMenu cloneawindow= window as IMenu;
            cloneawindow.Display();
        }
    }
}*/