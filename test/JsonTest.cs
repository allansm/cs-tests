using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

public class JsonTest{

	void example(){
		JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
		string json = @"{ ""nome"" : ""Jose Carlos"", ""sobrenome"" : ""Macoratti"", ""email"": ""macoratti@yahoo.com"" }";
		dynamic resultado = serializer.DeserializeObject(json);

		Console.WriteLine("  ==  Resultado da leitura do arquivo JSON  == ");
		Console.WriteLine("");

		foreach (KeyValuePair<string, object> entry in resultado){
			var key = entry.Key;
			var value = entry.Value as string;
			Console.WriteLine(String.Format("{0} : {1}",key, value));
		}

		Console.WriteLine("");
		Console.WriteLine(serializer.Serialize(resultado));
		Console.WriteLine("");
		Console.ReadKey();

	}

	static Dictionary<string,string> test(){
		JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
		string json = "{ \"name\" : \"allan\",\"lastname\" : \"sm\" }";
		dynamic result = serializer.DeserializeObject(json);
		
		Dictionary<string,string> arr = new Dictionary<string,string>();

		foreach (KeyValuePair<string, object> entry in result){
			var key = entry.Key;
			var value = entry.Value as string;

			arr[key] = value;
		}

		return arr;

	}

	void arrTest(){
		Dictionary<string,string> arr = new Dictionary<string,string>();
		
		arr["name"] = "allan";
		arr["lastname"] = "sm";
		Console.WriteLine(arr["name"]+" "+arr["lastname"]);

	}
	public static void Main(){
		Console.WriteLine(test()["name"]+" "+test()["lastname"]);
	}
}
