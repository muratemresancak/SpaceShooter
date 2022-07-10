using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Rigidbody rg;
   
    public GameObject explosion;
    public GameObject explosion2;

  

    GameObject GameCont;
    GameControl control;

    void Start()
    {
        GameCont = GameObject.FindGameObjectWithTag("GControl");
        control = GameCont.GetComponent<GameControl>();
        

        rg = GetComponent<Rigidbody>();
        rg.angularVelocity = Random.insideUnitSphere*3;
        rg.velocity = transform.forward * -4;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!= "boundary"&&other.tag!="ast")
        {
         
                Destroy(other.gameObject);
                Destroy(gameObject);
                Instantiate(explosion, transform.position, transform.rotation);
                control.scoreup(2);
        }

        if (other.tag=="Player")
        {
            Instantiate(explosion2,other.transform.position, other.transform.rotation);
            control.finish();
        }
    }

}
