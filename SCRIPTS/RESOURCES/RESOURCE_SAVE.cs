using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

// ÿ»‘–Œ¬¿ÕÕ€≈ ƒ¿ÕÕ€≈
public class RESOURCE_SAVE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    static string path = Application.persistentDataPath + "/sv_res.ololo";
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void GET()
    {
        if (File.Exists(path) == false) { return; }
     
        string encryptedJsonString  = File.ReadAllText(path);
        string jsonString           = Encryption_JSON.De(encryptedJsonString);
        var js                      = JsonConvert.DeserializeObject<Dictionary<string, CLS_resource>>(jsonString);

        // Œ¡Õ”À»“‹ “¿…Ã≈–€
        foreach (KeyValuePair<string, CLS_resource> r in js) 
        { resources[r.Key].score = r.Value.score; }

    }
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void SET()
    {
        string jsonString               = JsonConvert.SerializeObject(resources, Formatting.Indented);
        File.WriteAllText(Application.persistentDataPath + "/sv_res.json", jsonString);
        jsonString                      = Encryption_JSON.En(jsonString);
        File.WriteAllText(path, jsonString);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
