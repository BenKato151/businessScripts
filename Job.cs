using System;
using System.Collections.Generic;

public class Job
{
    private List<string> requirements = new List<string>();
    private DateTime startTime = new DateTime();
    private string location;
    private string companyName = "";
    private string description;
    private bool gotaGreatTeam = false;
    private bool hasHomeOffice = false;
    private bool isForJobBeginners = false;
    private float salary = 0.0f;

    public Job(List<string> requirements, DateTime startTime, string location, string companyName, string description, bool gotaGreatTeam, bool hasHomeOffice, bool isForJobBeginners, float salary)
    {
        this.requirements = requirements;
        this.startTime = startTime;
        this.location = location;
        this.companyName = companyName;
        this.description = description;
        this.gotaGreatTeam = gotaGreatTeam;
        this.hasHomeOffice = hasHomeOffice;
        this.isForJobBeginners = isForJobBeginners;
        this.salary = salary;
    }

    public bool CheckMyYes(Job newJob)
    {
        bool tmpYes = false;
        foreach (string requirement in newJob.requirements)
        {
            switch (requirement)
            {
                case "Python":
                    tmpYes = true;
                    break;
                case "Unity3D":
                    tmpYes = true;
                    break;
                case "C#":
                    tmpYes = true;
                    break;
                case "Linux":
                    tmpYes = true;
                    break;
                case "SQLite":
                    tmpYes = true;
                    break;
                case "NodeJS":
                    tmpYes = true;
                    break;
                case "GIT":
                    tmpYes = true;
                    break;
                case "ReactJS":
                    tmpYes = true;
                    break;
                case "Headless CMS":
                    tmpYes = true;
                    break;
                case "OOP":
                    tmpYes = true;
                    break;
                case "Kotlin":
                    tmpYes = true;
                    break;
                default:
                    tmpYes = false;
                    break;
            }
        }

        if (tmpYes)
        {
            tmpYes = false;
            if (newJob.gotaGreatTeam && newJob.isForJobBeginners)
            {
                if (newJob.startTime.Date == new DateTime(2020, 11, 1))
                {
                    if (newJob.location == "Bundesweit" && newJob.salary >= 35000.0f)
                    {
                        if (newJob.hasHomeOffice)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return tmpYes;
    }
}

public class YourCompany
{
    private static Job newJob;

    public static void Main(string[] args)
    {
        List<string> requirements = new List<string>();
        requirements.Add("Python");
        requirements.Add("Unity3D");
        requirements.Add("C#");
        requirements.Add("Linux");
        requirements.Add("SQLite");
        requirements.Add("NodeJS");
        requirements.Add("GIT");
        requirements.Add("ReactJS");
        requirements.Add("Headless CMS");
        requirements.Add("OOP");
        requirements.Add("Kotlin");
        requirements.Add("[Any other that is similar to these above]");

        DateTime startTime = new DateTime(2020, 11, 1);
        string location = "Bundesweit";
        string companyName = "[Your Company name]";
        string description = "wonderfull Job-description";
        bool gotaGreatTeam = true;
        bool hasHomeOffice = true;
        bool isForJobBeginners = true;
        float salary = 35000.0f;

        newJob = new Job(requirements, startTime, location, companyName, description, 
                            gotaGreatTeam, hasHomeOffice, isForJobBeginners, salary
                        );
        if (newJob.CheckMyYes(newJob))
        {
            Console.WriteLine("Congrats, you've got a new Hire! :) ");
        }
	else{
	    Console.WriteLine("Sorry, that's not what I want :(    ");
	}
    }
}
