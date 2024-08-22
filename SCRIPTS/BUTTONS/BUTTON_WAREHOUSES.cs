using UnityEngine;

public class BUTTON_WAREHOUSES : BUTTONS
{
    //-----------------------------------------------------------------------------------------------------------------
    public void WAREHOUSES_Close()
    {
        warehouse.SetActive(false);
    }
    //-----------------------------------------------------------------------------------------------------------------





    //-----------------------------------------------------------------------------------------------------------------
    public void SELECT_PRODUCT(GameObject GO)
    {
        Debug.Log(GO.name);
        exchange.SetActive(true);

        exchange.transform.Find(WAREHOUSE.warehouses_typs[GO.name].typ_product).gameObject.SetActive(true);
    }
    //-----------------------------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------------------------
    public void SELECT_PRODUCT_CLOSE()
    {
        exchange.SetActive(false);
        exchange.transform.Find("coin")   .gameObject.SetActive(false);
        exchange.transform.Find("mining") .gameObject.SetActive(false);
        exchange.transform.Find("product").gameObject.SetActive(false);
    }
    //-----------------------------------------------------------------------------------------------------------------
}
