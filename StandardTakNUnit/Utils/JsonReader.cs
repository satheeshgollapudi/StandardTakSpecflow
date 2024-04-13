
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace test.Utils
{
	public class JsonReader
	{

        public string email { get; set; }
        public string password { get; set; }
        public String country { get; set; }
        public String university { get; set; }
        public String title { get; set; }
        public String degree { get; set; }
        public String graduationYear { get; set; }
        public String Language { get; set; }
        public String Level { get; set; }
        public String certificate { get; set; }
        public String from { get; set; }
        public String year { get; set; }
        public List<LanguageData> Languages { get; set; }






        public static JsonReader read(string path)
        {
         

            string json = File.ReadAllText(path);
            JsonReader jr = JsonConvert.DeserializeObject<JsonReader>(json);
            return jr;
        }


        public class LanguageData
        {
            public string Language { get; set; }
            public string Level { get; set; }
        }

    }
}

