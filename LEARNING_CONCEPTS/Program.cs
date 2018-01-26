namespace LEARNING_CSHARP
{
	class Program
	{
		static void Main(string[] args)
		{
			// شده‌ای اشاره کنند new شوند و یا باید به یک شیء یا مجموعه از قبل new قبل از آنکه بتوان با آنها کار کرد، یا باید Reference Type تمام متغیرهای
			// string به استثناء
			// هستند Reference Type تمام آرایه‌ها در سی‌شارپ
			// هستند Zero Based ها در سی‌شارپ Collection تمامی آرایه‌ها یا
			// آرایه پس از ساخته شدن قابلیت تغییر سایز را ندارد
			// می‌شوند، مطلقا مقدار اولیه ندارند ولی Allocate قرار گرفته و یا اصطلاحا Stack تمام متغیرهایی که در داخل
			// می‌شوند، اتفاقا مقدار اولیه مشخص دارند Allocate قرار گرفته و یا اصطلاحا Heap تمام متغیرهایی که در داخل
			// هر چند نمی‌توان پس از خلق آرایه طول آنرا تغییر داد، ولی می‌توان در زمان خلق آن، طول آنرا به صورت پارامتریک مشخص نمود

			// **********
			//int[] myArray;

			//myArray[2] = 7; // Compile Error!
			// **********

			// **********
			//int[] myArray;

			//myArray = new int[5];
			// **********

			// **********
			//int[] myArray = new int[5];
			// **********

			// **********
			//int[] myArray;

			//myArray = new int[5];

			//myArray[0] = 10;
			//myArray[1] = 20;
			//myArray[2] = 30;
			//myArray[3] = 40;
			//myArray[4] = 50;
			// **********

			// **********
			//int[] myArray = { 10, 20, 30, 40, 50 };
			// **********

			// **********
			// **********
			// **********
			System.Console.Write("How many numbers do you have: ");

			string numberCountString =
				System.Console.ReadLine();

			int numberCount =
				System.Convert.ToInt32(numberCountString);

			int[] numbers = new int[numberCount];

			for (int index = 1; index <= numberCount; index++)
			{
				// [1] ->
				string message = $"[{ index }] -> ";

				System.Console.Write(message);

				string numberString =
					System.Console.ReadLine();

				int number =
					System.Convert.ToInt32(numberString);

				numbers[index - 1] = number;
				//numbers[index] = number; // Note: Wrong Usage! Runtime Error!
			}

			int sum = 0;

			for (int index = 0; index <= numberCount - 1; index++)
			{
				sum += numbers[index];
			}

			string result =
				$"The sum of these numbers is { sum }.";

			System.Console.WriteLine(result);
			// **********

			// **********
			//for (int index = 0; index <= numbers.Length - 1; index++)
			//{
			//	System.Console.WriteLine($"[{ index + 1 }]: { numbers[index] }");
			//}
			// **********

			// **********
			//for (int index = 0; index <= numbers.Length - 1; index += 2)
			//{
			//	System.Console.WriteLine($"[{ index + 1 }]: { numbers[index] }");
			//}
			// **********

			// **********
			//for (int index = numbers.Length - 1; index >= 0; index--)
			//{
			//	System.Console.WriteLine($"[{ index + 1 }]: { numbers[index] }");
			//}
			// **********

			// **********
			//for (int index = 0; index <= numbers.Length - 1; index++)
			//{
			//	numbers[index] += 10;

			//	System.Console.WriteLine($"[{ index + 1 }]: { numbers[index] }");
			//}
			// **********

			// **********
			//foreach (int currentNumber in numbers)
			//{
			//	// Note: Wrong Usage! currentNumber is readonly!
			//	//currentNumber += 10;

			//	System.Console.WriteLine(">" + currentNumber);
			//}
			// **********
			// **********
			// **********

			// **********
			int[] myArray1 = new int[3];
			int[,] myArray2 = new int[3, 50];
			int[,,] myArray3 = new int[3, 50, 4];

			// Jagged Array
			int[][] myArray4 = new int[3][];

			myArray4[0] = new int[50];
			myArray4[1] = new int[2];
			myArray4[2] = new int[3];
			// **********

			// **********
			System.Collections.ArrayList list = new System.Collections.ArrayList();

			//list.Add(1);
			//list.Add(2);
			//list.Add(222);
			//list.Add(3);
			//list.Add(4);
			//list.Add(5);
			//list.Add(222);
			//list.Add(6);
			//list.Add(7);
			//list.Add(222);
			//list.Add(8);
			//list.Add(9);

			//list.Add(0);
			//list.Insert(0, 123);
			//list.Insert(2, 234);

			//for (int index = 0; index <= list.Count - 1; index++)
			//{
			//	System.Console.WriteLine("> " + list[index]);
			//}

			//foreach (int current in list)
			//{
			//	System.Console.WriteLine("> " + current);
			//}

			//if (list.Contains(3))
			//{
			//	System.Console.WriteLine("has 3!");
			//}
			//else
			//{
			//	System.Console.WriteLine("does not have 3!");
			//}

			//list.Reverse();

			//foreach (int current in list)
			//{
			//	System.Console.WriteLine("> " + current);
			//}

			//list.Remove(15);
			//list.Remove(222);

			//foreach (int current in list)
			//{
			//	System.Console.WriteLine("> " + current);
			//}

			//while(list.Contains(222))
			//{
			//	list.Remove(222);
			//}

			// سیستم را نابود می‌کند
			//foreach(int intNumber in list)
			//{
			//	if(intNumber == 222)
			//	{
			//		list.Remove(intNumber);
			//	}
			//}

			// سیستم را نابود می‌کند
			//for (int index = 0; index < list.Count; index++)
			//{
			//	if ((int)list[index] == 222)
			//	{
			//		list.Remove(222);
			//	}
			//}

			//foreach (int current in list)
			//{
			//	System.Console.WriteLine("> " + current);
			//}

			//System.Console.WriteLine("Count: " + list.Count);

			//list.RemoveAt(3);

			//System.Console.WriteLine("Count: " + list.Count);

			//foreach (int current in list)
			//{
			//	System.Console.WriteLine("> " + current);
			//}

			//list.Clear();

			//foreach (int current in list)
			//{
			//	System.Console.WriteLine("> " + current);
			//}

			//int index = list.IndexOf(500);
			//int index = list.IndexOf(222);

			//System.Console.WriteLine("> " + index);

			//index = list.IndexOf(222);

			//System.Console.WriteLine("> " + index);

			//index = list.LastIndexOf(222);

			//System.Console.WriteLine("> " + index);
			// **********

			// **********
			//System.Collections.ArrayList oMyList1 = new System.Collections.ArrayList();

			//oMyList1.Add(1);
			//oMyList1.Add(2);
			//oMyList1.Add("Hello, World!"); // سوتی دادم
			//oMyList1.Add(3);
			//oMyList1.Add(4);

			//foreach (int current in oMyList1)
			//{
			//	System.Console.WriteLine("> " + current);
			//}
			// **********

			// **********
			//System.Collections.Generic.List<int> oMyList2 = new System.Collections.Generic.List<int>();

			//oMyList2.Add(1);
			//oMyList2.Add(2);
			////oMyList2.Add("Hello, World!"); // سوتی دادم
			//oMyList2.Add(3);
			//oMyList2.Add(4);

			//foreach (int current in oMyList2)
			//{
			//	System.Console.WriteLine("> " + current);
			//}
			// **********

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
