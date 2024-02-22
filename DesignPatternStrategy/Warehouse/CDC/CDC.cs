using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public class CDC : IWarehouseStrategy, ICDC
    {



        public List<int> CdcList { get; set; } = new List<int>();
        public object Execute(object objectModel)
        {
            CDCEntryModel entryModel = (CDCEntryModel)objectModel;
           var list= GetDate(entryModel.ContractId,entryModel.Id);
            return list;
        }

        public CDCOutPutModel GetDate(int contractId, int id )
        {
            Console.WriteLine("CDC=> GetDate");
           CdcList.Add(333);
           CdcList.Add(3232);
           CdcList.Add(224);
           CdcList.Add(654);
            return new CDCOutPutModel {Ids=CdcList };
        }
    }

    public class CDCEntryModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string ContractName { get; set; }

    }

    public class CDCOutPutModel
    {
        public List<int> Ids { get; set; }
    }
}
