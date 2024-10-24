using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LectureLesson : Lesson
{
    private string location;

    public LectureLesson(string title, int duration, int grade, int difficulty, string teacher, string location) : base(title, duration, grade, difficulty, teacher)
    {
        this.Location = location;
    }

    public string Location
    {
        get
        {
            return location;
        }
        set
        {
            location = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"@ Onsite: {Location}";
    }

}
