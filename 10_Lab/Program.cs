// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Corner corner=new Corner(Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
corner.Radian();
class Corner
{
    double gradus;
    int min;
    int sec;
    public int Sec
    {
        set
        {
            sec = value % 60;
            min += value / 60;
        }
        get
        {
            return sec;
        }
    }
    public int Min
    {
        set
        {
            min = value % 60;
            gradus += value / 60;
        }
        get
        {
            return min;
        }
    }
    public double Gradus
    {
        set
        {
            if (value > 360)
            {
                gradus = value - 360;
            }
            else 
            {
                gradus=value;
            }
        }
        get
        {
            return gradus;
        }
    }
    public Corner(double gradus, int min, int sec)
    {
        Gradus = gradus;
        Min = min;
        Sec = sec;
    }
    public void Radian()
    {
        double decemalGradus = Gradus + Convert.ToDouble(Min) / 60 + Convert.ToDouble(Sec) / 3600;
        double radian = decemalGradus * Math.PI / 180;
        Console.WriteLine("Угол равен {0} градусов {1} минут {2} секунд ", Gradus, Min, Sec);
        Console.WriteLine("Угол в радианах равен {0} ", radian);

    }
}

