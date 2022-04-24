using CustomList;

MyList<int> list1 = new MyList<int>();
MyList<string> list2 = new MyList<string>();

list1.Add(15);
list1.Add(18);
list1.Add(33);
Console.WriteLine(list1.Remove(0));
Console.WriteLine(list1.Contains(18));
list1.Clear();
list1.InsertAt(500, 0);
list1.InsertAt(600, 1);
list1.InsertAt(700, 1);
list1.DeleteAt(1);
Console.WriteLine(list1.Find(0));

list2.Add("Abby");
list2.Add("Betty");
list2.Add("Cindy");
Console.WriteLine(list2.Remove(1));
Console.WriteLine(list2.Contains("Danny"));
list2.Clear();
list2.InsertAt("Effy", 0);
list2.InsertAt("Franky", 0);
list2.InsertAt("Gatsby", 0);
list2.DeleteAt(2);
Console.WriteLine(list2.Find(1));