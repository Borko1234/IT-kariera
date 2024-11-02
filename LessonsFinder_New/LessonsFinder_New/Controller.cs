using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


public class Controller
{
    private readonly Dictionary<string, Subject> subjects;

    public Controller()
    {
        subjects = new Dictionary<string, Subject>();
    }

    public string AddSubject(List<string> args)
    {
        if (subjects.ContainsKey(args[0]))
            return "Subject already exists!";
        else
        {
            subjects.Add(args[0], new Subject(args[0]));
            return $"Created Subject {args[0]}!";
        }

    }

    public string AddLesson(List<string> args)
    {
        if (subjects.ContainsKey(args[0]))
        {
            Subject subject = subjects[args[0]];
            string title = args[1];
            int duration = int.Parse(args[2]);
            int grade = int.Parse(args[3]);
            int difficulty = int.Parse(args[4]);
            string teacher = args[5];
            string typelesson = args[6];
            if (typelesson == "online")//online
            {
                subject.AddLesson(new OnlineLesson(title, duration, grade, difficulty, teacher, args[7]));
            }
            else
            {
                subject.AddLesson(new LectureLesson(title, duration, grade, difficulty, teacher, args[7]));
            }


            return $"Created Lesson {title} in Subject {args[0]}!";
        }
        return "Lesson is not found";//////
    }

    public string RateLesson(List<string> args)
    {
        Subject subject = subjects[args[0]];
        subject.AddRate(args[1], int.Parse(args[2]));
        return $"Rated {args[1]} with {args[2]} rate.";
    }

    public string GetAverageRating(List<string> args)
    {
        if (subjects.ContainsKey(args[0]))
        {
            
            Subject subject = subjects[args[0]];
            
               
             
            
            return $"The average rating is: {subject.AverageRating():F2}";
        }
        else
        {
            return "";
        }
    }

    public string GetLessonsByTeacher(List<string> args)
    {
        string subName = args[0];
        string teacher = args[1];

        if (!subjects.ContainsKey(subName))
         
            throw new ArgumentException("Subject not found");

        var lessons = subjects[subName].GetLessonsByTeacher(teacher);
        return string.Join("\n", lessons);

        
        //if (subjects.ContainsKey(args[0]))
        //{

        //    Subject subject = subjects[args[0]];

        //    List<Lesson> lesson = subject.GetLessonsByTeacher( args[1] );
        //    StringBuilder str = new StringBuilder();
        //    foreach (var item in lesson)
        //    {
        //        str.Append(item);
        //    }
        //    return $"{str}";

        //}
        //else
        //{
        //    return "";
        //}
    }

    public string GetLessonsBetweenDuration(List<string> args)
    {
        if (subjects.ContainsKey(args[0]))
        {

            Subject subject = subjects[args[0]];

            List<Lesson> lesson = subject.GetLessonsBetweenDuration(int.Parse(args[1]), int.Parse(args[2]));
            StringBuilder str = new StringBuilder();
            foreach (var item in lesson)
            {
                str.Append(item);
            }
            return $"{str}";
           
        }
        else
        {
            return "";
        }
    }

}