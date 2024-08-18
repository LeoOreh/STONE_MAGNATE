using UnityEngine;

public class UI_RESOURCE_COLLECT_BUTTON : UI_RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    static CLS_resource typ_mining;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public void COLLECT_BUTTON(GameObject GO)
    {
        typ_mining = mining_scene[GL.name_mining_scene].typs_mining[int.Parse(GO.name)];

        Debug.Log("���� �������� : "     +
           "\n" + "�����: "              + GL.name_mining_scene +
           "\n" + "��� �������: "        + typ_mining.name +
           "\n" + "���������� �������: " + typ_mining.score);

        // score = score * ... - ����� �������� ��������� �� �������� ����� ��� ��.
        WAREHOUSE.warehouses_typs[typ_mining.name].score += typ_mining.score;

        typ_mining.score = 0;
        SAVE_WAREHOUSE.SET();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
