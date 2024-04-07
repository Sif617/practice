using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveeeee : MonoBehaviour
{
    public float speed;
    public Animator playeranimation;
    public bool canmove = false;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
            if (Input.GetMouseButtonDown(0))
            {
            moveplayer();
           /* playeranimation.SetBool("walking", true);
      */



        }





    }

    public void moveplayer()
    {
        if (canmove)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
