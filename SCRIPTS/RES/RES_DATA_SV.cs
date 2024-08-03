using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

public class RES_DATA_SV : RES_DATA
{
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
    // «¿ÿ»‘–Œ¬¿ÕÕ€≈ ƒ¿ÕÕ€≈
    public static void O(string S)
    {
        //----------------------------------------------
        string pth                          = Application.persistentDataPath + "/sv_res.ololo";
        //----------------------------------------------





        //----------------------------------------------
        // «¿ÿ»‘–Œ¬¿“‹ » —Œ’–¿Õ»“‹ ƒ¿ÕÕ€≈
        if (S == "SET")
        {
            string jsonString               = JsonConvert.SerializeObject(RES, Formatting.Indented);
            jsonString                      = Encryption_JSON.En(jsonString);
            File.WriteAllText(pth, jsonString);
        }
        //----------------------------------------------






        //----------------------------------------------
        else
        // œŒÀ”◊»“‹ » –¿—ÿ»‘–Œ¬¿“‹ ƒ¿ÕÕ€≈
        if (S == "GET")
        {
            if (File.Exists(pth))
            {
                string encryptedJsonString  = File.ReadAllText(pth);
                string jsonString           = Encryption_JSON.De(encryptedJsonString);
                RES                         = JsonConvert.DeserializeObject<Dictionary<string, STRCT_RES_TYP>>(jsonString);

                // Œ¡Õ”À»“‹ “¿…Ã≈–€
                foreach (KeyValuePair<string, STRCT_RES_TYP> r in RES) { r.Value.TS_GET = 0; }
            }
        }
        //----------------------------------------------
    }
    //-----------------------------------------------------------------------------------------------------------------
    //-----------------------------------------------------------------------------------------------------------------
}
