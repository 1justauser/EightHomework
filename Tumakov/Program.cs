using System.Text;
using Tumakov.Classes;

namespace Tumakov
{
    internal class Solution
    {
        internal static void Task1()
        {
            //Упражнение 10.1.Создать интерфейс ICipher, который определяет методы поддержки
            //шифрования строк.В интерфейсе объявляются два метода encode() и decode(), которые
            //используются для шифрования и дешифрования строк, соответственно.Создать класс
            //ACipher, реализующий интерфейс ICipher.Класс шифрует строку посредством сдвига
            //каждого символа на одну «алфавитную» позицию выше. Например, в результате такого
            //сдвига буква А становится буквой Б.Создать класс BCipher, реализующий интерфейс
            //ICipher.Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й
            //позиции, на букву того же регистра, расположенную в алфавите на i - й позиции с конца
            //алфавита.Например, буква В заменяется на букву Э. Написать программу,
            //демонстрирующую функционирование классов.
            Console.WriteLine("Упражнение 10.1.\n");
            Console.WriteLine("Let's apply ACipher\nbefore: ADDZzzAлаалалжжждФ");
            Console.WriteLine("after encoding: " + ACipher.encode("ADDZzzAлаалалжжждФ"));
            Console.WriteLine("after decoding: " + ACipher.decode("ADDZzzAлаалалжжждФ"));
            Console.WriteLine("\n\n");
            Console.WriteLine("Let's apply BCipher encode\nbefore: zzzЯЯЯfffaaaggg");
            Console.WriteLine("after encoding: " + BCipher.encode("zzzЯЯЯfffaaaggg"));
            Console.WriteLine("Let's apply BCipher decode\nbefore: ```ЏЏЏtttyyysss");
            Console.WriteLine("after decoding: " + BCipher.decode("```ЏЏЏtttyyysss"));
        }
        internal static void Task2() 
        {
            //Домашнее задание 10.1.Создать класс Figure для работы с геометрическими фигурами.В
            //качестве полей класса задаются цвет фигуры, состояние «видимое / невидимое». Реализовать
            //операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение
            //цвета, опрос состояния(видимый/ невидимый). Метод вывода на экран должен выводить
            //состояние всех полей объекта. Создать класс Point(точка) как потомок геометрической
            //фигуры.Создать класс Circle(окружность) как потомок точки.В класс Circle добавить
            //метод, который вычисляет площадь окружности. Создать класс Rectangle(прямоугольник)
            //как потомок точки, реализовать метод вычисления площади прямоугольника.Точка,
            //окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и
            //вертикали, изменения цвета. Подумать, какие методы можно объявить в интерфейсе, нужно
            //ли объявлять абстрактный класс, какие методы и поля будут в абстрактном классе, какие
            //методы будут виртуальными, какие перегруженными.
            Console.WriteLine("Домашнее задание 10.1.\n");
            Console.WriteLine("Testing Figure Methods\n\n");
            Figure figureFullFLedged = new Figure(10, 20, Visability.visible, Color.orange);
            figureFullFLedged.Output();
            figureFullFLedged.MoveX(123);
            figureFullFLedged.MoveY(111);
            figureFullFLedged.ChangeColor(Color.plain);
            figureFullFLedged.VisabilityState();
            figureFullFLedged.Output();
            Figure figureEmpty = new Figure();
            figureEmpty.Output();
            figureEmpty.MoveX(-32);
            figureEmpty.MoveY(332);
            figureEmpty.ChangeColor(Color.plain);
            figureEmpty.VisabilityState();
            figureEmpty.Output();
            Console.WriteLine("Testing Point as Figure inheritor\n\n");
            Point pointFullFLedged = new Point(10, 20, Visability.visible, Color.orange);
            pointFullFLedged.Output();
            pointFullFLedged.MoveX(123);
            pointFullFLedged.MoveY(111);
            pointFullFLedged.ChangeColor(Color.plain);
            pointFullFLedged.VisabilityState();
            pointFullFLedged.Output();
            Point pointEmpty = new Point();
            pointEmpty.Output();
            pointEmpty.MoveX(-32);
            pointEmpty.MoveY(332);
            pointEmpty.ChangeColor(Color.plain);
            pointEmpty.VisabilityState();
            pointEmpty.Output();
            Console.WriteLine("Testing Circle's Methods and Constructors");
            Circle circleFullFLedged = new Circle(12, 10, 20, Visability.visible, Color.orange);
            circleFullFLedged.Output();
            circleFullFLedged.MoveX(123);
            circleFullFLedged.MoveY(111);
            circleFullFLedged.ChangeColor(Color.plain);
            circleFullFLedged.VisabilityState();
            circleFullFLedged.Output();
            Circle circleEmpty = new Circle();
            circleEmpty.Output();
            circleEmpty.MoveX(-32);
            circleEmpty.MoveY(332);
            circleEmpty.ChangeColor(Color.plain);
            circleEmpty.VisabilityState();
            circleEmpty.Output();
            Console.WriteLine("Testing Rectangle's Methods and Constructors");
            Rectangle rectangleFullFLedged = new Rectangle(23, 12, 10, 20, Visability.visible, Color.orange);
            rectangleFullFLedged.Output();
            rectangleFullFLedged.MoveX(123);
            rectangleFullFLedged.MoveY(111);
            rectangleFullFLedged.ChangeColor(Color.plain);
            rectangleFullFLedged.VisabilityState();
            rectangleFullFLedged.Output();
            Rectangle rectangleEmpty = new Rectangle();
            rectangleEmpty.Output();
            rectangleEmpty.MoveX(-32);
            rectangleEmpty.MoveY(332);
            rectangleEmpty.ChangeColor(Color.plain);
            rectangleEmpty.VisabilityState();
            rectangleEmpty.Output();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Task1();
            Task2();
        }
    }
}