using System.Collections.Generic;

public class RESOURCE_TIMER_GET : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    // �������� �������� ��������� ��������
    public static void CHECK()
    {
        foreach(KeyValuePair<string, CLS_resource> res in resources)
        {
            if (GL.time > res.Value.time_get)
            {
                resources[res.Key].time_get += resources[res.Key].time_interval;
                resources[res.Key].score  += resources[res.Key].value_get_resources;

                // �������� �������� UI
                UI_RESOURCE.UpdateUIValues();
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
}
