using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class enemy : MonoBehaviour
{
    public Rigidbody body;
    public bool canpunch=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {   
            canpunch = true;
            if (canpunch == true)
            {
                body.AddForce(Vector3.forward * 40);
                StartCoroutine(disablebox());
                canpunch= false;
            }
           
        }
    }

    public IEnumerator disablebox()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.transform.DOScale(0f, 0.6f);
       
    }
}
