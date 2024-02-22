using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public interface ICDC
    {
        public CDCOutPutModel GetDate(int contractId, int id);
    }
}
