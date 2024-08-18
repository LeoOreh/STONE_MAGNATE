using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RESOURCE_SET_SLOT : UI_RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // УСТАНОВИТЬ ИКОНКИ РЕСУРСОВ
    public static void SET(int count_active_slots)
    {
        foreach (KeyValuePair<int, UI_RESOURCE_SLOT> slt in resource_UI)
        {
            if (slt.Key <= count_active_slots)
            {
                slt.Value.slot.SetActive(true);

                // определяем имя для слота
                string res_name = mining_scene[GL.name_mining_scene].typs_mining[slt.Key].name;
                slt.Value.name = res_name;

                //включаем нужную иконку из массива иконок
                Sprite sprite = Resources.Load<Sprite>("ICONs_TYP/icon_" + res_name);
                slt.Value.icon.sprite = sprite;
            }
            else
            { slt.Value.slot.SetActive(false); }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
