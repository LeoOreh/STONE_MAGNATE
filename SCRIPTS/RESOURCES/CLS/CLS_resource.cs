using Newtonsoft.Json;
using UnityEngine;

public class CLS_resource
{
    //-----------------------------------------------------------------------------------------------------------------
    [JsonProperty] public string name                   { get; set; }
    [JsonProperty] public int    activity_status        { get; set; }    // 0- ��������� 1- ����� �������� ������� 2- ����������
    [JsonProperty] public int    score                  { get; set; }    // ���������� ��������
    [JsonProperty] public int    score_max              { get; set; }
    [JsonProperty] public float  time_get               { get; set; }    // ����� ���������� ���������
    [JsonProperty] public float  time_interval          { get; set; }    // �������� ����� �����������
    [JsonProperty] public int    value_get_resources    { get; set; }    // ������� ��������
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
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
    //-----------------------------------------------------------------------------------------------------------------
}
