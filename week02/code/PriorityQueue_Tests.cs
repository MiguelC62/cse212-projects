using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and dequeue them
    // Expected Result: tems should be dequeued in priority order (highest first)
    // Defect(s) Found: Found: Items are not being removed from the queue after dequeue, causing wrong items to be returned
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        // Add items with different priorities
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("high", 5);
        priorityQueue.Enqueue("medium", 3);

        // Should dequeue in priority order: high(5), medium(3), low(1)
        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("medium", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    /// Scenario: Add multiple items with same priority and verify FIFO for same priority
    // Expected Result: Items with same priority should follow FIFO order
    // Defect(s) Found: Using >= instead of > in priority comparison causes LIFO behavior instead of FIFO for same priorities
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // Add items with same priority
        priorityQueue.Enqueue("first", 3);
        priorityQueue.Enqueue("second", 3);
        priorityQueue.Enqueue("third", 3);
        
        // Should dequeue in FIFO order for same priority
        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
        Assert.AreEqual("third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }
}


