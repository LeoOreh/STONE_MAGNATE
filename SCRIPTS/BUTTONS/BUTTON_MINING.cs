using UnityEngine;

public class BUTTON_MINING : RESOURCE
{
    //-----------------------------------------------------------------------------------------------------------------
    Animator animator;
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    //-----------------------------------------------------------------------------------------------------------------




    //-----------------------------------------------------------------------------------------------------------------
    // ���� �������� ������ �� �������� ��� ��������� ������ ��������
    public void Click()
    {
        resources[mining_scene[GL.name_mining_scene].typs_mining_resource[0]].time_get = 0;
        
        animator.SetTrigger("Click");
    }
    //-----------------------------------------------------------------------------------------------------------------
}
