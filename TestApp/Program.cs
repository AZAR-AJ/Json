using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var JsonFileContent = File.ReadAllText(@"C:\Training\Trainig API\23-02(more data json to csv)\UMCDB_json\test.json");
            var myDeserializedClass = JsonConvert.DeserializeObject<Root>(JsonFileContent);
            Console.WriteLine(myDeserializedClass.QF_NNMi_Update_IDs.status);
          
        }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class QFNNMiUpdateIDs
    {
        public string status { get; set; }
        public int successPopulationJob { get; set; }
    }

    public class Root
    {
        public QFNNMiUpdateIDs QF_NNMi_Update_IDs { get; set; }
    }



}