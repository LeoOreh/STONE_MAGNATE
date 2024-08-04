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
    // ���� �������
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
    // �������� �������� ���� �������� (����� ����� ���������� �������� ��� ����� �����)
    public static void UpdateUIValues()
    {
        money_text.text = all_money.ToString();

        int n = 1;
        foreach (string typ in mining_scene[GL.name_mining_scene].typs_mining_resource)
        {
            resource_texts[n].text = resources[typ].score.ToString();
            n++;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
