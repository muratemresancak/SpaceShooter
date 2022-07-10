using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rg;
    float hrzntl;
    float vrtcl;
    public float spd;
    Vector3 vec;

    float FireTime;
    float FireDly=0.3f;

    public GameObject lzr;
    public Transform weapon1;
    public Transform weapon2;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1")&&Time.time>FireTime) 
        {
            FireTime = Time.time + FireDly;
            Instantiate(lzr, weapon1.position,Quaternion.identity);
            Instantiate(lzr, weapon2.position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        hrzntl = Input.GetAxis("Horizontal");
        vrtcl = Input.GetAxis("Vertical");

        vec = new Vector3(hrzntl, 0,vrtcl);
        rg.velocity = vec * spd;

        rg.position = new Vector3(Mathf.Clamp(rg.position.x,-5.4f,5.4f),0,Mathf.Clamp(rg.position.z,-1.2f,15f));
        rg.rotation = Quaternion.Euler(0, 0, -rg.velocity.x*3);
    }
}
