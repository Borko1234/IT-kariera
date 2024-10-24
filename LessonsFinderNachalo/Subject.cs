using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Subject
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.lenght < 2 || value.lenght > 40) throw new ArgumentException("Name should be between 2 and 40 characters!");
            name = value;
                   
        }
    }

    private List<Lesson> lessons;

    public Subject(string name)
    {
        lessons = new List<Lesson>();
        this.Name = name;
    }

    public void AddLesson(Lesson lesson)
    {
        lessons.Add(lesson);
    }

    public double AverageRating()
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public List<Lesson> GetLessonsByTeacher(string teacher)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public void AddRate(string title, int rate)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }
}