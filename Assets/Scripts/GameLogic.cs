using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject myPrefab;
    public float speed;
    public GameObject player;
    private Vector3 distanza;
    private GameObject g;
    private GameObject p1, p2, p3;

    /*perche quando sparo la base player scende??*/
    // Start is called before the first frame update
    void Start()
    {

        p1= GameObject.FindWithTag("sBlue");
        p2= GameObject.FindWithTag("sGreen");
        p3= GameObject.FindWithTag("sRed");




        g = Instantiate(myPrefab, transform.position + new Vector3(0, 5, 5), transform.rotation);
        g.GetComponent<Collider>().isTrigger = true;
        g.AddComponent<Rigidbody>();
        g.AddComponent<ColliderLogic>();

        distanza = player.transform.position - g.transform.position;
        int num = Random.Range(1, 4);



        Color colore = new Color(0, 0, 0, 1);
        //red
        if(num==1)
        {
            colore = new Color(255, 0, 0, 1);
            g.tag = "red";
        }
        if (num == 2)
        {
            colore = new Color(0, 255, 0, 1);
            g.tag = "green";
        }
        if (num == 3)
        {
            colore = new Color(0, 0, 255, 1);
            g.tag = "blue";
        }

        g.GetComponent<Renderer>().material.color = colore;


    }

    // Update is called once per frame
    void Update()
    {
        /*devo troivare un modo per istanziare la pallina la prima volta senza premere spazio*/
        /*devo trovare un modo per fermarmi nel do update senza instanziare 100000 palline*/
  
        g.transform.position = player.transform.position - distanza;

      


        if (Input.GetKeyDown("space"))
        {


            Rigidbody p = g.GetComponent<Rigidbody>();
            p.velocity = transform.forward * speed;


            print("Space clicked!");



            g = Instantiate(myPrefab, transform.position, transform.rotation);
            g.AddComponent<Rigidbody>();
            g.GetComponent<Collider>().isTrigger = true;
            g.AddComponent<ColliderLogic>();



            int num = Random.Range(1, 4);


            Color colore = new Color(0, 0, 0, 1);
            //red
            if (num == 1)
            {
                colore = new Color(255, 0, 0, 1);
                g.tag = "red";
            }
            if (num == 2)
            {
                colore = new Color(0, 255, 0, 1);
                g.tag = "green";
            }
            if (num == 3)
            {
                colore = new Color(0, 0, 255, 1);
                g.tag = "blue";
            }


            g.GetComponent<Renderer>().material.color = colore;



        }
    }



    void OnGUI()
    {

        if (p1==null && p2==null && p3==null)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200f, 200f), "HAI VINTO");
        }



    }


}
