using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_TIMER_GET : RESOURCE
{
    static float timer_check;
    //-----------------------------------------------------------------------------------------------------------------
    // �������� �������� ��������� ��������
    public static void CHECK()
    {
        if (Time.time > timer_check)
        {
            timer_check = Time.time + 0.2f;

            foreach (KeyValuePair<string, CLS_mining_scene> scene in mining_scene)
            {
                foreach (KeyValuePair<int, CLS_resource> res in scene.Value.typs_mining)
                {
                    // ���� ��������
                    if(res.Value.score >= res.Value.score_max) { continue; }


                    // ������ �� ������������
                    if (res.Value.activity_status == 0) { continue; }


                    // ������ ������ ������
                    else
                    if (res.Value.activity_status == 1)
                    {
                        if (res.Value != mining_scene[GL.name_mining_scene].typs_mining[1]) { continue; }
                        if (res.Value.time_get != 0) { continue; }

                        res.Value.time_get = Time.time;
                        res.Value.score += res.Value.value_get_resources;
                    }


                    // �������������� ������ + ������
                    else
                    if (res.Value.activity_status == 2)
                    {
                        if (Time.time < res.Value.time_get) { continue; }

                        res.Value.time_get = Time.time + res.Value.time_interval;
                        res.Value.score += res.Value.value_get_resources;
                    }


                    // �������� �������� UI
                    UI_RESOURCE.UpdateUIValues();

                    // ��������
                    VISUAL_SCENE.ANIM(scene.Key, res.Value.name);
                }
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
