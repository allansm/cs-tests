using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

public class JsonTest{	
	//serializer.Serialize(result)

	static Dictionary<string,object> getJson(string json){
		JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
		dynamic result = serializer.DeserializeObject(json);
		
		return result;	
	}

	static void showJson(string json){
		
		Dictionary<string,string> arr = new Dictionary<string,string>();

		foreach (KeyValuePair<string, object> entry in getJson(json)){
			var key = entry.Key;
			var value = entry.Value as string;
			
			Console.WriteLine(key+":"+value);
		}

	}

	void arrTest(){
		Dictionary<string,string> arr = new Dictionary<string,string>();
		
		arr["name"] = "allan";
		arr["lastname"] = "sm";
		Console.WriteLine(arr["name"]+" "+arr["lastname"]);

	}

	public static void Main(){
		showJson("{'name':'allan','lastname':'sm'}");
	}
}
