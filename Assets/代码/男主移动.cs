using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 男主移动 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float nanzhumove = Input.GetAxis("Horizontal");
      
        float facedircetion = Input.GetAxisRaw("Horizontal");
        if(nanzhumove!=0)
        {
            rb.velocity = new Vector2(nanzhumove * speed, rb.velocity.y);
        }
        if(facedircetion !=0)
        {
            transform.localScale = new Vector3(facedircetion, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
}
