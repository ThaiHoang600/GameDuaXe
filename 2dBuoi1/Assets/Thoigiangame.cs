using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thoigiangame : MonoBehaviour
{
    public float ThoigianChoPhep = 30f;
    public bool Ketthuc = false;
    private static Thoigiangame instance;
    public GameObject gameOverObject;
    public GameObject timegameOverObject;

    [SerializeField]
    private float ThoiGianHoiCheckPoint = 180f;
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
            ThoigianChoPhep -= Time.deltaTime;
            Debug.Log(ThoigianChoPhep);
            if(ThoigianChoPhep <= 0)
            {
                timegameOverObject.SetActive(false);
                gameOverObject.SetActive(true);
                KetthucGame();
            }
        }
    }
    public void KetthucGame()
    {
        Ketthuc = true;
    }
    public void QuaCheckPoint()
    {
        if (!Ketthuc)
        { 
            ThoigianChoPhep = ThoiGianHoiCheckPoint; 
        }
    }
}

