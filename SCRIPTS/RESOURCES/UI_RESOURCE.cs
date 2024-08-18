using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_RESOURCE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    protected static TextMeshProUGUI                  money_text;

    protected static Dictionary<int, UI_RESOURCE_SLOT> resource_UI;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // ���� �������
    public static void I()
    {
        money_text = GameObject.Find("/Canvas/show_count_resources/Money/TXT").GetComponent<TextMeshProUGUI>();

        resource_UI = new Dictionary<int, UI_RESOURCE_SLOT>();
        for (int i = 1; i <= 5; i++) { resource_UI.Add(i, new UI_RESOURCE_SLOT(i)); }      
    }
    //-----------------------------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------------------------
    // �������� �������� ���� �������� (����� ����� ���������� �������� ��� ����� �����)
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

    public class UI_RESOURCE_SLOT
    {
        public string name;
        public GameObject slot;
        public TextMeshProUGUI text;
        public Image icon;
        public Image fill;

        public UI_RESOURCE_SLOT(int n)
        {
            string pth = "/Canvas/show_count_resources/slots/" + n;

            name = "";
            slot = GameObject.Find(pth);
            text = GameObject.Find(pth + "/TXT")              .GetComponent<TextMeshProUGUI>();
            fill = GameObject.Find(pth + "/visual_fill/fill") .GetComponent<Image>();
            icon = GameObject.Find(pth + "/icon")             .GetComponent<Image>();
        }
    }
}
