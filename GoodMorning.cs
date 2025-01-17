namespace GoodMorningProgram;
public class GoodMorning()
{

    public void Run()
    {
        Console.Write("Input Username: ");
        string? userInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Invalid input. Please try again.");
            return;
        }


        DateTime timeNow = DateTime.Now;

        TimeOfDay currentTimeOfDay = GetStateOfDay(timeNow);
        string message = TimeOfDayMessage(currentTimeOfDay);

        Console.WriteLine($"{currentTimeOfDay}, {message} {userInput}! Right now the time is {timeNow:t}");

    }

    private TimeOfDay GetStateOfDay(DateTime state)
    {
        return state.Hour switch
        {
            >= 6 and < 12 => TimeOfDay.Morning,
            >= 12 and < 15 => TimeOfDay.Noon,
            >= 15 and < 18 => TimeOfDay.Afternoon,
            >= 18 and < 22 => TimeOfDay.Evening,
            _ => TimeOfDay.Night
        };
    }

    private string TimeOfDayMessage(TimeOfDay message)
    {
        return message switch
        {
            TimeOfDay.Morning => "Why are you checking already, you just got here",
            TimeOfDay.Noon => "no time to eat, work!",
            TimeOfDay.Afternoon => "Wish you were home?",
            TimeOfDay.Evening => "We just love that you are staying late",
            _ => "No time to sleep!"
        };
    }
}