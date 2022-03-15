// See https://aka.ms/new-console-template for more information
//This is basically the Main method in C# i think 
using StacknQueue; 
Stak<String> mytesty = new Stak<String>();
mytesty.Peek(); 
mytesty.Push("HELP");
mytesty.Push("OMG");
mytesty.Push("IS");
mytesty.Push("IT");
mytesty.Push("WORKING????");
mytesty.Peek();
mytesty.printMystack(); 
mytesty.Pop();
mytesty.Pop();
mytesty.Pop();
mytesty.Pop();
mytesty.Pop();
mytesty.Pop();
mytesty.Peek(); 

BananaQ<String> mytesty2 = new BananaQ<string>();
mytesty2.Enqueue("SANA");
mytesty2.Enqueue("GUMANA");
mytesty2.Enqueue("YUNG");
mytesty2.Enqueue("CODE");
mytesty2.Dequeue();
// mytesty2.Dequeue();
// mytesty2.Dequeue();
// mytesty2.Dequeue();
// mytesty2.Dequeue(); //test Dequeue throw Exception
mytesty2.printMyQueue();



