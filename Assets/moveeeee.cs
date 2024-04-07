using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class moveeeee : MonoBehaviour
{
    public float speed;
    public Animator playeranimation;
    public bool canmove = false;
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        playeranimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {  
            if (Input.GetMouseButtonDown(0))
            {
            /*canmove = true;*/
           


            playeranimation.SetBool("walking", true);




        }
       StartCoroutine  (moveplayer());




    }

    public IEnumerator moveplayer()
    {   
        yield return new WaitForSeconds(.6f);
        if (canmove== true)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "box")
        {
            playeranimation.SetBool("walking", false);
            canmove = false;
            playeranimation.SetBool("punch", true);
            falsepunch();
        }
       

    }

    public void falsepunch()
    {
        
        enemy enemyscr = FindObjectOfType<enemy>();
        enemyscr.canpunch = false;
        if (enemyscr.canpunch == false ) 
        {
            box.GetComponent<BoxCollider>().enabled = false;
            playeranimation.SetBool("punch", false);
            canmove= true;
          


        }
    }
}
