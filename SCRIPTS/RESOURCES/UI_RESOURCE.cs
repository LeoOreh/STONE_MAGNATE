using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RESOURCE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    protected static TextMeshProUGUI                  money_text;
    protected static Dictionary<int, TextMeshProUGUI> resource_texts;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // хмхр рейярнб
    public static void I()
    {
        money_text = GameObject.Find("/Canvas/Resources/Money/TXT").GetComponent<TextMeshProUGUI>();

        resource_texts = new Dictionary<int, TextMeshProUGUI>()
        {
            {1, GameObject.Find("/Canvas/Resources/slots/1/TXT")  .GetComponent<TextMeshProUGUI>()},
            {2, GameObject.Find("/Canvas/Resources/slots/2/TXT")  .GetComponent<TextMeshProUGUI>()},
            {3, GameObject.Find("/Canvas/Resources/slots/3/TXT")  .GetComponent<TextMeshProUGUI>()},
        };
    }
    //-----------------------------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------------------------
    // намнбхрэ гмювемхе бяеу пеяспянб (врнаш япюгс намнбхкхяэ гмювемхъ опх ялеме яжемш)
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
