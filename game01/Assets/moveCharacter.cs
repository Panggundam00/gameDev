using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour{

    public float moveSpeed = 1000.0f;
    //Vector3 position ;
    public Rigidbody2D rb ;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, Input.GetAxis("Vertical")*moveSpeed, 0.0f);

        //position.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //position.y += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //transform.position = transform.position + movement * Time.deltaTime;
        //movement = movement + moveSpeed;
        rb.velocity = new Vector2(movement.x, movement.y);
    }
}
