using UnityEngine;

public class BUTTONS : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    public static GameObject canvas;
    public static GameObject map;
    public static GameObject sale;
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        canvas  = GameObject.Find("Canvas");
        map     = canvas.transform.Find("menu/MAP").gameObject;
        sale    = canvas.transform.Find("menu/SALE").gameObject;
    }
    //-----------------------------------------------------------------------------------------------------------------
}
