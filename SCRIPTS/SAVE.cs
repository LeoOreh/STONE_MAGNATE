using System.Security.Cryptography;
using UnityEngine;

public class SAVE : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    static float time_save;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    // ��������� ����������� ������
    public static void GET()
    {
        GL.name_mining_scene = PlayerPrefs.GetString("name_mining_scene", "BLACK");


        // �������� ������ � �������� (�� json)
        RESOURCE_SAVE.GET();
    }
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    // ��������� ������ �� ������� 3���
    public static void TIMER_SAVE()
    {
        if (time_save > Time.time) { return; }
        time_save = Time.time + 3;

        PlayerPrefs.SetString("name_mining_scene", GL.name_mining_scene);


        // ��������� ������ � �������� (� json)
        RESOURCE_SAVE.SET();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
