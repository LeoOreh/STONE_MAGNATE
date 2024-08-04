using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_SCENE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // ������������� ����� ������������ ��������� ����� ������ ��������
    public static void SET(string name_scene)
    {
        GL.name_mining_scene = name_scene;


        // ������������ ��� ����� CANVAS
        foreach (KeyValuePair<string, CLS_resource_scene> R in mining_scene)
        { R.Value.GO_Canvas.SetActive(false); }

        // ���������� ������ CANVAS
        mining_scene[GL.name_mining_scene].GO_Canvas.SetActive(true);



        // ���������� UI
        UI_RESOURCE_ICON.SET_ICONS(mining_scene[GL.name_mining_scene].typs_mining_resource.Length);

        // �������� �������� UI
        UI_RESOURCE.UpdateUIValues();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
