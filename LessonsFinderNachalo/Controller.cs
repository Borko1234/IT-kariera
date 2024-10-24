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
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string AddLesson(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string RateLesson(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetAverageRating(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetLessonsByTeacher(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetLessonsBetweenDuration(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

}