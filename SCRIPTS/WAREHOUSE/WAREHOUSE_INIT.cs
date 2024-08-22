using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WAREHOUSE_INIT : WAREHOUSE
{
    //-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        warehouses_typs = new Dictionary<string, CLS_warehouse>()
        {
            ["MONEY"]       = new CLS_warehouse("MONEY",      "coin"),

            ["BLACK"]       = new CLS_warehouse("BLACK",      "mining"),
            ["TREE"]        = new CLS_warehouse("TREE",       "mining"),
            ["GREEN"]       = new CLS_warehouse("GREEN",      "mining"),
            ["GLASS"]       = new CLS_warehouse("GLASS",      "mining"),
            ["RED"]         = new CLS_warehouse("RED",        "mining"),
            ["YELLOW"]      = new CLS_warehouse("YELLOW",     "mining"),

            ["PETROLEUM"]   = new CLS_warehouse("PETROLEUM",  "product"),
        };


        // получить сохраненные значения
        SAVE_WAREHOUSE.GET();


        Transform WAREHOUSE_scroll = GameObject.Find("Canvas").transform.Find("menu/WAREHOUSE/catalog/Viewport/Content");
        foreach (KeyValuePair<string, CLS_warehouse> wrh in warehouses_typs)
        {
            // если есть продукт на складе то добавить слот на сцену
            if(wrh.Value.score > 0) 
            {
                wrh.Value.status = true;

                GameObject slot = Instantiate(Resources.Load<GameObject>(Paths.WAREHOUSE_product),WAREHOUSE_scroll);
                slot.name = wrh.Key;

                wrh.Value.count_text  = WAREHOUSE_scroll.Find(wrh.Key + "/Text").GetComponent<TextMeshProUGUI>();

                wrh.Value.icon = WAREHOUSE_scroll.Find(wrh.Key + "/icon").GetComponent<Image>();
                wrh.Value.icon.sprite = Resources.Load<Sprite>(Paths.UI_RESOURCE_ICONs_TYP + "icon_" + wrh.Key);
            }
        }


        // Обновить значения на сцене
        WAREHOUSE_UPDATE_Values.O();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
