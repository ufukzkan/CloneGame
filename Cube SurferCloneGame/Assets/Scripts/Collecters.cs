using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecters : MonoBehaviour
{
    GameObject Cube;
    int yukseklik;

    void Start()
    {
        Cube = GameObject.Find("Cube");

         
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube.transform.position = new Vector3 (Cube.transform.position.x,yukseklik +1,Cube.transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
         
        
    }
    public void yukseklikAzalt() 
    {
        yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
       if ( other.gameObject.tag=="Collect"&&other.gameObject.GetComponent<Collectables>().GetToplandiMi()== false )
        {
            yukseklik += 1;
            other.gameObject.GetComponent<Collectables>().ToplandiYap();
            other.gameObject.GetComponent<Collectables>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = Cube.transform;

        }

    }
}
