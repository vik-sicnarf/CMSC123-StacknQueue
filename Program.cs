// See https://aka.ms/new-console-template for more information

using StacknQueue; //Like import in java 
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
mytesty2.Dequeue();
//mytesty2.Dequeue();
//mytesty2.Dequeue();
//mytesty2.Dequeue(); //test Dequeue throw Exception
mytesty2.printMyQueue();

// BananaQnaBilog<String> mytesty3 = new BananaQnaBilog<string>();
// mytesty3.Enqueue("SANA");
// mytesty3.Enqueue("GUMANA");
// mytesty3.Enqueue("YUNG");
// mytesty3.Enqueue("CODE");
// mytesty3.Dequeue();
// mytesty3.Dequeue();
// //mytesty3.Dequeue();
// //mytesty3.Dequeue();
// //mytesty3.Dequeue(); //test Dequeue throw Exception
// mytesty3.printMyQueue();
