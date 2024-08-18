using UnityEditor;
using UnityEngine;

public class UNITY_EDITOR_HELPER : MonoBehaviour
{
    // получить в логи путь к объекту на сцене
    [MenuItem("[-----i----]/ѕќЋ”„»“№ ѕ”“№")]
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
