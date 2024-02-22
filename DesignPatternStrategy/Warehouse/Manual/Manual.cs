using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public class Manual : IWarehouseStrategy, IManual
    {
        public object Execute(object objectModel)
        {
            ManualEntryModel entryModel = (ManualEntryModel)objectModel;
            var list = GetEcxelFile(entryModel.FileName);

          var res=   GetResult(entryModel);

            return res;
        }




        public string GetEcxelFile(string fileName)
        {
            Console.WriteLine("Manual=> GetEcxelFile");

            return "done GetEcxelFile";
        }




      public   ManualOutPutModel GetResult(ManualEntryModel manualEntryModel)
        {
            Console.WriteLine("Manual=> GetResult");

            return new ManualOutPutModel { Ids=new List<int>() { 0,1,2,3}  , WarehoseAssets=new List<string> { "1234567asgng","asdvdvds"} };
        }
    }

    public class ManualEntryModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string ContractName { get; set; }
        public string FileName { get; set; }

    }

    public class ManualOutPutModel
    {
        public List<int> Ids { get; set; }
        public List<string> WarehoseAssets { get; set; }
    }

}
