using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PwSW_Projekt
{
    public class JsonData
    {
        static Dictionary<string, List<Task>> tasks = new Dictionary<string, List<Task>>();

        public static List<Task> currentTasks = new List<Task>();
        public static List<Task> completeTasks = new List<Task>();
        public static List<Task> abandonedTasks = new List<Task>();

        public static void getTasksFromJson()
        {
            string path = "test.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                tasks = JsonConvert.DeserializeObject<Dictionary<string, List<Task>>>(json);
                currentTasks.AddRange(tasks["current"]);
                completeTasks.AddRange(tasks["complete"]);
                abandonedTasks.AddRange(tasks["abandoned"]);
                tasks.Clear();
            }
        } 

        public static void setTasksToJson()
        {
            string path = "test.json";
           
            JsonSerializerSettings microsoftDateFormatSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            tasks.Clear();
            tasks.Add("current", currentTasks);
            tasks.Add("complete", completeTasks);
            tasks.Add("abandoned", abandonedTasks);

            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented, microsoftDateFormatSettings);
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            file.Close();
            File.WriteAllText(path, json);
            
        }
    }
}
