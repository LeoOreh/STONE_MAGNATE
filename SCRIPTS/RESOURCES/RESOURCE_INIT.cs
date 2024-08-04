using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
//-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        // ДОБЫВАЕМЫЕ РЕСУРСЫ
        resources = new Dictionary<string, CLS_resource>()
        {
            ["MONEY"] = new CLS_resource(0, 0, 0, 0),  // монеты не добываются
            ["BLACK"] = new CLS_resource(1, 0, 1.0f, 1),
            ["GLASS"] = new CLS_resource(1, 0, 1.8f, 1),
            ["GREEN"] = new CLS_resource(1, 0, 2.5f, 1),
            ["TREE"]  = new CLS_resource(1, 0, 1.4f, 1)
        };



        // СЦЕНЫ ДОБЫВАЕМЫХ РЕСУРСОВ (МОЖЕТ БЫТЬ НЕКОЛЬКО ВИДОВ СРАЗУ)
        // КЛЮЧ- НАЗВАНИЕ СЦЕНЫ, ЗНАЧЕНИЕ- НАЗВАНИЕ И ВИДЫ РЕСУРСОВ (ДО ТРЕХ)
        mining_scene = new Dictionary<string, CLS_resource_scene>()
        {
            ["BLACK"]               = new CLS_resource_scene ("BLACK",                new string[] { "BLACK" }          ),
            ["GLASS"]               = new CLS_resource_scene ("GLASS",                new string[] { "GLASS" }          ),
            ["GREEN"]               = new CLS_resource_scene ("GREEN",                new string[] { "GREEN" }          ),
            ["combo_GREEN_GLASS"]   = new CLS_resource_scene ("combo_GREEN_GLASS",    new string[] { "GREEN", "GLASS" } ),
            ["TREE"]                = new CLS_resource_scene ("TREE",                 new string[] { "TREE"  }          ),
        };



        // ПОЛУЧИТЬ СОХРАНЕННЫЕ ДАННЫЕ О РЕСУРСАХ (из json)
        RESOURCE_SAVE.GET();
    }
}
//-----------------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource
{
    public int   activity_status;        // 0- неактивен 1- можно добывать вручную 2- автодобыча
    public int   score;                  // всего ресурсов
    public float time_get;               // время следующего получения
    public float time_interval;          // интервал между получениями
    public int   value_get_resources;    // скольуо получаем

    public CLS_resource(int _activity_status, int _score, float _time_interval, int _value_get_resources)
    {
        activity_status     = _activity_status;
        score               = _score;
        time_get            = 1;
        time_interval       = _time_interval;
        value_get_resources = _value_get_resources;
    }
}
//-----------------------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource_scene
{
    public string[]   typs_mining_resource;   // типы добываемых ресурсов
    public GameObject GO_Canvas;              // ссылка к блоку в канвас
    public Animator   animator_mining;        // ссылка к аниматору добычи

    public CLS_resource_scene(string _name, string[] _typs_mining_resource)
    {
        typs_mining_resource = _typs_mining_resource;
        GO_Canvas            = GameObject.Find("/Canvas/scene_resources_typ/" + _name);
        animator_mining      = GO_Canvas.transform.Find("visual").GetComponent<Animator>();
    }
}
//-----------------------------------------------------------------------------------------------------------------
