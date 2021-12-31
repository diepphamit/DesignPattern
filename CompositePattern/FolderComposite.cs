using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class FolderComposite : IFileComponent
    {
        private List<IFileComponent> files = new List<IFileComponent>();

        public FolderComposite(List<IFileComponent> files)
        {
            this.files = files; 
        }

        public void ShowProperty()
        {
            files.ForEach(file => file.ShowProperty());
        }

        public long TotalSize()
        {
            return files.Sum(file => file.TotalSize());
        }
    }
}
