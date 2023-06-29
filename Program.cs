using static LinkedListRecursive.LinkedList;

Node head = null;
var linkedlist = new LinkedListRecursive.LinkedList();
head = linkedlist.Insert(head, 1);
head = linkedlist.Insert(head, 2);
head = linkedlist.Insert(head, 3);
head = linkedlist.Insert(head, 4);
head = linkedlist.Insert(head, 5);
linkedlist.Print(head);