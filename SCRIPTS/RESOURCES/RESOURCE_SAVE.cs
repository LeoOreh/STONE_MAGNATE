using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

// ШИФРОВАННЫЕ ДАННЫЕ
public class RESOURCE_SAVE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    static string path = Application.persistentDataPath + "/sv_res.ololo";
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void GET()
    {
        Dictionary<string, CLS_resource_scene> js;
        if (GL.TST_____OPEN_JSON == false)
        {
            if (File.Exists(path) == false) { return; }
            string encryptedJsonString = File.ReadAllText(path);
            string jsonString = Encryption_JSON.De(encryptedJsonString);
            js = JsonConvert.DeserializeObject<Dictionary<string, CLS_resource_scene>>(jsonString);
        }
        else
        {
            if (File.Exists(Application.persistentDataPath + "/sv_res.json") == false) { return; }
            // нижние две строчик удалить, а выше открыть
            string encryptedJsonString = File.ReadAllText(Application.persistentDataPath + "/sv_res.json");
            js = JsonConvert.DeserializeObject<Dictionary<string, CLS_resource_scene>>(encryptedJsonString);
        }
        // АКТУАЛИЗИРОВАТЬ ДАННЫЕ
        foreach (KeyValuePair<string, CLS_resource_scene> scene in js)
        {
            for (int k = 0; k < scene.Value.resource.Length; k++)
            {
                mining_scene[scene.Key].resource[k].score = scene.Value.resource[k].score;
                mining_scene[scene.Key].resource[k].activity_status = scene.Value.resource[k].activity_status;
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void SET()
    {
        string jsonString               = JsonConvert.SerializeObject(mining_scene, Formatting.Indented);
        File.WriteAllText(Application.persistentDataPath + "/sv_res.json", jsonString);
        jsonString                      = Encryption_JSON.En(jsonString);
        File.WriteAllText(path, jsonString);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
