using System.*;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int num01;
      int num02;
      
      Console.Write("Çarpılacak birinci sayıyı giriniz:");
      num01 = Convert.ToInt32(Console.ReadLine(""));
      Console.Write("Çarpılacak ikinici sayıyı girin:");
      num02 = Convert.ToInt32(Console.ReadLine(""));
      
      Console.WriteLine("Sonuç:"+ num01 * num02);
      Console.ReadKey();
		}
	}
}
