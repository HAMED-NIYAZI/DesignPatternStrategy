using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public interface IManual
    {
        string GetEcxelFile(string fileName);
        ManualOutPutModel GetResult(ManualEntryModel entryModel);
    }
}
