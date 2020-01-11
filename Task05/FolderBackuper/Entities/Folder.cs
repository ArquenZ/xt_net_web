using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FolderBackuper.Entities
{
    class Folder
    {
        private string name = "Backupfolder";
        public DirectoryInfo DirInfo { get; }
        public Folder()
        {
            DirInfo = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, name));
            if (!DirInfo.Exists)
            {
                Directory.CreateDirectory(DirInfo.FullName);
            }
        }
        public List<FileAdapter> Adapterfiles
        {
            get
            {   
                return GetFiles();
            }
        }
        private List<FileAdapter> GetFiles ()
        {
            List<FileAdapter> AdapterFiles = new List<FileAdapter>();            
            List<FileInfo> files = (DirInfo.EnumerateFiles($"*.txt",SearchOption.AllDirectories)).ToList();
            foreach (var item in files)
            {
                AdapterFiles.Add(new FileAdapter(item));
            }
            return AdapterFiles;
        }
    }
}
