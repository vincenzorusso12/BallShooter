using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLogic : MonoBehaviour
{
    private bool b1 = false, b2 = false, b3 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("triggeredered");

        //se sono dello stesso colore
        if (col.tag == "sRed" && this.tag == "red")
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
                b1 = true;
            }

            if (col.tag == "sGreen" && this.tag == "green")
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
                b2 = true;

        }

        if (col.tag == "sBlue" && this.tag == "blue")
            {
                Destroy(col.gameObject);
                Destroy(this.gameObject);
                b3 = true;
        }



        if (col.tag == "barra")
        {
            Destroy(this.gameObject);

        }
    }


   

}
