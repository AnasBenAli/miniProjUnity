using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymvt : MonoBehaviour
{
    [Range(-5f, 5f)]
    public float speed = 2f;
    private float offset;
    public GameManager gm;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!gm.paused)
        { 
        offset += (Time.deltaTime * speed) / 10f;
        rb.velocity = new Vector2(speed * offset, 0) * -1;
        }
    }
}
