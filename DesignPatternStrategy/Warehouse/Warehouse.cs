using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStrategy.Warehouse
{
    public class Warehouse
    {
        private IWarehouseStrategy strategy;

        public void SetStrategy(string strategyName)
        {
            // Assuming the strategy classes are in the same namespace as the Warehouse class
 
            Type strategyType = Type.GetType("DesignPatternStrategy.Warehouse."+strategyName);

            strategy = (IWarehouseStrategy)Activator.CreateInstance(strategyType);
        }

        public object ExecuteOperation(object objectModel)
        {
          return  strategy.Execute(objectModel);
        }
    }
}
