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
            Console.WriteLine("A");
            var Tasklist = JsonConvert.DeserializeObject<Root>(JsonFileContent);
            Console.WriteLine("B");
            foreach ( var task in Tasklist.QF_NNMi_Update_IDs)
            {
                Console.WriteLine(task.status);
            }
        }
    }
    public class QFNNMiUpdateID
    {
        public string status { get; set; }
        public int successPopulationJob { get; set; }
    }

    public class Root
    {
        public List<QFNNMiUpdateID> QF_NNMi_Update_IDs { get; set; }
    }


}