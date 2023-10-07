
namespace Robot;

public class Robot
{
    // attributer/variabler
    public string name;
    public string color;
    public int weight;
    public Robot lookingAt;

    // konstruktor
    public Robot(string rName, string rColor, int rWeight)
    {
        name = rName;
        color = rColor;
        weight = rWeight;
    }

    // funktion
    public void introduceSelf()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
}
