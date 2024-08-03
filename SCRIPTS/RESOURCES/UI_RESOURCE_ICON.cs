using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RESOURCE_ICON : UI_RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // УСТАНОВИТЬ ИКОНКИ РЕСУРСОВ
    public static void SET_ICONS(int count_active_slots)
    {
        foreach (KeyValuePair<int, TextMeshProUGUI> text in resource_texts)
        {
            if (text.Key <= count_active_slots)
            {
                text.Value.transform.parent.gameObject.SetActive(true);

                //включаем нужную иконку массива иконок
                Sprite sprite = Resources.Load<Sprite>("Canvas/AMOUNT/RES/ICONs_TYP/icon_" + GL.typs_mining_resource[text.Key - 1]);
                text.Value.transform.parent.Find("icon").GetComponent<Image>().sprite = sprite;
            }
            else
            { text.Value.transform.parent.gameObject.SetActive(false); }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
