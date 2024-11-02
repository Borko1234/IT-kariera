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
            if (value.Length < 2 || value.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            name = value;
        }
    }

    private List<Lesson> lessons;

    public Subject(string name)
    {
        lessons = new List<Lesson>();
        Name = name;
    }

    public void AddLesson(Lesson lesson)
    {
        lessons.Add(lesson);
    }

    public double AverageRating()
    {
        if (lessons.Count > 0)
        {
             
            return lessons.Average(x => x.Rating);
        }
        return 0;
    }

    public List<Lesson> GetLessonsByTeacher(string teacher)
    {
        return lessons.Select(x => x)
            .Where(x => x.Teacher == teacher)
            .OrderByDescending(x => x.Duration)
            .ToList();
    }

    public List<Lesson> GetLessonsBetweenDuration(int from, int to)
    {
        return lessons.Select(x => x)
             .Where(x => x.Duration >= from && x.Duration <= to)
             .OrderByDescending(x => x.Rating)
             .ToList();
    }

    public void AddRate(string title, int rate)
    {
        //if(lessons.Contains())
        foreach (var item in lessons)
        {
            if (item.Title == title)
            {
                item.AddRating(rate);
                return;
            }
        }
        throw new ArgumentException("Lesson not found");
    }
    public override string ToString()
    {
        return $"Subject {string.Join("Subject \n", lessons)}\nTotal Lessons: {lessons.Count}";
    }
}