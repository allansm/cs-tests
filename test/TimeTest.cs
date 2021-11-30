using System;

public class TimeTest{
	public static string clock(){
		DateTime now = DateTime.Now;

		return $"{now:HH:mm:ss}";	
	}

	public static long timeToMillis(){
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();	
	}

	public static void Main(){
		Console.WriteLine(clock());
		long start = timeToMillis();
		
		while(timeToMillis()-start < 10000){
			//Console.WriteLine((timeToMillis()-start)/1000);	
		}
		
		Console.WriteLine(clock());
	}
}
