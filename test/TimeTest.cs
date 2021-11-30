using System;

public class TimeTest{
	public static void Main(){
		DateTime now = DateTime.Now;
		DateTime utc = DateTime.UtcNow;
		
		string t1 = $"{now:HH:mm:ss}";
		string t2 = $"{utc:HH:mm:ss}";
		
		Console.WriteLine("utc:"+t2);
		Console.WriteLine("localtime:"+t1);
	}
}
