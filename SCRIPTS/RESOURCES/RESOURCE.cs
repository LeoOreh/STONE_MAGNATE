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
        {"MONEY", new CLS_resource(0, 0, 0,    0) },  // ������ �� ����������
        {"BLACK", new CLS_resource(1, 0, 1.0f, 1) },
        {"GLASS", new CLS_resource(1, 0, 1.8f, 1) },
        {"GREEN", new CLS_resource(1, 0, 2.5f, 1) },
        {"TREE",  new CLS_resource(1, 0, 1.4f, 1) },
    };

    public class CLS_resource
    {
        public int          activity_status;        // 0- ��������� 1- ����� �������� ������� 2- ����������
        public int          score;                  // ����� ��������
        public float        time_get;               // ����� ���������� ���������
        public float        time_interval;          // �������� ����� �����������
        public int          value_get_resources;    // ������� ��������

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
}
