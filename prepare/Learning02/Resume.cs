public class Resume
{
    public string _name;
    public List<Job> _job = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _job)
        {
            Console.WriteLine($"{job._jobTitle} at {job._company} ({job._startYear}-{job._endYear})");
        }
    }
}