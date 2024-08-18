using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

public class WAREHOUSE_SAVE : WAREHOUSE
{

    //-----------------------------------------------------------------------------------------------------------------
    static string path      = Application.persistentDataPath + "/sv_wrh.ololo";
    static string path_JSN  = Application.persistentDataPath + "/sv_wrh.json";
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void GET()
    {
        Dictionary<string, CLS_warehouse> js;
        if (GL.TST_____OPEN_JSON == false)
        {
            if (File.Exists(path) == false) { return; }
            string encryptedJsonString = File.ReadAllText(path);
            string jsonString = Encryption_JSON.De(encryptedJsonString);
            js = JsonConvert.DeserializeObject<Dictionary<string, CLS_warehouse>>(jsonString);
        }
        else
        {
            if (File.Exists(path_JSN) == false) { return; }
            // нижние две строчик удалить, а выше открыть
            string encryptedJsonString = File.ReadAllText(path_JSN);
            js = JsonConvert.DeserializeObject<Dictionary<string, CLS_warehouse>>(encryptedJsonString);
        }





        // УСТАНОВИТЬ ПОЛУЧЕННЫЕ ДАННЫЕ О РЕСУРСАХ НА СЦЕНАХ
        foreach (KeyValuePair<string, CLS_warehouse> warehous in js)
        {
            warehouses_typs[warehous.Key].name  = warehous.Value.name;
            warehouses_typs[warehous.Key].score = warehous.Value.score;        
        }
    }
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public static void SET()
    {
        string jsonString = JsonConvert.SerializeObject(warehouses_typs, Formatting.Indented);
        File.WriteAllText(path_JSN, jsonString);
        jsonString = Encryption_JSON.En(jsonString);
        File.WriteAllText(path, jsonString);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
