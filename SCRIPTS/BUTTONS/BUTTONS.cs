using UnityEngine;

public class BUTTONS : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    public static GameObject canvas;

    public static GameObject map;

    public static GameObject warehouse;
    public static GameObject exchange;
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        canvas      = GameObject.Find("Canvas");
        map         = canvas.transform.Find("menu/MAP").gameObject;
        warehouse   = canvas.transform.Find("menu/WAREHOUSE").gameObject;
        exchange    = canvas.transform.Find("menu/WAREHOUSE/exchange").gameObject;
    }
    //-----------------------------------------------------------------------------------------------------------------
}
