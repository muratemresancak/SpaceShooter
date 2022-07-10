using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    Rigidbody rg;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        rg.velocity = transform.forward*5;
    }

  

}
