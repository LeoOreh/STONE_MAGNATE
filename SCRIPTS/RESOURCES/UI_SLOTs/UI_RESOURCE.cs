using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RESOURCE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    protected static TextMeshProUGUI                   money_text;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // »Õ»“ “≈ —“Œ¬
    public static void I()
    {
        money_text = GameObject.Find("/Canvas/show_count_resources/Money/TXT").GetComponent<TextMeshProUGUI>();

        resource_UI = new Dictionary<int, CLS_UI_RESOURCE_SLOT>();
        for (int i = 1; i <= 5; i++) { resource_UI.Add(i, new CLS_UI_RESOURCE_SLOT(i)); }      
    }
    //-----------------------------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------------------------
    // Œ¡ÕŒ¬»“‹ «Õ¿◊≈Õ»≈ ¬—≈’ –≈—”–—Œ¬ (◊“Œ¡€ —–¿«” Œ¡ÕŒ¬»À»—‹ «Õ¿◊≈Õ»ﬂ œ–» —Ã≈Õ≈ —÷≈Õ€)
    public static void UpdateUIValues()
    {
        money_text.text = WAREHOUSE.warehouses_typs["MONEY"].score.ToString();

        int n = 1;
        foreach (KeyValuePair<int, CLS_resource> typ in mining_scene[GL.name_mining_scene].typs_mining)
        {
            resource_UI[n].text.text       = typ.Value.score.ToString();
            resource_UI[n].fill.fillAmount = (float)typ.Value.score / (float)typ.Value.score_max;

            n++;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
