using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
//-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        // ���������� �������
        resources = new Dictionary<string, CLS_resource>()
        {
            ["MONEY"] = new CLS_resource(0, 0, 0, 0),  // ������ �� ����������
            ["BLACK"] = new CLS_resource(1, 0, 1.0f, 1),
            ["GLASS"] = new CLS_resource(1, 0, 1.8f, 1),
            ["GREEN"] = new CLS_resource(1, 0, 2.5f, 1),
            ["TREE"]  = new CLS_resource(1, 0, 1.4f, 1)
        };



        // ����� ���������� �������� (����� ���� �������� ����� �����)
        // ����- �������� �����, ��������- �������� � ���� �������� (�� ����)
        mining_scene = new Dictionary<string, CLS_resource_scene>()
        {
            ["BLACK"]               = new CLS_resource_scene ("BLACK",                new string[] { "BLACK" }          ),
            ["GLASS"]               = new CLS_resource_scene ("GLASS",                new string[] { "GLASS" }          ),
            ["GREEN"]               = new CLS_resource_scene ("GREEN",                new string[] { "GREEN" }          ),
            ["combo_GREEN_GLASS"]   = new CLS_resource_scene ("combo_GREEN_GLASS",    new string[] { "GREEN", "GLASS" } ),
            ["TREE"]                = new CLS_resource_scene ("TREE",                 new string[] { "TREE"  }          ),
        };



        // �������� ����������� ������ � �������� (�� json)
        RESOURCE_SAVE.GET();
    }
}
//-----------------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource
{
    public int   activity_status;        // 0- ��������� 1- ����� �������� ������� 2- ����������
    public int   score;                  // ����� ��������
    public float time_get;               // ����� ���������� ���������
    public float time_interval;          // �������� ����� �����������
    public int   value_get_resources;    // ������� ��������

    public CLS_resource(int _activity_status, int _score, float _time_interval, int _value_get_resources)
    {
        activity_status     = _activity_status;
        score               = _score;
        time_get            = 1;
        time_interval       = _time_interval;
        value_get_resources = _value_get_resources;
    }
}
//-----------------------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource_scene
{
    public string[]   typs_mining_resource;   // ���� ���������� ��������
    public GameObject GO_Canvas;              // ������ � ����� � ������
    public Animator   animator_mining;        // ������ � ��������� ������

    public CLS_resource_scene(string _name, string[] _typs_mining_resource)
    {
        typs_mining_resource = _typs_mining_resource;
        GO_Canvas            = GameObject.Find("/Canvas/scene_resources_typ/" + _name);
        animator_mining      = GO_Canvas.transform.Find("visual").GetComponent<Animator>();
    }
}
//-----------------------------------------------------------------------------------------------------------------
