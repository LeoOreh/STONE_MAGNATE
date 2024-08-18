using UnityEditor;
using UnityEngine;

public class UNITY_EDITOR_HELPER : MonoBehaviour
{
    // �������� � ���� ���� � ������� �� �����
    [MenuItem("[-----i----]/�������� ����")]
    public static void PTH()
    {
        GameObject GO = Selection.activeGameObject;
        string PTH = "/" + GO.name;

        while (GO.transform.parent != null)
        {
            GO = GO.transform.parent.gameObject;
            PTH = "/" + GO.name + PTH;
        }
        Debug.Log(PTH);
    }
}
