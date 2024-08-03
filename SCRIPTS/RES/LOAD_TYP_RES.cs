using System.Collections.Generic;
using UnityEngine;

public class LOAD_TYP_RES : RES_DATA
{
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
    // ����� ���������� �������� (����� ���� �������� ����� �����)
    // ����- �������� �����, ��������- ���� �������� (�� ����)
    static Dictionary<string, SRTCT_RES_TYPs> TYPs_RES = new Dictionary<string, SRTCT_RES_TYPs>()
    {
        {"BLACK",               new SRTCT_RES_TYPs ("BLACK",                new string[] { "BLACK" }          ) },
        {"GLASS",               new SRTCT_RES_TYPs ("GLASS",                new string[] { "GLASS" }          ) },
        {"GREEN",               new SRTCT_RES_TYPs ("GREEN",                new string[] { "GREEN" }          ) },
        {"combo_GREEN_GLASS",   new SRTCT_RES_TYPs( "combo_GREEN_GLASS",    new string[] { "GREEN", "GLASS" } ) },
    };
    public class SRTCT_RES_TYPs
    {
        public string       SCENE_NAME_TYP_RESs;    // ��� ����� � ���������
        public string[]     TYP_MINING;             // ���� ���������� ��������
        public GameObject   Canvas_RES_TYP;         // ������ � ����� � ������

        public SRTCT_RES_TYPs(string _SCENE_NAME_TYP_RESs, string[] _TYP_MINING)
        {
            SCENE_NAME_TYP_RESs = _SCENE_NAME_TYP_RESs;
            TYP_MINING          = _TYP_MINING;
            Canvas_RES_TYP      = GameObject.Find("/Canvas/RES_TYP/" + _SCENE_NAME_TYP_RESs);
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------





    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
    // ������������� ����� ������������ ����� ������ ��������
    public static void O()
    {
        //----------------------------------------------
        // ���� ���������� �������� �� ���� �����
        // TYP_MINING_SCENE: ��� ������ �� ����� /���/ ��� ������ �� ����������� ������ � �������
        GL.TYP_MINING = TYPs_RES[GL.TYP_MINING_SCENE].TYP_MINING;
        //----------------------------------------------



        //----------------------------------------------
        // ������������ ��� ����� CANVAS
        foreach (KeyValuePair<string, SRTCT_RES_TYPs> R in TYPs_RES)
        { R.Value.Canvas_RES_TYP.SetActive(false); }

        // ���������� ������ CANVAS
        TYPs_RES[GL.TYP_MINING_SCENE].Canvas_RES_TYP.SetActive(true);
        //----------------------------------------------



        //----------------------------------------------
        // ���������� UI
        UI_RES.UI_RES_ICON_INIT(GL.TYP_MINING.Length);
        //----------------------------------------------
    }
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
}
