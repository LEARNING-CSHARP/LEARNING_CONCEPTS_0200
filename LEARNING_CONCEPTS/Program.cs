namespace LEARNING_CSHARP
{
	class Program
	{
		static void Main(string[] args)
		{
			// شده‌ای اشاره کنند new شوند و یا باید به یک شیء یا مجموعه از قبل new قبل از آنکه بتوان با آنها کار کرد، یا باید Reference Type تمام متغیرهای
			// string به استثناء
			// هستند Reference Type تمام آرایه‌ها در سی‌شارپ
			// هستند Zero Based ها در سی‌شارپ، Collection تمامی آرایه‌ها یا
			// آرایه پس از ساخته شدن قابلیت تغییر سایز را ندارد
			// می‌شوند، اتفاقا مقدار اولیه مشخص دارند Allocate قرار گرفته و یا اصطلاحا Heap تمام متغیرهایی که در داخل
			// هر چند نمی‌توان پس از خلق آرایه طول آنرا تغییر داد ولی می‌توان در زمان خلق آرایه طول آنرا به صورت پارامتر اعلام نمود

			// **********
			//int[] X;

			//X = new int[5];
			// **********

			// **********
			//int[] X = new int[5];
			// **********

			// **********
			//int[] X;

			//X = new int[5];

			//X[0] = 10;
			//X[1] = 20;
			//X[2] = 30;
			//X[3] = 40;
			//X[4] = 50;
			// **********

			// **********
			//int[] X = { 10, 20, 30, 40, 50 };
			// **********

			// **********
			//System.Console.Write("How many numbers do you have: ");

			//string strNumberCount =
			//	System.Console.ReadLine();

			//int intNumberCount =
			//	System.Convert.ToInt32(strNumberCount);

			//int[] intNumbers = new int[intNumberCount];

			//int intIndex = 1;

			//while (intIndex <= intNumberCount)
			//{
			//	string strMessage =
			//		string.Format("[{0}]: ", intIndex);

			//	System.Console.Write(strMessage);

			//	string strNumber =
			//		System.Console.ReadLine();

			//	int intNumber =
			//		System.Convert.ToInt32(strNumber);

			//	intNumbers[intIndex - 1] = intNumber;

			//	intIndex++;
			//}

			//int intSum = 0;

			//for (int intCurrentIndex = 0; intCurrentIndex <= intNumberCount - 1; intCurrentIndex++)
			//{
			//	intSum +=
			//		intNumbers[intCurrentIndex];
			//}

			//string strResult =
			//	string.Format("The sum of these numbers is: {0}", intSum);

			//System.Console.WriteLine(strResult);

			//for (intIndex = 0; intIndex <= intNumbers.Length - 1; intIndex++)
			//{
			//	//System.Console.WriteLine("[" + (intIndex + 1) + "]: " + intNumbers[intIndex]);

			//	System.Console.WriteLine("[{0}]: {1}", intIndex + 1, intNumbers[intIndex]);
			//}

			//for (intIndex = intNumbers.Length - 1; intIndex >= 0; intIndex--)
			//{
			//	System.Console.WriteLine("[{0}]: {1}", intIndex + 1, intNumbers[intIndex]);
			//}

			//for (intIndex = intNumbers.Length - 1; intIndex >= 0; intIndex--)
			//{
			//	intNumbers[intIndex]++;

			//	System.Console.WriteLine("[{0}]: {1}", intIndex + 1, intNumbers[intIndex]);
			//}

			//foreach (int intCurrentNumber in intNumbers)
			//{
			//	// Note: intCurrentNumber is readonly!
			//	//intCurrentNumber++;

			//	System.Console.WriteLine(">" + intCurrentNumber);
			//}
			// **********

			// **********
			//int[,] X = new int[3, 50];
			//int[, ,] Y = new int[3, 50, 4];

			//// Jagged Array
			//int[][] Z = new int[3][];
			//Z[0] = new int[50];
			//Z[1] = new int[2];
			//Z[2] = new int[3];
			// **********

			// **********
			//System.Collections.ArrayList oList = new System.Collections.ArrayList();

			//oList.Add(1);
			//oList.Add(2);
			//oList.Add(222);
			//oList.Add(3);
			//oList.Add(4);
			//oList.Add(5);
			//oList.Add(222);
			//oList.Add(6);
			//oList.Add(7);
			//oList.Add(222);
			//oList.Add(8);
			//oList.Add(9);

			//oList.Add(0);
			//oList.Insert(0, 0);

			//for (int intIndex = 0; intIndex <= oList.Count - 1; intIndex++)
			//{
			//	System.Console.WriteLine("> " + oList[intIndex]);
			//}

			//foreach (int intCurrent in oList)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}

			//if (oList.Contains(3))
			//{
			//	System.Console.WriteLine("has 3!");
			//}
			//else
			//{
			//	System.Console.WriteLine("does not have 3!");
			//}

			//oList.Reverse();

			//foreach (int intCurrent in oList)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}

			//oList.Remove(15);
			//oList.Remove(222);

			//foreach (int intCurrent in oList)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}

			//while(oList.Contains(222))
			//{
			//	oList.Remove(222);
			//}

			//foreach (int intCurrent in oList)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}

			//System.Console.WriteLine("Count: " + oList.Count);

			//oList.RemoveAt(3);

			//System.Console.WriteLine("Count: " + oList.Count);

			//foreach (int intCurrent in oList)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}

			//oList.Clear();

			//foreach (int intCurrent in oList)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}

			//int intIndex = oList.IndexOf(222);
			//int intIndex = oList.IndexOf(500);

			//System.Console.WriteLine("> " + intIndex);

			//intIndex = oList.IndexOf(222);

			//System.Console.WriteLine("> " + intIndex);

			//intIndex = oList.LastIndexOf(222);

			//System.Console.WriteLine("> " + intIndex);
			// **********

			// **********
			//System.Collections.ArrayList oMyList1 = new System.Collections.ArrayList();

			//oMyList1.Add(1);
			//oMyList1.Add(2);
			//oMyList1.Add("Hello, World!"); // سوتی دادم
			//oMyList1.Add(3);
			//oMyList1.Add(4);

			//foreach (int intCurrent in oMyList1)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}
			// **********

			// **********
			//System.Collections.Generic.List<int> oMyList2 = new System.Collections.Generic.List<int>();

			//oMyList2.Add(1);
			//oMyList2.Add(2);
			////oMyList2.Add("Hello, World!"); // سوتی دادم
			//oMyList2.Add(3);
			//oMyList2.Add(4);

			//foreach (int intCurrent in oMyList2)
			//{
			//	System.Console.WriteLine("> " + intCurrent);
			//}
			// **********

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
