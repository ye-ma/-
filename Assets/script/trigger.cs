using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class trigger : MonoBehaviour {

    public GameObject exhaust;

    public GameObject a;
   

   

    void start() {
  
    }



    void OnTriggerEnter2D(Collider2D other)
    {


		if (other.tag == "Player"||other.tag=="guaiwu")
        {

           

            Destroy(this.gameObject);
       

            a = (GameObject)Instantiate(exhaust, gameObject.transform.position, gameObject.transform.rotation);

     

            Destroy(a,2);

        }




    }



    }

