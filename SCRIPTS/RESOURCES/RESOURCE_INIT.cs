using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_INIT : RESOURCE
{
//-----------------------------------------------------------------------------------------------------------------
    public static void I()
    {
        //----------------------------------------------------------------------------------
        // ����� ���������� �������� (����� ���� �������� ����� �����)
        // ����� �������� �����, ����� �������� �� ����� � "mining_scene" � "MAP/WINDOW"
        // ������� ����� � �������
        mining_scene = new Dictionary<string, CLS_mining_scene>();

        // �� ����� ��������� ���� �������� (�� 5)
        Add_Resource_in_scene();
        void Add_Resource_in_scene()
        {
            foreach (KeyValuePair<string, string[]> list in list_mining_scene)
            {
                mining_scene.Add(list.Key, new CLS_mining_scene(list.Key, add_typs_minig_scene(list_mining_scene[list.Key])));
            }

            CLS_resource[] add_typs_minig_scene(string[] nm)
            {
                CLS_resource[] copy = new CLS_resource[nm.Length];
                for (int i = 0; i < nm.Length; i++)
                {
                    copy[i]                     = new CLS_resource();                   
                    copy[i].name                = resources_typs[nm[i]].name;
                    copy[i].activity_status     = resources_typs[nm[i]].activity_status;
                    copy[i].time_interval       = resources_typs[nm[i]].time_interval;
                    copy[i].value_get_resources = resources_typs[nm[i]].value_get_resources;
                    copy[i].score_max           = resources_typs[nm[i]].score_max;
                }
                return copy;
            }
        }
        //----------------------------------------------------------------------------------





        // �������� ����������� ������ � �������� (�� json)
        RESOURCE_SAVE.GET();
    }
}
//-----------------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------------
public class CLS_resource
{
    [JsonProperty] public string name                   { get; set; }
    [JsonProperty] public int    activity_status        { get; set; }    // 0- ��������� 1- ����� �������� ������� 2- ����������
    [JsonProperty] public int    score                  { get; set; }    // ���������� ��������
    [JsonProperty] public int    score_max              { get; set; }

    [JsonProperty] public float  time_get               { get; set; }    // ����� ���������� ���������
    [JsonProperty] public float  time_interval          { get; set; }    // �������� ����� �����������
    [JsonProperty] public int    value_get_resources    { get; set; }    // ������� ��������

    public CLS_resource(string _name, int _activity_status, float _time_interval, int _value_get_resources)
    {
        name                = _name;
        activity_status     = _activity_status;
        time_get            = 1;
        score_max           = 100;
        time_interval       = _time_interval;
        value_get_resources = _value_get_resources;
    }
    public CLS_resource() { }
}
//-----------------------------------------------------------------------------------------------------------------


//-----------------------------------------------------------------------------------------------------------------
public class CLS_mining_scene
{
    [JsonProperty] public CLS_resource[] typs_mining          { get; set; }  // ���� ���������� ��������
    [JsonIgnore]   public GameObject     GO_Canvas_typ_mining { get; set; }  // ������ � ����� � ������
    [JsonIgnore]   public Animator       animator_mining      { get; set; }  // ������ � ��������� ������

    public CLS_mining_scene(string _name, CLS_resource[]  _typs_mining)
    {
        typs_mining          = _typs_mining;
        GO_Canvas_typ_mining = GameObject.Find("/Canvas").transform.Find("mining_scene/" + _name).gameObject;
        animator_mining      = GO_Canvas_typ_mining.transform.Find("visual").GetComponent<Animator>();
    }
    public CLS_mining_scene() { }
}
//-----------------------------------------------------------------------------------------------------------------
