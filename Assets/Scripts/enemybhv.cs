using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybhv : MonoBehaviour
{
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
            foreach (Touch touch in Input.touches)
        {
            //Debug.Log(Vector2.Distance(touch.position, gameObject.transform.position));
             if (Vector2.Distance(touch.position, gameObject.transform.position) <= 550f)
             {
                 Debug.Log(Vector2.Distance(touch.position, gameObject.transform.position));
                 Destroy(gameObject);

             }
            
        }
    
    }
}
