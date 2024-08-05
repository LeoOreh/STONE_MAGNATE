using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
//-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        // ����� ���������� �������� (����� ���� �������� ����� �����)
        // ����- �������� �����, ��������- �������� � ���� �������� (�� ����)
        mining_scene = new Dictionary<string, CLS_resource_scene>()
        {
            ["BLACK"]               
            = new CLS_resource_scene ("BLACK", new CLS_resource[]             { new CLS_resource("BLACK", 1, 0, 1.0f, 1) }),

            ["GLASS"]               
            = new CLS_resource_scene ("GLASS", new CLS_resource[]            {  new CLS_resource("GLASS", 1, 0, 1.8f, 1) }),

            ["GREEN"]               
            = new CLS_resource_scene ("GREEN", new CLS_resource[]             { new CLS_resource("GREEN", 1, 0, 2.5f, 1) }),

            ["combo_GREEN_GLASS"]   
            = new CLS_resource_scene ("combo_GREEN_GLASS", new CLS_resource[] { new CLS_resource("GREEN", 1, 0, 2.5f, 1),
                                                                                new CLS_resource("GLASS", 1, 0, 1.8f, 1) }),

            ["TREE"]                
            = new CLS_resource_scene ("TREE", new CLS_resource[]              { new CLS_resource("TREE", 1, 0, 1.4f, 1) }),
        };



        // �������� ����������� ������ � �������� (�� json)
        RESOURCE_SAVE.GET();
    }
}
//-----------------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource
{
    [JsonProperty]
    public string name;
    [JsonProperty]
    public int   activity_status        { get; set; }    // 0- ��������� 1- ����� �������� ������� 2- ����������
    [JsonProperty]
    public int   score                  { get; set; }    // ����� ��������
    [JsonProperty]
    public float time_get               { get; set; }    // ����� ���������� ���������
    [JsonProperty]
    public float time_interval          { get; set; }    // �������� ����� �����������
    [JsonProperty]
    public int   value_get_resources    { get; set; }    // ������� ��������

    public CLS_resource(string _name, int _activity_status, int _score, float _time_interval, int _value_get_resources)
    {
        name = _name;
        activity_status     = _activity_status;
        score               = _score;
        time_get            = 1;
        time_interval       = _time_interval;
        value_get_resources = _value_get_resources;
    }
    public CLS_resource() { }
}
//-----------------------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource_scene
{
    [JsonProperty]
    public CLS_resource[] resource;   // ���� ���������� ��������
    [JsonIgnore]
    public GameObject     GO_Canvas;              // ������ � ����� � ������
    [JsonIgnore]
    public Animator       animator_mining;        // ������ � ��������� ������

    public CLS_resource_scene(string _name, CLS_resource[]  _resource)
    {
        resource             = _resource;
        GO_Canvas            = GameObject.Find("/Canvas/scene_resources_typ/" + _name);
        animator_mining      = GO_Canvas.transform.Find("visual").GetComponent<Animator>();
    }
    public CLS_resource_scene() { }
}
//-----------------------------------------------------------------------------------------------------------------
