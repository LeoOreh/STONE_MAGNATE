using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
//-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        // СЦЕНЫ ДОБЫВАЕМЫХ РЕСУРСОВ (МОЖЕТ БЫТЬ НЕКОЛЬКО ВИДОВ СРАЗУ)
        // КЛЮЧ- НАЗВАНИЕ СЦЕНЫ, ЗНАЧЕНИЕ- НАЗВАНИЕ И ВИДЫ РЕСУРСОВ (ДО ТРЕХ)
        mining_scene = new Dictionary<string, CLS_resource_scene>()
        {
            ["BLACK"]               
            = new CLS_resource_scene ("BLACK", new CLS_resource[]             { new CLS_resource("BLACK", 1, 0, 1.0f, 1) }),

            ["GLASS"]               
            = new CLS_resource_scene ("GLASS", new CLS_resource[]            {  new CLS_resource("GLASS", 1, 0, 1.8f, 1) }),

            ["GREEN"]               
            = new CLS_resource_scene ("GREEN", new CLS_resource[]             { new CLS_resource("GREEN", 1, 0, 2.5f, 1) }),

            ["combo_GREEN_GLASS"]   
            = new CLS_resource_scene ("combo_GREEN_GLASS", new CLS_resource[] { new CLS_resource("GREEN", 1, 0, 2.5f, 1),
                                                                                new CLS_resource("GLASS", 1, 0, 1.8f, 1) }),

            ["TREE"]                
            = new CLS_resource_scene ("TREE", new CLS_resource[]              { new CLS_resource("TREE", 1, 0, 1.4f, 1) }),
        };



        // ПОЛУЧИТЬ СОХРАНЕННЫЕ ДАННЫЕ О РЕСУРСАХ (из json)
        RESOURCE_SAVE.GET();
    }
}
//-----------------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource
{
    [JsonProperty]
    public string name;
    [JsonProperty]
    public int   activity_status        { get; set; }    // 0- неактивен 1- можно добывать вручную 2- автодобыча
    [JsonProperty]
    public int   score                  { get; set; }    // всего ресурсов
    [JsonProperty]
    public float time_get               { get; set; }    // время следующего получения
    [JsonProperty]
    public float time_interval          { get; set; }    // интервал между получениями
    [JsonProperty]
    public int   value_get_resources    { get; set; }    // скольуо получаем

    public CLS_resource(string _name, int _activity_status, int _score, float _time_interval, int _value_get_resources)
    {
        name = _name;
        activity_status     = _activity_status;
        score               = _score;
        time_get            = 1;
        time_interval       = _time_interval;
        value_get_resources = _value_get_resources;
    }
    public CLS_resource() { }
}
//-----------------------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource_scene
{
    [JsonProperty]
    public CLS_resource[] resource;   // типы добываемых ресурсов
    [JsonIgnore]
    public GameObject     GO_Canvas;              // ссылка к блоку в канвас
    [JsonIgnore]
    public Animator       animator_mining;        // ссылка к аниматору добычи

    public CLS_resource_scene(string _name, CLS_resource[]  _resource)
    {
        resource             = _resource;
        GO_Canvas            = GameObject.Find("/Canvas/scene_resources_typ/" + _name);
        animator_mining      = GO_Canvas.transform.Find("visual").GetComponent<Animator>();
    }
    public CLS_resource_scene() { }
}
//-----------------------------------------------------------------------------------------------------------------
