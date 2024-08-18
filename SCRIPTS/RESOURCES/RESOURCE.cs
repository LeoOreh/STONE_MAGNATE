using UnityEngine;
using System.Collections.Generic;

public class RESOURCE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    protected static Dictionary<string, CLS_mining_scene> mining_scene { get; set; }


    /// <summary>
    /// все типы ресурсов
    /// </summary>
    protected static Dictionary<string, CLS_resource>     resources_typs = new Dictionary<string, CLS_resource>()
    {
        ["BLACK"]       = new CLS_resource("BLACK",     2, 1.0f, 1),
        ["TREE"]        = new CLS_resource("TREE",      2, 1.4f, 1),
        ["GREEN"]       = new CLS_resource("GREEN",     2, 2.5f, 1),
        ["GLASS"]       = new CLS_resource("GLASS",     2, 1.8f, 1),
        ["RED"]         = new CLS_resource("RED",       2, 2.5f, 1),
        ["YELLOW"]      = new CLS_resource("YELLOW",    2, 2.1f, 1),
        ["PETROLEUM"]   = new CLS_resource("PETROLEUM", 2, 1.2f, 1),
    };


    /// <summary>
    /// ключ соответствует именам на сцене (mining_scene и MAP/WINDOW)
    /// </summary>
    protected static Dictionary<string, string[]>         list_mining_scene = new Dictionary<string, string[]>()
    {
        ["01_BLACK"]    = new string[] { "BLACK" },
        ["02_GLASS"]    = new string[] { "GLASS" },
        ["03_GREEN"]    = new string[] { "GREEN" },
        ["04_GREEN"]    = new string[] { "GREEN", "GLASS" },
        ["05_TREE" ]    = new string[] { "TREE"  },
        ["06_RED"]      = new string[] { "RED" },
        ["07_YELLOW"]   = new string[] { "YELLOW" },
    };
    //-----------------------------------------------------------------------------------------------------------------
}
    