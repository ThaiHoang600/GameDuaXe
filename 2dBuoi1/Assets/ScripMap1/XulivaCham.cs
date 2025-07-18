using System.Collections;
using System.Collections.Generic;
using TopDownRace;
using UnityEngine;

public class XulivaCham : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("XulivaCham");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CheckPoint")
        {
            Thoigiangame.Instance.QuaCheckPoint();
        }
        if (collision.gameObject.tag == "WinPoint")
        {
            Thoigiangame.Instance.Win();
        }
    }
}
