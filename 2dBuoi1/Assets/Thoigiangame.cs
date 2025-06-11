using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thoigiangame : MonoBehaviour
{
    public float ThoigianGame = 30f;
    public bool Ketthuc = false;
    private static Thoigiangame instance;

    public static Thoigiangame Instance
    {
        get 
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Thoigiangame>();
                if(instance==null)
                {
                    GameObject gameThoiGian = new GameObject("Thoigiangame");
                    instance = gameThoiGian.AddComponent <Thoigiangame>();
                }

            }
            return instance;
        }
    }

    private void Update()
    {
        if(!Ketthuc)
        {
            ThoigianGame -= Time.deltaTime;
            Debug.Log(ThoigianGame);
            if(ThoigianGame <= 0)
            {
                KetthucGame();
            }
        }
    }
    public void KetthucGame()
    {
        Ketthuc = true;
    }

}

