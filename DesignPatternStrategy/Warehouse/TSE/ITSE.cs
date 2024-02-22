using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public interface ITSE
    {
        string GetToken(string userName, string password);
        int CallService(string url);

        TSEOutPutModel GetData();
    }
}
