using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
//-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        // все типы ресурсов
        resources_typs = new Dictionary<string, CLS_resource>()
        {
            ["MONEY"]   = new CLS_resource("MONEY",   0, 0.0f, 0),
            ["BLACK"]   = new CLS_resource("BLACK",   2, 1.0f, 1),
            ["TREE"]    = new CLS_resource("TREE",    2, 1.4f, 1),
            ["GREEN"]   = new CLS_resource("GREEN",   2, 2.5f, 1),
            ["GLASS"]   = new CLS_resource("GLASS",   2, 1.8f, 1),
            ["RED"]     = new CLS_resource("RED",     2, 2.5f, 1),
            ["YELLOW"]  = new CLS_resource("YELLOW",  2, 2.5f, 1),
        };
        CLS_resource add_typ(string nm)
        {
            CLS_resource copy           = new CLS_resource();
            copy.name                   = resources_typs[nm].name;
            copy.activity_status        = resources_typs[nm].activity_status;
            copy.time_interval          = resources_typs[nm].time_interval;
            copy.value_get_resources    = resources_typs[nm].value_get_resources;
            return copy;
        }
        // СЦЕНЫ ДОБЫВАЕМЫХ РЕСУРСОВ (МОЖЕТ БЫТЬ НЕКОЛЬКО ВИДОВ СРАЗУ)
        mining_scene = new Dictionary<string, CLS_mining_scene>()
        {
            ["BLACK"]       = new CLS_mining_scene ("BLACK",        new CLS_resource[] { add_typ("BLACK") }),
            ["GLASS"]       = new CLS_mining_scene ("GLASS",        new CLS_resource[] { add_typ("GLASS") }),
            ["GREEN"]       = new CLS_mining_scene ("GREEN",        new CLS_resource[] { add_typ("GREEN") }),
            ["GREEN_GLASS"] = new CLS_mining_scene ("GREEN_GLASS",  new CLS_resource[] { add_typ("GREEN"), add_typ("GLASS") }),
            ["TREE"]        = new CLS_mining_scene ("TREE",         new CLS_resource[] { add_typ("TREE") }),
        };



        // ПОЛУЧИТЬ СОХРАНЕННЫЕ ДАННЫЕ О РЕСУРСАХ (из json)
        RESOURCE_SAVE.GET();
    }
}
//-----------------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource
{
    [JsonProperty] public string name                  { get; set; }
    [JsonProperty] public int    activity_status        { get; set; }    // 0- неактивен 1- можно добывать вручную 2- автодобыча
    [JsonProperty] public int    score                  { get; set; }    // всего ресурсов
    [JsonProperty] public float  time_get               { get; set; }    // время следующего получения
    [JsonProperty] public float  time_interval          { get; set; }    // интервал между получениями
    [JsonProperty] public int    value_get_resources    { get; set; }    // скольуо получаем

    public CLS_resource(string _name, int _activity_status, float _time_interval, int _value_get_resources)
    {
        name               = _name;
        activity_status     = _activity_status;
        time_get            = 1;
        time_interval       = _time_interval;
        value_get_resources = _value_get_resources;
    }
    public CLS_resource() { }
}
//-----------------------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------------------
public class CLS_mining_scene
{
    [JsonProperty] public CLS_resource[]   typs_mining          { get; set; }  // типы добываемых ресурсов
    [JsonIgnore]   public GameObject     GO_Canvas_typ_mining { get; set; }  // ссылка к блоку в канвас
    [JsonIgnore]   public Animator       animator_mining      { get; set; }  // ссылка к аниматору добычи

    public CLS_mining_scene(string _name, CLS_resource[]  _typs_mining)
    {
        typs_mining          = _typs_mining;
        GO_Canvas_typ_mining = GameObject.Find("/Canvas/scene_resources_typ/" + _name);
        animator_mining      = GO_Canvas_typ_mining.transform.Find("visual").GetComponent<Animator>();
    }
    public CLS_mining_scene() { }
}
//-----------------------------------------------------------------------------------------------------------------
