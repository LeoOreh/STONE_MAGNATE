using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

public class RES_DATA_SV : RES_DATA
{
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
    // ������������� ������
    public static void O(string S)
    {
        //----------------------------------------------
        string pth                          = Application.persistentDataPath + "/sv_res.ololo";
        //----------------------------------------------





        //----------------------------------------------
        // ����������� � ��������� ������
        if (S == "SET")
        {
            string jsonString               = JsonConvert.SerializeObject(RES, Formatting.Indented);
            jsonString                      = Encryption_JSON.En(jsonString);
            File.WriteAllText(pth, jsonString);
        }
        //----------------------------------------------






        //----------------------------------------------
        else
        // �������� � ������������ ������
        if (S == "GET")
        {
            if (File.Exists(pth))
            {
                string encryptedJsonString  = File.ReadAllText(pth);
                string jsonString           = Encryption_JSON.De(encryptedJsonString);
                RES                         = JsonConvert.DeserializeObject<Dictionary<string, STRCT_RES_TYP>>(jsonString);

                // �������� �������
                foreach (KeyValuePair<string, STRCT_RES_TYP> r in RES) { r.Value.TS_GET = 0; }
            }
        }
        //----------------------------------------------
    }
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
}
