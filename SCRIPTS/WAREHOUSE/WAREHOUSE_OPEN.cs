using System.Collections.Generic;
using UnityEngine;

public class WAREHOUSE_OPEN : WAREHOUSE
{
    public static void O()
    {
        foreach(KeyValuePair<string, CLS_warehouse> warehouse in warehouses_typs)
        {
            //Debug.Log(warehouse.Key);
            warehouse.Value.count_text.text = warehouse.Value.score.ToString();
        }
    }
}
