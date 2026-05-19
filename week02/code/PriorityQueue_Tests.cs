using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dave is the priority
    // Expected Result: Expected dave
    // Defect(s) Found:  Expected Jerry to be second in the dequeue, but got Dave.. again.
    // 1. Values was not being removed from the queue. 
    // 2. First value of queue was being skipped.
    // 3. Also we were stopping before we got to the last one.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Mike",1);
        priorityQueue.Enqueue("Dave",10);
        priorityQueue.Enqueue("Joe",10);
        priorityQueue.Enqueue("Jerry",5);


        Assert.AreEqual("Dave",priorityQueue.Dequeue());
        Assert.AreEqual("Joe",priorityQueue.Dequeue());
        Assert.AreEqual("Jerry",priorityQueue.Dequeue());
        Assert.AreEqual("Mike",priorityQueue.Dequeue());

        
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try{
            priorityQueue.Dequeue();
            Assert.Fail();
        }catch(InvalidOperationException ){
            // - Test passed
        }
    }

    // Add more test cases as needed below.
}