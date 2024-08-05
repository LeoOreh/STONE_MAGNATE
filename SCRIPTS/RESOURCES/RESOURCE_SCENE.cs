using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_SCENE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // юйрсюкхгхпсел яжемс нрмняхрекэмн нрйпшрнцн леярю днашвх пеяспянб
    public static void SET(string name_scene)
    {
        GL.name_mining_scene = name_scene;


        // деюйрхбхпсел бяе яжемш CANVAS
        foreach (KeyValuePair<string, CLS_mining_scene> R in mining_scene)
        { R.Value.GO_Canvas_typ_mining.SetActive(false); }

        // юйрхбхпсел мсфмши CANVAS
        mining_scene[GL.name_mining_scene].GO_Canvas_typ_mining.SetActive(true);



        // юйрхбхпсел UI
        UI_RESOURCE_ICON.SET_ICONS(mining_scene[GL.name_mining_scene].typs_mining.Length);

        // намнбхрэ гмювемхе UI
        UI_RESOURCE.UpdateUIValues();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
