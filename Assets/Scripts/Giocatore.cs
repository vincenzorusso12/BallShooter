using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giocatore : MonoBehaviour
{
    public float speed;
    private Rigidbody rigid;
    
    /*COME SI USA
     1.Mettere il rigid body al giocatore freezando la rotazione
     2.creo i muri
     3.creo un physicmaterial per i muri con bounciness 0.8 0.6
     4.disattivo meshRender ai muri per renderli invisibili
     5.applio lo script giocatore.cs al giocatore*/
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rigid.constraints= RigidbodyConstraints.FreezeRotation;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 input = new Vector3(h,0.0f,0.0f);
        rigid.AddForce(speed*input);
    }

  
}
