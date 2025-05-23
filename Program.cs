// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
singleLinkedList.AddToTail(1);
singleLinkedList.AddToTail(2);
singleLinkedList.AddToTail(3);
singleLinkedList.AddToTail(4);
Console.WriteLine(singleLinkedList.PrintList());
singleLinkedList.Insert(5, 1);
Console.WriteLine(singleLinkedList.PrintList());
singleLinkedList.Delete(3);
Console.WriteLine(singleLinkedList.PrintList());
singleLinkedList.Delete(0);
Console.WriteLine(singleLinkedList.PrintList());
singleLinkedList.ChangeFirstValue(0);
Console.WriteLine(singleLinkedList.PrintList());
singleLinkedList.AddToTail(4);
singleLinkedList.AddToTail(4);
singleLinkedList.AddToTail(4);
Console.WriteLine(singleLinkedList.PrintList());
singleLinkedList.ChangeAllValue(4, 1);
Console.WriteLine(singleLinkedList.PrintList());



