using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found:  The queue initially did not correctly remove the highest priority item.

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
         priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);


        var result = priorityQueue.Dequeue();

        Assert.AreEqual("B", result);   
    }

    [TestMethod]
   // Scenario: Add two items with the same priority.
    // Expected Result: The first item added should be removed first (FIFO rule).
    // Defect(s) Found: The queue did not initially follow FIFO when priorities were equal. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("First", 3);
        priorityQueue.Enqueue("Second", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);


    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: The queue did not throw the correct exception when empty.
    public void TestPriorityQueue_EmptyQueue()
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
    }

}