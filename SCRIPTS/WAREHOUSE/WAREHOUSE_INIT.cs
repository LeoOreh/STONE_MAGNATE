using System.Collections.Generic;
using UnityEngine;

public class WAREHOUSE_INIT : WAREHOUSE
{
    //-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        warehouses_typs = new Dictionary<string, CLS_warehouse>()
        {
            ["MONEY"]       = new CLS_warehouse("MONEY",      CLS_warehouse.typs_warehouse.coin),
            ["GOLD"]        = new CLS_warehouse("GOLD",       CLS_warehouse.typs_warehouse.coin),

            ["BLACK"]       = new CLS_warehouse("BLACK",      CLS_warehouse.typs_warehouse.mining),
            ["TREE"]        = new CLS_warehouse("TREE",       CLS_warehouse.typs_warehouse.mining),
            ["GREEN"]       = new CLS_warehouse("GREEN",      CLS_warehouse.typs_warehouse.mining),
            ["GLASS"]       = new CLS_warehouse("GLASS",      CLS_warehouse.typs_warehouse.mining),
            ["RED"]         = new CLS_warehouse("RED",        CLS_warehouse.typs_warehouse.mining),
            ["YELLOW"]      = new CLS_warehouse("YELLOW",     CLS_warehouse.typs_warehouse.mining),
            ["PETROLEUM"]   = new CLS_warehouse("PETROLEUM",  CLS_warehouse.typs_warehouse.mining),
        };


        // получить сохраненные значения
        SAVE_WAREHOUSE.GET();


        // Обновить значения на сцене
        WAREHOUSE_UPDATE_Values.O();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
