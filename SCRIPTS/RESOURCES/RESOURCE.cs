using UnityEngine;
using System.Collections.Generic;

public class RESOURCE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    // ����� �����
    protected static int score_money;
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    // ���������� �������
    protected static Dictionary<string, CLS_resource> resources = new Dictionary<string, CLS_resource>()
    {
        {"BLACK", new CLS_resource(0, 1.0f, 1) },
        {"GLASS", new CLS_resource(0, 1.8f, 1) },
        {"GREEN", new CLS_resource(0, 2.5f, 1) },
        {"TREE",  new CLS_resource(0, 1.4f, 1) },
    };

    public class CLS_resource
    {
        public int          score;                  // ����� ��������
        public float        time_get;               // ����� ���������� ���������
        public float        time_interval;          // �������� ����� �����������
        public int          value_get_resources;    // ������� ��������

        public CLS_resource(int _score, float _time_interval, int _value_get_resources)
        {
            score               = _score;
            time_get            = 0;
            time_interval       = _time_interval;
            value_get_resources = _value_get_resources;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    // ����� ���������� �������� (����� ���� �������� ����� �����)
    // ����- �������� �����, ��������- �������� � ���� �������� (�� ����)
    protected static Dictionary<string, CLS_resource_scene> mining_scene = new Dictionary<string, CLS_resource_scene>()
    {
        {"BLACK",               new CLS_resource_scene ("BLACK",                new string[] { "BLACK" }          ) },
        {"GLASS",               new CLS_resource_scene ("GLASS",                new string[] { "GLASS" }          ) },
        {"GREEN",               new CLS_resource_scene ("GREEN",                new string[] { "GREEN" }          ) },
        {"combo_GREEN_GLASS",   new CLS_resource_scene ("combo_GREEN_GLASS",    new string[] { "GREEN", "GLASS" } ) },
        {"TREE",                new CLS_resource_scene ("TREE",                 new string[] { "TREE"  }          ) },
    };
    public class CLS_resource_scene
    {
        public string[]   typs_mining_resource;   // ���� ���������� ��������
        public GameObject GO_Canvas;              // ������ � ����� � ������

        public CLS_resource_scene(string _name, string[] _typs_mining_resource)
        {
            typs_mining_resource = _typs_mining_resource;
            GO_Canvas            = GameObject.Find("/Canvas/RES_TYP/" + _name);
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
