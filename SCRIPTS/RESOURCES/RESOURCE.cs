using UnityEngine;
using System.Collections.Generic;
using static UI_RESOURCE;

public class RESOURCE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// ������ ���� ����� ��������;
    /// ���� - ��� �����;
    /// �������� �������� ���� �������� � ������ �� ������� �� �����;
    /// </summary>
    protected static Dictionary<string, CLS_mining_scene>   mining_scene        { get; set; }


    /// <summary>
    /// ������������ ������� UI (�����);
    /// </summary>
    protected static Dictionary<int, CLS_UI_RESOURCE_SLOT>  resource_UI         { get; set; }


    /// <summary>
    /// ��� ���� ��������;
    /// </summary>
    protected static Dictionary<string, CLS_resource>       resources_typs      { get; set; }


    /// <summary>
    /// ���� ������������� ������ �� ����� (mining_scene � MAP/WINDOW);
    /// �������� �������� �������� ���������� ��������;
    /// </summary>
    protected static Dictionary<string, string[]>           list_mining_scene   { get; set; }
    //-----------------------------------------------------------------------------------------------------------------
}
    