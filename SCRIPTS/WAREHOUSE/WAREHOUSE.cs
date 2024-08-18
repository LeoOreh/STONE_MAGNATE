using Newtonsoft.Json;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WAREHOUSE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    //все типы продуктов
    public static Dictionary<string, CLS_warehouse> warehouses_typs { get; set; }
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    public static void INIT()
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

        SAVE_WAREHOUSE.GET();
    }
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    public class CLS_warehouse
    {
        public enum typs_warehouse { mining, coin, production }

        [JsonIgnore]   public TextMeshProUGUI  count_text  { get; set; }
        [JsonProperty] public string           name        { get; set; }
        [JsonIgnore]   public typs_warehouse   typ_product { get; set; }
        [JsonProperty] public int              score       { get; set; }    // общее колличество этого продукта

        public CLS_warehouse(string _name, typs_warehouse _typ_product)
        {
            count_text  = GameObject.Find("/Canvas").transform.Find("menu/WAREHOUSE/WINDOW/Viewport/Content/" + _name + "/Text").GetComponent<TextMeshProUGUI>();
            name        = _name;
            typ_product = _typ_product;
            score       = 0;
        }
        public CLS_warehouse() { }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
