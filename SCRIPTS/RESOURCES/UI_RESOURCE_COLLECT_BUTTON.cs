using UnityEngine;

public class UI_RESOURCE_COLLECT_BUTTON : UI_RESOURCE
{
    static CLS_resource typ_mining;

    public void COLLECT_BUTTON(int number_slot)
    {
        typ_mining = mining_scene[GL.name_mining_scene].typs_mining[number_slot];

        Debug.Log("Сбор майнинга : "     +
           "\n" + "Сцена: "              + GL.name_mining_scene +
           "\n" + "Имя ресурса: "        + typ_mining.name +
           "\n" + "Количесвто ресурса: " + typ_mining.score);

        // score = score * ... - здесь добавить множитель за просмотр видео или др.
        WAREHOUSE.warehouses_typs[typ_mining.name].score += typ_mining.score;

        typ_mining.score = 0;
        WAREHOUSE_SAVE.SET();
    }
}
