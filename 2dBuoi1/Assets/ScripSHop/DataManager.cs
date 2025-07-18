using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class CarShopData
{
    public bool isCar1Bought;
    public bool isCar2Bought;
    // Thêm nữa nếu có nhiều xe
    public int selectedCar = 0; // 1 = car1, 2 = car2
}


public class DataManager : MonoBehaviour
{
    private const string Key = "ShopCarData";

    public static void SaveData(CarShopData data)
    {
        string json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(Key, json);
        PlayerPrefs.Save();
    }

    public static CarShopData LoadData()
    {
        if (PlayerPrefs.HasKey(Key))
        {
            string json = PlayerPrefs.GetString(Key);
            return JsonUtility.FromJson<CarShopData>(json);
        }
        return new CarShopData(); // Mặc định là chưa mua gì
    }
}

   
  
   






