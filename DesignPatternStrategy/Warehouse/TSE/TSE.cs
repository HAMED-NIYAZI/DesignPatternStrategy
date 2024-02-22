using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public class TSE : IWarehouseStrategy, ITSE
    {



        public object Execute(object tSEModel)
        {
            TSEentryModel entryModel = (TSEentryModel)tSEModel;
 
            var s= GetToken(entryModel.UserName,entryModel.Password);
            var res = CallService(entryModel.Url);
            TSEOutPutModel g = GetData();

            return g;

        }

        public int CallService(string url)
        {
            Console.WriteLine("TSE=> CallService");
            return 1;
        }

        public TSEOutPutModel GetData()
        {
            Console.WriteLine("TSE=> GetData");
            return new TSEOutPutModel() {Result=new List<string>(){"234567890","234567890-" } };
        }

        public string GetToken(string userName, string password)
        {
            Console.WriteLine("TSE=> GetToken");
            var token = "123";
            return token;
        }
    }

   public class TSEentryModel
    {

        public string Url { get; set; }
        public int ContractId { get; set; }
        public string ContractName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }


    public class TSEOutPutModel
    {
        public List<string> Result { get; set; }
    }

}
