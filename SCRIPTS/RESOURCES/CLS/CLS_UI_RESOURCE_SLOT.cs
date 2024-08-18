using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CLS_UI_RESOURCE_SLOT
{
    //-----------------------------------------------------------------------------------------------------------------
    public string           name;
    public GameObject       slot;
    public TextMeshProUGUI  text;
    public Image            icon;
    public Image            fill;
    public Animator         frame_animator;
    //-----------------------------------------------------------------------------------------------------------------



    //-----------------------------------------------------------------------------------------------------------------
    public CLS_UI_RESOURCE_SLOT(int n)
    {
        string pth = "/Canvas/show_count_resources/slots/" + n;

        slot            = GameObject.Find(pth);
        text            = GameObject.Find(pth + "/TXT")               .GetComponent<TextMeshProUGUI>();
        fill            = GameObject.Find(pth + "/visual_fill/fill")  .GetComponent<Image>();
        icon            = GameObject.Find(pth + "/icon")              .GetComponent<Image>();
        frame_animator  = GameObject.Find(pth)                        .GetComponent<Animator>();
    }
    //-----------------------------------------------------------------------------------------------------------------
}
