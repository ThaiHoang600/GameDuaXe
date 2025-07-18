using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{   
        public GameObject car1;
        public GameObject car2;

        void Start()
        {
            CarShopData data = DataManager.LoadData();

            if (data.isCar1Bought)
                car1.SetActive(true);  // hoặc bật xe đã mua
            else
                car1.SetActive(false);

            if (data.isCar2Bought)
                car2.SetActive(true);
            else
                car2.SetActive(false);                 

            // Tắt hết trước
            car1.SetActive(false);
            car2.SetActive(false);

            // Hiện đúng xe đã chọn
            if (data.isCar1Bought && data.selectedCar == 1)
                car1.SetActive(true);
            if (data.isCar2Bought && data.selectedCar == 2)
                car2.SetActive(true);
        
    }

   
}
