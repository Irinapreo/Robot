
namespace Robot;

public class Person
{
    public string name;
    public string personality;
    public bool isSitting;
    public Robot robotOwned;


    // konstruktor
    public Person(string rName, string rPersonality, bool rIsSitting)
    {
        name = rName;
        personality = rPersonality;
        isSitting = rIsSitting;

    }

    // funktion
    public void sitDown()
    {
        isSitting = true;

    }

    // funktion
    public void standUP()
    {
        isSitting = false;
    }
}
