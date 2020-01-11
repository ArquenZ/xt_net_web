using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper.Entities
{
    class FileAdapter
    {
        public string Name { get; set; }
        public string FullName { get; set; }        
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }        
        public DateTime LastWriteTime { get; set; }
        public FileAdapter(FileInfo file)
        {
            Name = file.Name;
            FullName = file.FullName;
            Content = ContentReader(file);
            CreationTime = file.CreationTime;
            LastWriteTime = file.LastWriteTime;
        }

        private string ContentReader(FileInfo file)
        {
            string content;
            using (Stream stream = File.Open(file.FullName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.Default))
                {
                    content = reader.ReadToEnd();
                }
            }
            return content;
        }
        private void CreateFile()
        {
            FileInfo fileInfo = new FileInfo(FullName);
            fileInfo.Create();
            fileInfo.CreationTime = CreationTime;            
            fileInfo.LastWriteTime = LastWriteTime;
            using (Stream stream = File.Open(fileInfo.FullName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Default))
                {
                    writer.Write(Content);
                }
            }
        }
    }
}
