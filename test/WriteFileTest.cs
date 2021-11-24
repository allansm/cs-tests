using System;
using System.IO;

public class WriteFileTest{
	void test(){
		File.WriteAllText("test.txt", "helloworld");
	}

	public static void Main(){
		StreamWriter w = new StreamWriter("test.txt",true);
		w.WriteLine("hello");
		w.WriteLine("world");
		w.Close();	
	}
}
