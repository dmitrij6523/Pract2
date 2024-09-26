using Kalkulyator;

first:

Kalkul clas = new Kalkul();

string solo;

Console.WriteLine("Введите первое число");
double x = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите действие");
solo = Convert.ToString(Console.ReadLine());

Console.WriteLine("Введите второе число");
double y = Convert.ToDouble(Console.ReadLine());



switch (solo)
{
    case "+":
        clas.plus(x, y);
        goto first;
    case "-":
        clas.minus(x, y);
        goto first;
    case "*":
        clas.multiplication(x, y);
        goto first;
    case "/":
        clas.division(x, y);
        goto first;

    case "Округление":
        clas.rounding(x, y);
        goto first;
    case "Арксинус":
        clas.arksin(x, y);
        goto first;
    case "Степень":
        clas.degree(x, y);
        goto first;
    case "Квадрат":
        clas.square(x, y);
        goto first;
    case "Синус":
        clas.sin(x, y);
        goto first;
    case "Тангенс":
        clas.tan(x, y);
        goto first;
    case "Площадь":
        clas.squreArea(x, y);
        goto first;
    case "Периметр":
        clas.squarePerimeter(x, y);
        goto first;
    case "Диаметр":
        clas.circleDiameter(x, y);
        goto first;
    case "Радиус":
        clas.circleRadius(x, y);
        goto first;
}