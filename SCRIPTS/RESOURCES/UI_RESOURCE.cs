using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
        money_text = GameObject.Find("/Canvas/show_count_resources/Money/TXT").GetComponent<TextMeshProUGUI>();

        resource_texts = new Dictionary<int, TextMeshProUGUI>()
        {
            {1, GameObject.Find("/Canvas/show_count_resources/slots/1/TXT")  .GetComponent<TextMeshProUGUI>()},
            {2, GameObject.Find("/Canvas/show_count_resources/slots/2/TXT")  .GetComponent<TextMeshProUGUI>()},
            {3, GameObject.Find("/Canvas/show_count_resources/slots/3/TXT")  .GetComponent<TextMeshProUGUI>()},
            {4, GameObject.Find("/Canvas/show_count_resources/slots/4/TXT")  .GetComponent<TextMeshProUGUI>()},
            {5, GameObject.Find("/Canvas/show_count_resources/slots/5/TXT")  .GetComponent<TextMeshProUGUI>()},
        };
    }
    //-----------------------------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------------------------
    // намнбхрэ гмювемхе бяеу пеяспянб (врнаш япюгс намнбхкхяэ гмювемхъ опх ялеме яжемш)
    public static void UpdateUIValues()
    {
        money_text.text = resources_typs["MONEY"].score.ToString();

        int n = 1;
        foreach (CLS_resource typ in mining_scene[GL.name_mining_scene].typs_mining)
        {
            resource_texts[n].text = typ.score.ToString();
            n++;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
