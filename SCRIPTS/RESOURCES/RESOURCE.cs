using UnityEngine;
using System.Collections.Generic;
using static UI_RESOURCE;

public class RESOURCE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// сборка всей сцены ресурсов;
    /// ключ - имя сцены;
    /// значение содержит типы ресурсов и ссылки на объекты на сцене;
    /// </summary>
    protected static Dictionary<string, CLS_mining_scene>   mining_scene        { get; set; }


    /// <summary>
    /// отображаемые ресурсы UI (слоты);
    /// </summary>
    protected static Dictionary<int, CLS_UI_RESOURCE_SLOT>  resource_UI         { get; set; }


    /// <summary>
    /// все типы ресурсов;
    /// </summary>
    protected static Dictionary<string, CLS_resource>       resources_typs      { get; set; }


    /// <summary>
    /// ключ соответствует именам на сцене (mining_scene и MAP/WINDOW);
    /// значение содержит перечень добываемых ресурсов;
    /// </summary>
    protected static Dictionary<string, string[]>           list_mining_scene   { get; set; }
    //-----------------------------------------------------------------------------------------------------------------
}
    