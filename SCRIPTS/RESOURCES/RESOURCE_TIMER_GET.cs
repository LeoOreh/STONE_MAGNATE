using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_TIMER_GET : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // опнбепйю рюилепнб онксвемхъ пеяспянб
    public static void CHECK()
    {
        foreach(KeyValuePair<string, CLS_resource> res in resources)
        {
            if (Time.time > res.Value.time_get)
            {
                resources[res.Key].time_get = Time.time + resources[res.Key].time_interval;
                resources[res.Key].score   += resources[res.Key].value_get_resources;

                // намнбхрэ гмювемхе UI
                UI_RESOURCE.UpdateUIValues();

                // ЮМХЛЮЖХХ
                VISUAL_SCENE.ANIM(res.Key);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
