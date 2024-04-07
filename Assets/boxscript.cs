using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class boxscript : MonoBehaviour
{
    public float speed;
    public GameObject prefabs;
    public GameObject target;
    public GameObject prefabs2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalspeed = Input.GetAxis("Horizontal");
        float verticalspeed = Input.GetAxis("Vertical");
        transform.position = new Vector3(transform.position.x+horizontalspeed*speed*Time.deltaTime,0
            ,transform.position.z+ verticalspeed*speed*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {

            instantiatee();

          /*collision.rigidbody.gameObject.SetActive(false);*/
            collision.rigidbody.gameObject. transform.DOScale(0f, 0.06f).SetEase(Ease.InOutElastic);
            StartCoroutine(prefabdata());
            StartCoroutine(itemfunction());
          
        }
    }

    public void instantiatee() 
    { 
     GameObject bullet = Instantiate(prefabs,transform.position,transform.rotation);
        Destroy(bullet,0.3f);
    
    }

    public void newitem()
    {
        

    }

    public IEnumerator itemfunction()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject newobject = Instantiate(target, transform.position, transform.rotation);
        newobject.transform.DOScale(1.5f, 0.7f);

    }

    public IEnumerator prefabdata()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject prefabdata = Instantiate(prefabs2,transform.position, transform.rotation);
        Destroy(prefabdata, 2f);
    }



}
