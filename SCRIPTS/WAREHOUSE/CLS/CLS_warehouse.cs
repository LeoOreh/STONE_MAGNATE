using Newtonsoft.Json;
using TMPro;
using UnityEngine;


public class CLS_warehouse
{
    //-----------------------------------------------------------------------------------------------------------------
    public enum typs_warehouse { mining, coin, production }

    [JsonIgnore]   public TextMeshProUGUI  count_text  { get; set; }
    [JsonProperty] public string           name        { get; set; }
    [JsonIgnore]   public typs_warehouse   typ_product { get; set; }
    [JsonProperty] public int              score       { get; set; }    // общее колличество этого продукта
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public CLS_warehouse(string _name, typs_warehouse _typ_product)
    {
        count_text  = GameObject.Find("/Canvas").transform.Find("menu/WAREHOUSE/WINDOW/Viewport/Content/" + _name + "/Text").GetComponent<TextMeshProUGUI>();
        name        = _name;
        typ_product = _typ_product;
        score       = 0;
    }
    public CLS_warehouse() { }
    //-----------------------------------------------------------------------------------------------------------------
}
