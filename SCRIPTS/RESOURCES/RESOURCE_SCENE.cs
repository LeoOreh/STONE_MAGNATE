using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_SCENE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // юйрсюкхгхпсел яжемс нрмняхрекэмн леярю днашвх пеяспянб
    public static void SET()
    {
        // рхош днашбюелшу пеяспянб мю щрни яжеме
        // TYP_MINING_SCENE: ОПХ БШАНПЕ МЮ ЙЮПРЕ /ХКХ/ ОПХ ЯРЮПРЕ ХГ ЯНУПЮМЕММШУ ДЮММШУ Б ПЕЕЯРПЕ
        GL.typs_mining_resource = mining_scene[GL.name_mining_scene].typs_mining_resource;



        // деюйрхбхпсел бяе яжемш CANVAS
        foreach (KeyValuePair<string, CLS_resource_scene> R in mining_scene)
        { R.Value.GO_Canvas.SetActive(false); }

        // юйрхбхпсел мсфмши CANVAS
        mining_scene[GL.name_mining_scene].GO_Canvas.SetActive(true);



        // юйрхбхпсел UI
        UI_RESOURCE_ICON.SET_ICONS(GL.typs_mining_resource.Length);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
