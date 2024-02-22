using DesignPatternStrategy.Warehouse;
 



string warehouseName = "";
Warehouse warehouse = new Warehouse();


// Use TSE strategy
 warehouseName = "TSE";

warehouse.SetStrategy(warehouseName);
object tseEntryModel = new TSEentryModel { };
TSEOutPutModel tseOutPutModel =(TSEOutPutModel)warehouse.ExecuteOperation(tseEntryModel);


// Use Manual strategy
 warehouseName = "Manual";

warehouse.SetStrategy(warehouseName);
object manualEntryModel = new ManualEntryModel { };
ManualOutPutModel tSEOutPutModel =(ManualOutPutModel)warehouse.ExecuteOperation(manualEntryModel);


// Use CDC strategy
warehouseName = "CDC"; 
warehouse.SetStrategy(warehouseName);
object cDCEntryModel = new CDCEntryModel { };
CDCOutPutModel cDCOutPutModel = (CDCOutPutModel)warehouse.ExecuteOperation(cDCEntryModel);


Console.WriteLine("Hello, World!");
