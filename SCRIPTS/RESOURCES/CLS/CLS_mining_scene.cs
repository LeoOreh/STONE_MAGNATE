using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;


public class CLS_mining_scene
{
    //-----------------------------------------------------------------------------------------------------------------
    [JsonProperty] public Dictionary<int, CLS_resource> typs_mining          { get; set; }  // типы добываемых ресурсов
    [JsonIgnore]   public GameObject                    GO_Canvas_typ_mining { get; set; }  // ссылка к блоку в канвас
    [JsonIgnore]   public Animator                      animator_mining      { get; set; }  // ссылка к аниматору добычи
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public CLS_mining_scene(string _name, Dictionary<int, CLS_resource> _typs_mining)
    {
        typs_mining          = _typs_mining;
        GO_Canvas_typ_mining = GameObject.Find("/Canvas").transform.Find("mining_scene/" + _name).gameObject;
        animator_mining      = GO_Canvas_typ_mining.transform.Find("visual").GetComponent<Animator>();
    }
    public CLS_mining_scene() { }
    //-----------------------------------------------------------------------------------------------------------------
}
