// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var bien1 = 123;

//var bien2 = "hello i am str";

//var bien3 = 3.14f;

//var bien4 = true;


//Console.WriteLine("a = {0},b = {1}", bien1, bien2);
//Console.WriteLine($"c = {bien3},d = {bien4}");

//string userLogin;
//Console.WriteLine("Nhap username: ");
//userLogin = Console.ReadLine();
//Console.WriteLine($"Ten vua nhap la : {userLogin}");

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(i);
//}

//int j = 8;
//while(j <= 10){
//    Console.WriteLine(j);
//    j++;
//}



using ConsoleAppDemo;

int[] numArray = new int[5] { 5, 8, 1, 4, 2 };

//Console.WriteLine($"so phan tu {numArray.Length}");
//Console.WriteLine($"so chieu {numArray.Rank}");
//Console.WriteLine($"so min {numArray.Min()}");
//Console.WriteLine($"so max {numArray.Max()}");
//Console.WriteLine($"tong {numArray.Sum()}");
//Array.Sort(numArray);

//for (int i = 0; i < numArray.Length; i++)
//{
//    Console.WriteLine(numArray[i]);
//}

//foreach (int i in numArray)
//{
//    Console.WriteLine(i);
//}

//var test = ConsoleAppDemo.Math.Tong10So();
//Console.WriteLine(test);

MyClass obj = new MyClass("xin chao");

//phuong thuc set
obj.MyProperty = "hello";

//phuong thuc get
string value = obj.MyProperty;

//Console.WriteLine(value);   

Person person = new Person(1,"Nguyen Chanh Bao",27);
//Console.WriteLine($"toi ten la : {person.Name},tuoi cua toi la : {person.Age}");

Student student = new Student();
student.Action();

//không thể tạo ra đối tượng từ lớp có khóa abstract
//Abstraction abstraction = new Abstraction();

//có thể tạo ra đối kế thừa từ lớp có khóa abstract
Circle circle = new Circle();
circle.Draw();


ListDemo<int> getList = new ListDemo<int>();

getList.Push(1);
getList.Push(2);
getList.Push(3);
getList.Pop();
getList.showData();