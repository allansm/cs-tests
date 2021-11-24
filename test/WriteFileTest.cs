using System;
using System.IO;

public class WriteFileTest{
	public static void Main(){
		File.WriteAllText("test.txt", "hellworld");
	}
}
