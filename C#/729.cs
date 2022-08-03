/*
    My CalendarI
    Simple list handling.

    Medium
*/

public class MyCalendar
{
    List<(int, int)> Calender;

    public MyCalendar()
    {
        Calender = new();
    }

    public bool Book(int start, int end)
    {
        foreach (var entry in Calender)
        {
            if (entry.Item1 < end && start < entry.Item2)
                return false;
        }
        Calender.Add((start, end));
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */
