using UnityEngine;

public class GAME : MonoBehaviour
{
    //-----------------------------------------------------------------------------------------------------------------
    void Start()
    {
        // �������� ����������� ������
        SAVE_BY_TIMER.GET();



        // ���� ���� ��������� �����
        INITIALIZATION.I();



        // ���� ����������� ��������� �����
        RESOURCE_SCENE.SET(GL.name_mining_scene);
    }
    //-----------------------------------------------------------------------------------------------------------------





    //-----------------------------------------------------------------------------------------------------------------
    void Update()
    {
        // �������� ��������� �������� (������� �� �������)
        RESOURCE_TIMER_GET.CHECK();



        // ���������� �� ������� 3���
        SAVE_BY_TIMER.TIMER_SAVE();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
