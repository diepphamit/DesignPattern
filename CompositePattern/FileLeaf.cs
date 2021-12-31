using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class FileLeaf : IFileComponent
    {
        public string name { get; set; }
        public long size { get; set; }

        public FileLeaf(string name, long size)
        {
            this.name = name;   
            this.size = size;   
        }
        public void ShowProperty()
        {
            Console.WriteLine($"File name: {this.name} size: {this.size}");
        }

        public long TotalSize()
        {
            return size;    
        }
    }
}
