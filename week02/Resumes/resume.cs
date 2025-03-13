// Resume.cs
using System;
using System.Collections.Generic;

public class Resume
{
    private string _name;
    private List<Job> _jobs;

    // Constructor para inicializar los valores
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Método para agregar trabajos al CV
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Método para mostrar el CV completo
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
