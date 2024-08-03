using System.Collections.Generic;
using UnityEngine;

public class SCENE_MINING : RES_DATA
{
    //-----------------------------------------------------------------------------------------------------------------
    // ����� ���������� �������� (����� ���� �������� ����� �����)
    // ����- �������� �����, ��������- �������� � ���� �������� (�� ����)
    static Dictionary<string, CLS_resource_scene> mining_scene = new Dictionary<string, CLS_resource_scene>()
    {
        {"BLACK",               new CLS_resource_scene ("BLACK",                new string[] { "BLACK" }          ) },
        {"GLASS",               new CLS_resource_scene ("GLASS",                new string[] { "GLASS" }          ) },
        {"GREEN",               new CLS_resource_scene ("GREEN",                new string[] { "GREEN" }          ) },
        {"combo_GREEN_GLASS",   new CLS_resource_scene ("combo_GREEN_GLASS",    new string[] { "GREEN", "GLASS" } ) },
        {"TREE",                new CLS_resource_scene ("TREE",                 new string[] { "TREE"  }          ) },
    };
    public class CLS_resource_scene
    {
        public string       name;                   // ��� ����� � ���������
        public string[]     typs_mining_resource;   // ���� ���������� ��������
        public GameObject   GO_Canvas;              // ������ � ����� � ������

        public CLS_resource_scene(string _name, string[] _typs_mining_resource)
        {
            name                    = _name;
            typs_mining_resource    = _typs_mining_resource;
            GO_Canvas               = GameObject.Find("/Canvas/RES_TYP/" + _name);
        }
    }
    //-----------------------------------------------------------------------------------------------------------------





    //-----------------------------------------------------------------------------------------------------------------
    // ������������� ����� ������������ ����� ������ ��������
    public static void SET()
    {
        // ���� ���������� �������� �� ���� �����
        // TYP_MINING_SCENE: ��� ������ �� ����� /���/ ��� ������ �� ����������� ������ � �������
        GL.typs_mining_resource = mining_scene[GL.name_mining_scene].typs_mining_resource;



        // ������������ ��� ����� CANVAS
        foreach (KeyValuePair<string, CLS_resource_scene> R in mining_scene)
        { R.Value.GO_Canvas.SetActive(false); }

        // ���������� ������ CANVAS
        mining_scene[GL.name_mining_scene].GO_Canvas.SetActive(true);



        // ���������� UI
        UI_RESOURCE.SET_ICONS(GL.typs_mining_resource.Length);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
