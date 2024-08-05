using UnityEngine;
using System.Collections.Generic;

public class RESOURCE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    protected static int all_money;
    protected static Dictionary<string, CLS_resource>     resources_typs  { get; set; }
    protected static Dictionary<string, CLS_mining_scene> mining_scene { get; set; }
    //-----------------------------------------------------------------------------------------------------------------
}
    