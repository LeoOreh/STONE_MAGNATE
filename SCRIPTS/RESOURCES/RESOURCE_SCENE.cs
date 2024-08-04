using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_SCENE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // яжемш днашбюелшу пеяспянб (лнфер ашрэ мейнкэйн бхднб япюгс)
    // йкчв- мюгбюмхе яжемш, гмювемхе- мюгбюмхе х бхдш пеяспянб (дн рпеу)
    protected static Dictionary<string, CLS_resource_scene> mining_scene = new Dictionary<string, CLS_resource_scene>()
    {
        {"BLACK",               new CLS_resource_scene ("BLACK",                new string[] { "BLACK" }          ) },
        {"GLASS",               new CLS_resource_scene ("GLASS",                new string[] { "GLASS" }          ) },
        {"GREEN",               new CLS_resource_scene ("GREEN",                new string[] { "GREEN" }          ) },
        {"combo_GREEN_GLASS",   new CLS_resource_scene ("combo_GREEN_GLASS",    new string[] { "GREEN", "GLASS" } ) },
        {"TREE",                new CLS_resource_scene ("TREE",                 new string[] { "TREE"  }          ) },
    };
    public class CLS_resource_scene
    {
        public string[]     typs_mining_resource;   // РХОШ ДНАШБЮЕЛШУ ПЕЯСПЯНБ
        public GameObject   GO_Canvas;              // ЯЯШКЙЮ Й АКНЙС Б ЙЮМБЮЯ
        public Animator     animator_mining;        // ЯЯШКЙЮ Й ЮМХЛЮРНПС ДНАШВХ

        public CLS_resource_scene(string _name, string[] _typs_mining_resource)
        {
            typs_mining_resource = _typs_mining_resource;
            GO_Canvas            = GameObject.Find("/Canvas/scene_resources_typ/" + _name);
            animator_mining      = GO_Canvas.transform.Find("visual").GetComponent<Animator>();
        }
    }
    //-----------------------------------------------------------------------------------------------------------------





    //-----------------------------------------------------------------------------------------------------------------
    // юйрсюкхгхпсел яжемс нрмняхрекэмн нрйпшрнцн леярю днашвх пеяспянб
    public static void SET(string name_scene)
    {
        GL.name_mining_scene = name_scene;

        // рхош днашбюелшу пеяспянб мю щрни яжеме
        // TYP_MINING_SCENE: ОПХ БШАНПЕ МЮ ЙЮПРЕ /ХКХ/ ОПХ ЯРЮПРЕ ХГ ЯНУПЮМЕММШУ ДЮММШУ Б ПЕЕЯРПЕ
        GL.typs_mining_resource = mining_scene[GL.name_mining_scene].typs_mining_resource;



        // деюйрхбхпсел бяе яжемш CANVAS
        foreach (KeyValuePair<string, CLS_resource_scene> R in mining_scene)
        { R.Value.GO_Canvas.SetActive(false); }

        // юйрхбхпсел мсфмши CANVAS
        mining_scene[GL.name_mining_scene].GO_Canvas.SetActive(true);



        // юйрхбхпсел UI
        UI_RESOURCE_ICON.SET_ICONS(GL.typs_mining_resource.Length);

        // намнбхрэ гмювемхе UI
        UI_RESOURCE.UpdateUIValues();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
