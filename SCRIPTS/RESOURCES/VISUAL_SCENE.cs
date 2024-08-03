using UnityEngine;

public class VISUAL_SCENE : MonoBehaviour
{
    static int an = 1;
    public static void ANIM (string res)
    {
        foreach(string s in GL.typs_mining_resource) 
        { 
            if(s == res) 
            { 
                GameObject.Find("/Canvas/scene_resources_typ/" + GL.name_mining_scene + "/visual").GetComponent<Animator>().SetTrigger("KICK_" + an); 
                an++;
                if(an > 3) { an = 1; }
            }
        }
        
    }
}
