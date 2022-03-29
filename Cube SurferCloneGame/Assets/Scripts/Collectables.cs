using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    int index;
    bool toplandiMi;
    public Collecters collecters; 

    void Start()
    {
        toplandiMi = false;



    }

   
    void Update()
    {

        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }

        


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            collecters.yukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;



        }

    }

    public bool GetToplandiMi()
    {
        return toplandiMi;
    }
        public void ToplandiYap()
    {
        toplandiMi=true;
    }
    public void IndexAyarla(int index)

    {
        this.index = index;

    }


}
