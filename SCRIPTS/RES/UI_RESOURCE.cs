using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RESOURCE : RES_DATA
{
    //-----------------------------------------------------------------------------------------------------------------
    protected static TextMeshProUGUI                  money_text;
    protected static Dictionary<int, TextMeshProUGUI> resource_texts;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // “≈ —“€ «Õ¿◊≈Õ»ﬂ –≈—”–—Œ¬
    public static void I()
    {
        money_text = GameObject.Find("/Canvas/AMOUNT/MONEY/TXT").GetComponent<TextMeshProUGUI>();

        resource_texts = new Dictionary<int, TextMeshProUGUI>()
        {
            {1, GameObject.Find("/Canvas/AMOUNT/RES/1/TXT")  .GetComponent<TextMeshProUGUI>()},
            {2, GameObject.Find("/Canvas/AMOUNT/RES/2/TXT")  .GetComponent<TextMeshProUGUI>()},
            {3, GameObject.Find("/Canvas/AMOUNT/RES/3/TXT")  .GetComponent<TextMeshProUGUI>()},
        };
    }
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // ”—“¿ÕŒ¬»“‹ » ŒÕ » –≈—”–—Œ¬
    public static void SET_ICONS(int count_active_slots)
    {
        foreach(KeyValuePair<int, TextMeshProUGUI> text in resource_texts)
        {
            if(text.Key <= count_active_slots) 
            { 
                text.Value.transform.parent.gameObject.SetActive(true);
             
                //‚ÍÎ˛˜‡ÂÏ ÌÛÊÌÛ˛ ËÍÓÌÍÛ Ï‡ÒÒË‚‡ ËÍÓÌÓÍ
                Sprite sprite = Resources.Load<Sprite>("Canvas/AMOUNT/RES/ICONs_TYP/icon_" + GL.typs_mining_resource[text.Key - 1]);
                text.Value.transform.parent.Find("ICON_TYP").GetComponent<Image>().sprite = sprite;
            }
            else
            { text.Value.transform.parent.gameObject.SetActive(false); }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // Œ¡ÕŒ¬»“‹ «Õ¿◊≈Õ»≈ ¬—≈’ –≈—”–—Œ¬ (◊“Œ¡€ —–¿«” Œ¡ÕŒ¬»À»—‹ «Õ¿◊≈Õ»ﬂ œ–» —Ã≈Õ≈ —÷≈Õ€)
    public static void UpdateUIValues()
    {
        money_text.text = score_money.ToString();

        int n = 1;
        foreach (string typ in GL.typs_mining_resource)
        {
            resource_texts[n].text = resources[typ].score.ToString();
            n++;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
