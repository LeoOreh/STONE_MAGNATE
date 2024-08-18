using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CLS_warehouse
{
    //-----------------------------------------------------------------------------------------------------------------
    [JsonIgnore]   public bool             status      { get; set; }   // 0- не отображается 1- слот создается
    [JsonIgnore]   public TextMeshProUGUI  count_text  { get; set; }
    [JsonProperty] public string           name        { get; set; }
    [JsonIgnore]   public string           typ_product { get; set; }
    [JsonProperty] public int              score       { get; set; }    // общее колличество этого продукта
    [JsonIgnore]   public Image            icon        { get; set; } 
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public CLS_warehouse(string _name, string _typ_product)
    {
        //count_text  = GameObject.Find("/Canvas").transform.Find("menu/WAREHOUSE/WINDOW/Viewport/Content/" + _name + "/Text").GetComponent<TextMeshProUGUI>();
        name        = _name;
        typ_product = _typ_product;
        score       = 0;
    }
    public CLS_warehouse() { }
    //-----------------------------------------------------------------------------------------------------------------
}
