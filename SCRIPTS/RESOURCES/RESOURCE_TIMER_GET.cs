using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RESOURCE_TIMER_GET : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // ПРОВЕРКА ТАЙМЕРОВ ПОЛУЧЕНИЯ РЕСУРСОВ
    public static void CHECK()
    {
        foreach(KeyValuePair<string, CLS_mining_scene> scene in mining_scene)
        {
            foreach (CLS_resource res in scene.Value.typs_mining)
            {
                // добыча не производится
                if (res.activity_status == 0) { continue; }


                // только ручная добыча
                else
                if (res.activity_status == 1)
                {
                    if (res != mining_scene[GL.name_mining_scene].typs_mining[0]) { continue; }
                    if (res.time_get != 0) { continue; }

                    res.time_get = Time.time;
                    res.score += res.value_get_resources;
                }


                // автоматическая добыча + ручная
                else
                if (res.activity_status == 2)
                {
                    if (Time.time < res.time_get) { continue; }

                    res.time_get = Time.time + res.time_interval;
                    res.score += res.value_get_resources;
                }


                // ОБНОВИТЬ ЗНАЧЕНИЕ UI
                UI_RESOURCE.UpdateUIValues();

                // анимации
                VISUAL_SCENE.ANIM(scene.Key, res.name);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
