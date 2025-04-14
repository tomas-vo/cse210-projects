using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance(); // Method to calculate the distance
    public abstract double GetSpeed();    // Method to calculate the speed
    public abstract double GetPace();     // Method to calculate the pace

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Minutes} min): Distance {GetDistance()} units, Speed {GetSpeed()} km/h, Pace: {GetPace()} min per unit";
    }
}

public class Running : Activity
{
    public double Distance { get; set; } // Distance in kilometers

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Minutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return Minutes / Distance; // Pace in minutes per km
    }
}

public class Cycling : Activity
{
    public double Speed { get; set; } // Speed in km/h

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * Minutes; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return Speed; // Speed is directly given
    }

    public override double GetPace()
    {
        return 60 / Speed; // Pace in minutes per kilometer
    }
}

public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000; // Distance in kilometers (assuming each lap is 50 meters)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in minutes per kilometer
    }
}

public class Program
{
    public static void Main()
    {
        // Create instances of different activities
        Activity run = new Running(new DateTime(2022, 11, 3), 30, 3.0); // 3.0 km run
        Activity bike = new Cycling(new DateTime(2022, 11, 4), 30, 20.0); // 20 km/h cycling speed
        Activity swim = new Swimming(new DateTime(2022, 11, 5), 30, 20); // 20 laps swimming

        // Add them to a list
        List<Activity> activities = new List<Activity> { run, bike, swim };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
