using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public float acceleration = 5f;
    public float deceleration = 5f;
    public float maxSpeed = 10f;
    public float turnSpeed = 100f; // độ/giây

    private Rigidbody2D rb;
    private float moveInput; // W/S
    private float turnInput; // A/D
    private float currentSpeed;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        moveInput = Input.GetAxisRaw("Vertical");   // W = 1, S = -1
        turnInput = Input.GetAxisRaw("Horizontal"); // A = -1, D = 1
    }
    private void FixedUpdate()
    {
        if (moveInput != 0)
        {
            currentSpeed += moveInput * acceleration * Time.fixedDeltaTime;
        }
        else
        {
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.fixedDeltaTime);
        }

        currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);

        // Rẽ trái/phải chỉ khi xe đang di chuyển
        if (Mathf.Abs(currentSpeed) > 0.1f)
        {
            float direction = currentSpeed > 0 ? 1 : -1; // rẽ ngược nếu đang lùi
            transform.Rotate(Vector3.forward, -turnInput * turnSpeed * Time.fixedDeltaTime * direction);
        }

        // Di chuyển theo hướng đầu xe
        rb.velocity = transform.right * currentSpeed;
    }
}

