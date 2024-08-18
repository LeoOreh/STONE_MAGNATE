using UnityEngine;

public class BUTTON_WAREHOUSES : BUTTONS
{
    //-----------------------------------------------------------------------------------------------------------------
    public void WAREHOUSES_Close()
    {
        sale.SetActive(false);
    }
    //-----------------------------------------------------------------------------------------------------------------



    public void Select_product(GameObject GO)
    {
        Debug.Log(GO.name);
    }
}
