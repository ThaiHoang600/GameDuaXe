using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        rb.MovePosition(new Vector2(0, 0));
        rb.MoveRotation(90);

    }

    // Update is called once per frame
    void Update()
    {

        //var ver = Input.GetAxis("Vertical");

        //var pos = rb.position;

        //pos.x += hor * 30 * Time.deltaTime;
        //pos.y += ver * 30 * Time.deltaTime;

        //rb.MovePosition(pos);
        var hor = Input.GetAxis("Horizontal");
        var angel = rb.rotation;
        angel -= hor * 1800 * Time.deltaTime;
        rb.MoveRotation(angel);

        if(Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }
        
    }

    
    public void MoveUp()
    {
        rb.velocity = Vector2.up * 2;
    }
    
    public void MoveDown()
    {
        rb.velocity = Vector2.down * 2;
    }
}
