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

            Dictionary<int, CLS_resource> add_typs_minig_scene(string[] nm)
            {
                Dictionary<int, CLS_resource> copy = new Dictionary<int, CLS_resource>();
                int n = 1;
                foreach (string str in nm)
                {
                    copy.Add(n, new CLS_resource());
                    copy[n]                     = new CLS_resource();                   
                    copy[n].name                = resources_typs[str].name;
                    copy[n].activity_status     = resources_typs[str].activity_status;
                    copy[n].time_interval       = resources_typs[str].time_interval;
                    copy[n].value_get_resources = resources_typs[str].value_get_resources;
                    copy[n].score_max           = resources_typs[str].score_max;
                    n++;
                }
                return copy;
            }
        }
        //----------------------------------------------------------------------------------





        // �������� ����������� ������ � �������� (�� json)
        SAVE_RESOURCE.GET();
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
    [JsonProperty] public Dictionary<int, CLS_resource> typs_mining          { get; set; }  // ���� ���������� ��������
    [JsonIgnore]   public GameObject                    GO_Canvas_typ_mining { get; set; }  // ������ � ����� � ������
    [JsonIgnore]   public Animator                      animator_mining      { get; set; }  // ������ � ��������� ������

    public CLS_mining_scene(string _name, Dictionary<int, CLS_resource> _typs_mining)
    {
        typs_mining          = _typs_mining;
        GO_Canvas_typ_mining = GameObject.Find("/Canvas").transform.Find("mining_scene/" + _name).gameObject;
        animator_mining      = GO_Canvas_typ_mining.transform.Find("visual").GetComponent<Animator>();
    }
    public CLS_mining_scene() { }
}
//-----------------------------------------------------------------------------------------------------------------
