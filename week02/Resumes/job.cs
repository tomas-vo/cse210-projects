// Job.cs
using System;

public class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor para inicializar los valores
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Método para mostrar los detalles del trabajo
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}









































