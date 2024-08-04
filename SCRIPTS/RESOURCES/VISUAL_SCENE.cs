using UnityEngine;

public class VISUAL_SCENE : RESOURCE_SCENE
{
    static int an = 1;
    public static void ANIM (string res)
    {
        foreach(string s in mining_scene[GL.name_mining_scene].typs_mining_resource) 
        { 
            if(s == res) 
            {
                mining_scene[GL.name_mining_scene].animator_mining.SetTrigger("KICK_" + an);
                an++;
                if(an > 3) { an = 1; }
            }
        }
        
    }
}
