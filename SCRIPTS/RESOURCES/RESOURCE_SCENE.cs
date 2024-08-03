using System.Collections.Generic;
using UnityEngine;

public class RESOURCE_SCENE : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // ������������� ����� ������������ ����� ������ ��������
    public static void SET()
    {
        // ���� ���������� �������� �� ���� �����
        // TYP_MINING_SCENE: ��� ������ �� ����� /���/ ��� ������ �� ����������� ������ � �������
        GL.typs_mining_resource = mining_scene[GL.name_mining_scene].typs_mining_resource;



        // ������������ ��� ����� CANVAS
        foreach (KeyValuePair<string, CLS_resource_scene> R in mining_scene)
        { R.Value.GO_Canvas.SetActive(false); }

        // ���������� ������ CANVAS
        mining_scene[GL.name_mining_scene].GO_Canvas.SetActive(true);



        // ���������� UI
        UI_RESOURCE_ICON.SET_ICONS(GL.typs_mining_resource.Length);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
