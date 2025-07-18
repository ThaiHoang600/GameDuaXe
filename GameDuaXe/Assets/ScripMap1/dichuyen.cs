using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class dichuyen : MonoBehaviour
{
    public float speed = 10f;          // Tốc độ di chuyển
    public float turnSpeed = 50f;      // Tốc độ xoay
    public float smoothTime = 0.2f;    // Thời gian làm mượt

    private Vector3 velocity = Vector3.zero;
    private float currentAngle;
    private float angleVelocity;

    void Update()
    {
        float verticalInput = 0;
        if (Input.GetKey(KeyCode.W)) verticalInput = 1;
        else if (Input.GetKey(KeyCode.S)) verticalInput = -1;

        float horizontalInput = 0;
        if (Input.GetKey(KeyCode.D)) horizontalInput = 1;
        else if (Input.GetKey(KeyCode.A)) horizontalInput = -1;

        Vector3 targetPosition = transform.position + transform.forward * verticalInput * speed * Time.deltaTime;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        float targetAngle = transform.eulerAngles.y + horizontalInput * turnSpeed * Time.deltaTime;
        currentAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref angleVelocity, smoothTime);

        transform.rotation = Quaternion.Euler(0, currentAngle, 0);
    }
}

