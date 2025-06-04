using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public float giatoc = 2f;
    public float phanhxe = 180f;
    public float maxSpeed = 10f;
    public float turnSpeed = 10f; // độ/giây

    private Rigidbody2D rb;
    private float dithang; // W/S
    private float rehuong; // A/D
    private float tocdohientai;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        dithang = Input.GetAxisRaw("Vertical");   // W = 1, S = -1
        rehuong = Input.GetAxisRaw("Horizontal"); // A = -1, D = 1
    }
    private void FixedUpdate()
    {
        if (dithang != 0)
        {
            tocdohientai += dithang * giatoc * Time.fixedDeltaTime;
        }
        else
        {
            tocdohientai = Mathf.MoveTowards(tocdohientai, 0, phanhxe * Time.fixedDeltaTime);
        }

        tocdohientai = Mathf.Clamp(tocdohientai, -maxSpeed, maxSpeed);

        // Rẽ trái/phải chỉ khi xe đang di chuyển
        if (Mathf.Abs(tocdohientai) > 0.1f)
        {
            float direction = tocdohientai > 0 ? 1 : -1; // rẽ ngược nếu đang lùi
            transform.Rotate(Vector3.forward, -rehuong * turnSpeed * Time.fixedDeltaTime * direction);
        }

        // Di chuyển theo hướng đầu xe
        rb.velocity = transform.right * tocdohientai;
    }
}

