
using System;

namespace Notepad;

public class Game
{
    public static void Main()
    {
        // objekt
        Robot robot1 = new Robot("Tom", "red", 45);
        // objekt
        Robot robot2 = new Robot("Jerry", "blue", 45);

        Console.WriteLine(robot2.name + " and " + robot1.name);

        robot2.introduceSelf();
        robot1.introduceSelf();

        Person person1 = new Person("Alice", "agressive", false);
        Person person2 = new Person("Becky", "talkative", true);

        person1.robotOwned = robot1;
        person2.robotOwned = robot2;

        person1.robotOwned.introduceSelf();

        robot1.lookingAt = robot2;
        robot2.lookingAt = robot1;
    }

}

