// initially empty 
Stack<int> myStack = new Stack<int>();
Console.Clear();
// Add to it using push
for (int i = 0; i< 5; i++)
    myStack.Push(i+1);
// Stacks have a Count not a Length
Console.WriteLine($"After pushing 5 elements, the count is {myStack.Count}");
Console.ReadKey();

// remove from it using Pop
for (int i = 0; i<5; i++)
    Console.Write($"{myStack.Pop()} ");
// it is FILO, first in last out, meaning it comes out in reverse order.
Console.WriteLine($"\nAfter popping it 5 times, the count is now {myStack.Count}");
Console.ReadKey();

// Cannot initialize it like a List, however
// Stack<int> myOtherStack = new Stack<int>(){1,2,3,4,5}; // Syntax Error!
// you can initialize it with an array or a single instance.
int[] arr = new int[5]{1,2,3,4,5};
Stack<int> myOtherStack = new Stack<int>(arr);
Console.WriteLine($"After initializing with an array, the count is now {myOtherStack.Count}");
Console.ReadKey();

// myStack is now empty, if we try to pop again
// Console.Write($"{myStack.Pop()}");
// To pop safely you can use the 'TryPop' method instead
// it returns a bool true or false if it worked, also if it worked, the pop will be assigned to number.
bool Successful = myStack.TryPop(out int number);
if (!Successful)
    Console.WriteLine("Your stack is empty");
Console.ReadKey();

// the foreach command does not remove the members
foreach (int i in myOtherStack)
    Console.Write($"{i} ");
Console.WriteLine($"\nMyOtherStack still has {myOtherStack.Count} elements");
Console.ReadKey();

// You can peek at the next item on the stack without actually popping it
Console.WriteLine($"The next item on the stack is {myOtherStack.Peek()}");
Console.ReadKey();

// Finally you can use the 'Contains' method to see if an element exists in the stack
bool has = myOtherStack.Contains(4);
if (has)
    Console.WriteLine("There is a '4' in the stack");
else
    Console.WriteLine("There is no '4' in the stack");
Console.ReadKey();

// initially empty 
Queue<int> myQueue = new Queue<int>();
Console.Clear();
// Add to it using enqueue
for (int i = 0; i< 5; i++)
    myQueue.Enqueue(i+1);
// Queue have a Count not a Length
Console.WriteLine($"After enqueuing 5 elements, the count is {myQueue.Count}");
Console.ReadKey();

// remove from it using Dequeue
for (int i = 0; i<5; i++)
    Console.Write($"{myQueue.Dequeue()} ");
// it is FIFO, first in first out, meaning it comes out in the same order it went in
Console.WriteLine($"\nAfter Dequeuing  it 5 times, the count is now {myQueue.Count}");
Console.ReadKey();

// Cannot initialize it like a List, however
// Queue<int> myOtherQueue = new Queue<int>(){1,2,3,4,5}; // Syntax Error!
// you can initialize it with an array or a single instance.

Queue<int> myOtherQueue = new Queue<int>(arr);
Console.WriteLine($"After initializing with an array, the count is now {myOtherQueue.Count}");
Console.ReadKey();

// myQueue is now empty, if we try to dequeue again
// Console.Write($"{myQueue.Dequeue()}");
// To dequeue safely you can use the 'TryDequeue' method instead
// it returns a bool true or false if it worked, also if it worked, the dequeue will be assigned to number.
Successful = myQueue.TryDequeue(out  number);
if (!Successful)
    Console.WriteLine("Your queue is empty");
Console.ReadKey();

// the foreach command does not remove the members
foreach (int i in myOtherQueue)
    Console.Write($"{i} ");
Console.WriteLine($"\nMyOtherQueue still has {myOtherQueue.Count} elements");
Console.ReadKey();

// You can peek at the next item on the queue without actually dequeuing it
Console.WriteLine($"The next item on the queue is {myOtherQueue.Peek()}");
Console.ReadKey();

// Finally you can use the 'Contains' method to see if an element exists in the queue
has = myOtherQueue.Contains(7);
if (has)
    Console.WriteLine("There is a '7' in the queue");
else
    Console.WriteLine("There is no '7' in the queue");
Console.ReadKey();