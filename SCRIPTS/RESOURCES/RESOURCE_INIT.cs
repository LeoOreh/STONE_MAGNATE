using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        //----------------------------------------------------------------------------------
        list_mining_scene = new Dictionary<string, string[]>()
        {
            ["01_BLACK"]    = new string[] { "BLACK" },
            ["02_GLASS"]    = new string[] { "GLASS" },
            ["03_GREEN"]    = new string[] { "GREEN" },
            ["04_GREEN"]    = new string[] { "GREEN", "GLASS" },
            ["05_TREE" ]    = new string[] { "TREE"  },
            ["06_RED"]      = new string[] { "RED" },
            ["07_YELLOW"]   = new string[] { "YELLOW" },
        };
        //----------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------
        resources_typs = new Dictionary<string, CLS_resource>()
        {
            ["BLACK"]       = new CLS_resource("BLACK",     2, 1.0f, 1),
            ["TREE"]        = new CLS_resource("TREE",      2, 1.4f, 1),
            ["GREEN"]       = new CLS_resource("GREEN",     2, 2.5f, 1),
            ["GLASS"]       = new CLS_resource("GLASS",     2, 1.8f, 1),
            ["RED"]         = new CLS_resource("RED",       2, 2.5f, 1),
            ["YELLOW"]      = new CLS_resource("YELLOW",    2, 2.1f, 1),
            ["PETROLEUM"]   = new CLS_resource("PETROLEUM", 2, 1.2f, 1),
        };
        //----------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------
        // на сцену добовляем виды ресурсов (до 5)
        Add_Resource_in_scene();
        //----------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------
        // ПОЛУЧИТЬ СОХРАНЕННЫЕ ДАННЫЕ О РЕСУРСАХ (из json)
        SAVE_RESOURCE.GET();
        //----------------------------------------------------------------------------------
    }
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    static void Add_Resource_in_scene()
    {
        // СЦЕНЫ ДОБЫВАЕМЫХ РЕСУРСОВ (МОЖЕТ БЫТЬ НЕКОЛЬКО ВИДОВ СРАЗУ)
        // чтобы добавить новый, нужно добавить на сцене в "mining_scene" и "MAP/WINDOW"
        // создаем сцены с добычей
        mining_scene = new Dictionary<string, CLS_mining_scene>();

        foreach (KeyValuePair<string, string[]> list in list_mining_scene)
        {
            mining_scene.Add(list.Key, new CLS_mining_scene(list.Key, add_typs_minig_scene(list_mining_scene[list.Key])));
        }

        Dictionary<int, CLS_resource> add_typs_minig_scene(string[] nm)
        {
            Dictionary<int, CLS_resource> copy = new Dictionary<int, CLS_resource>();
            int n = 1;
            foreach (string str in nm)
            {
                copy.Add(n, new CLS_resource());
                copy[n] = new CLS_resource();
                copy[n].name = resources_typs[str].name;
                copy[n].activity_status = resources_typs[str].activity_status;
                copy[n].time_interval = resources_typs[str].time_interval;
                copy[n].value_get_resources = resources_typs[str].value_get_resources;
                copy[n].score_max = resources_typs[str].score_max;
                n++;
            }
            return copy;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}