/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        //change -queue.Insert(0,person) by -queue.Add(person)
        //causing LIFO behavior instead of FIFO
        _queue.Add(person); // Add to the END of the list (correct for FIFO)
    }

    public Person Dequeue()
    {
        var person = _queue[0]; // Take from the BEGINNING of the list (correct for FIFO)
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}