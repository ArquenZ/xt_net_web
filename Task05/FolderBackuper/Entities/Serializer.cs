using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper.Entities
{
    class Serializer
    {
        private Stream _stream;
        public string Path { get; }
        public Serializer()
        {
            Folder folder = new Folder();
            Path = System.IO.Path.Combine(folder.DirInfo.FullName, "Log.json");
            if (!File.Exists(Path))
            {
                File.Create(Path);
            }
        }
        public void SaveLog(LogDictionary Log)
        {            
            string jsonString = JsonConvert.SerializeObject(Log);
            jsonString = JObject.Parse(jsonString).ToString(Formatting.Indented);
            using (_stream = File.Open(Path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(_stream, Encoding.Default))
                {
                    writer.Write(jsonString);
                }
            }            
        }
        public LogDictionary ReadLog()
        {
            string content;
            using (_stream = File.Open(Path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(_stream, Encoding.Default))
                {
                    content = reader.ReadToEnd();
                }
            }
            return JsonConvert.DeserializeObject<LogDictionary>(content);
        }
    }
}
