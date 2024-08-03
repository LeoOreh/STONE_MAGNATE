using UnityEngine;
using System.Collections.Generic;

public class RESOURCE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    // всего денег
    protected static int score_money;
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    // ДОБЫВАЕМЫЕ РЕСУРСЫ
    protected static Dictionary<string, CLS_resource> resources = new Dictionary<string, CLS_resource>()
    {
        {"BLACK", new CLS_resource(0, 1.0f, 1) },
        {"GLASS", new CLS_resource(0, 1.8f, 1) },
        {"GREEN", new CLS_resource(0, 2.5f, 1) },
        {"TREE",  new CLS_resource(0, 1.4f, 1) },
    };

    public class CLS_resource
    {
        public int          score;                  // всего ресурсов
        public float        time_get;               // время следующего получения
        public float        time_interval;          // интервал между получениями
        public int          value_get_resources;    // скольуо получаем

        public CLS_resource(int _score, float _time_interval, int _value_get_resources)
        {
            score               = _score;
            time_get            = 0;
            time_interval       = _time_interval;
            value_get_resources = _value_get_resources;
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
