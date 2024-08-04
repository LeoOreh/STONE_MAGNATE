using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_TIMER_GET : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // ПРОВЕРКА ТАЙМЕРОВ ПОЛУЧЕНИЯ РЕСУРСОВ
    public static void CHECK()
    {
        foreach(KeyValuePair<string, CLS_resource> res in resources)
        {
            // добыча не производится
            if (res.Value.activity_status == 0) { continue; }


            // только ручная добыча
            else
            if (res.Value.activity_status == 1)
            {
                if (res.Key != mining_scene[GL.name_mining_scene].typs_mining_resource[0]) { continue; }
                if (res.Value.time_get != 0) { continue; }

                res.Value.time_get        = Time.time;
                resources[res.Key].score += resources[res.Key].value_get_resources;
            }


            // автоматическая добыча + ручная
            else
            if (res.Value.activity_status == 2)
            {
                if (Time.time < res.Value.time_get) { continue; }

                resources[res.Key].time_get = Time.time + resources[res.Key].time_interval;
                resources[res.Key].score   += resources[res.Key].value_get_resources;
            }



            // ОБНОВИТЬ ЗНАЧЕНИЕ UI
            UI_RESOURCE.UpdateUIValues();

            // анимации
            VISUAL_SCENE.ANIM(res.Key);
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
