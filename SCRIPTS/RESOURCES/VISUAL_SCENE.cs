using System.Collections.Generic;
using UnityEngine;

public class VISUAL_SCENE : RESOURCE_SCENE
{
    //-----------------------------------------------------------------------------------------------------------------
    static int an = 1;
    //-----------------------------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------------------------
    public static void ANIM (string scene, string res)
    {
        if (scene == GL.name_mining_scene)
        {
            foreach (KeyValuePair<int, CLS_resource> s in mining_scene[GL.name_mining_scene].typs_mining)
            {
                if (s.Value.name != res) { continue; }

                mining_scene[GL.name_mining_scene].animator_mining.SetTrigger("KICK_" + an);
                an++;
                if (an > 3) { an = 1; }
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
