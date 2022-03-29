using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject target;
    public Vector3 distance;
   


    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + distance, Time.deltaTime);
    }
}
