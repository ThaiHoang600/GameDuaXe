using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void BuyCar1()
    {
        CarShopData data = DataManager.LoadData();
        data.isCar1Bought = true;
        data.selectedCar = 1;
        DataManager.SaveData(data);
    }

    public void BuyCar2()
    {
        CarShopData data = DataManager.LoadData();
        data.isCar2Bought = true;
        data.selectedCar = 2;
        DataManager.SaveData(data);
    }
}
