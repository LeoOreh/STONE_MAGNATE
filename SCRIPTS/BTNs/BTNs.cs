using UnityEngine;

public class BTNs : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
    public static GameObject CNVS;
    public static GameObject MAP;
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
    public static void INIT()
    {
        CNVS = GameObject.Find("Canvas");
        MAP  = CNVS.transform.Find("MAP").gameObject;
    }
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
}
