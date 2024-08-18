using UnityEngine;

public class UI_RESOURCE_COLLECT_BUTTON : UI_RESOURCE
{
    public void COLLECT_BUTTON(int number_slot)
    {
        Debug.Log(resource_UI[number_slot].name);
        Debug.Log(GL.name_mining_scene);
        Debug.Log(mining_scene[GL.name_mining_scene].typs_mining[number_slot-1].name);
    }
}
