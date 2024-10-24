using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OnlineLesson : Lesson
{
    private string platform;

    public string Platform
    {
        get
        {
            return platform;
        }
        set
        {
            if (value.lenght < 3 || value.lenght > 30) throw new ArgumentException("Platform should be between 3 and 30 characters!");
            platform = value;
        }
    }

    public OnlineLesson(string title, int duration, int grade, int difficulty, string teacher, string platform) : base(title, duration, grade, difficulty, teacher)
    {
        this.Platform = platform;
    }

    public override string ToString()
    {
        return base.ToString() + $"@ Online: {Platform}";
    }
}
