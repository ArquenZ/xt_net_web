using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper.Entities
{
    class LogDictionary
    {
        public Dictionary<DateTime, List<FileAdapter>> dictionary { get; set; }
        public Dictionary<DateTime, List<FileAdapter>> GetDictionary()
        {
            Serializer jsonAdapter = new Serializer();
            Folder folder = new Folder();
            LogDictionary log = jsonAdapter.ReadLog() ?? new LogDictionary();
            return log.dictionary;
        }

        public void AddChanges(DateTime date, List<FileAdapter> files)
        {
            if (dictionary == null)
            {
                dictionary = new Dictionary<DateTime, List<FileAdapter>>();
            }

            dictionary.Add(date, files);
        }
    }
}
