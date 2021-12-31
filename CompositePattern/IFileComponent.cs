using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface IFileComponent
    {
        void ShowProperty();
        long TotalSize();
    }
}
