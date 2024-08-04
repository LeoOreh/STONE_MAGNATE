using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_TIMER_GET : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // �������� �������� ��������� ��������
    public static void CHECK()
    {
        foreach(KeyValuePair<string, CLS_resource> res in resources)
        {
            // ������ �� ������������
            if (res.Value.activity_status == 0) { continue; }


            // ������ ������ ������
            else
            if (res.Value.activity_status == 1)
            {
                if (res.Key != mining_scene[GL.name_mining_scene].typs_mining_resource[0]) { continue; }
                if (res.Value.time_get != 0) { continue; }

                res.Value.time_get        = Time.time;
                resources[res.Key].score += resources[res.Key].value_get_resources;
            }


            // �������������� ������ + ������
            else
            if (res.Value.activity_status == 2)
            {
                if (Time.time < res.Value.time_get) { continue; }

                resources[res.Key].time_get = Time.time + resources[res.Key].time_interval;
                resources[res.Key].score   += resources[res.Key].value_get_resources;
            }



            // �������� �������� UI
            UI_RESOURCE.UpdateUIValues();

            // ��������
            VISUAL_SCENE.ANIM(res.Key);
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
