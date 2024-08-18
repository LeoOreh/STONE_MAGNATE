using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

// ШИФРОВАННЫЕ ДАННЫЕ
public class SAVE_RESOURCE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    static string path      = Application.persistentDataPath + "/sv_res.ololo";
    static string path_JSN  = Application.persistentDataPath + "/sv_res.json";
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void GET()
    {
        Dictionary<string, CLS_mining_scene> js;
        if (GL.TST_____OPEN_JSON == false)
        {
            if (File.Exists(path) == false) { return; }
            string encryptedJsonString = File.ReadAllText(path);
            string jsonString = Encryption_JSON.De(encryptedJsonString);
            js = JsonConvert.DeserializeObject<Dictionary<string, CLS_mining_scene>>(jsonString);
        }
        else
        {
            if (File.Exists(path_JSN) == false) { return; }
            // нижние две строчик удалить, а выше открыть
            string encryptedJsonString = File.ReadAllText(path_JSN);
            js = JsonConvert.DeserializeObject<Dictionary<string, CLS_mining_scene>>(encryptedJsonString);
        }





        // УСТАНОВИТЬ ПОЛУЧЕННЫЕ ДАННЫЕ О РЕСУРСАХ НА СЦЕНАХ
        foreach (KeyValuePair<string, CLS_mining_scene> scene in js)
        {
            for (int k = 1; k <= scene.Value.typs_mining.Count; k++)
            {
                mining_scene[scene.Key].typs_mining[k].activity_status      = scene.Value.typs_mining[k].activity_status;
                mining_scene[scene.Key].typs_mining[k].score                = scene.Value.typs_mining[k].score;
                mining_scene[scene.Key].typs_mining[k].score_max            = scene.Value.typs_mining[k].score_max;
                mining_scene[scene.Key].typs_mining[k].time_interval        = scene.Value.typs_mining[k].time_interval;            
                mining_scene[scene.Key].typs_mining[k].value_get_resources  = scene.Value.typs_mining[k].value_get_resources;
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void SET()
    {
        string jsonString               = JsonConvert.SerializeObject(mining_scene, Formatting.Indented);
        File.WriteAllText(path_JSN, jsonString);
        jsonString                      = Encryption_JSON.En(jsonString);
        File.WriteAllText(path, jsonString);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
