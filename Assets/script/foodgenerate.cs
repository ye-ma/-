using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class foodgenerate : MonoBehaviour {
    public GameObject cameras;
    public GameObject[] foodarrange;

    

    void Start()
    {

       cameras= GameObject.Find("Main Camera");


        InvokeRepeating("appears", 1, 2F);


    }


    public void appears()
    {



        transform.position = new Vector3(Random.Range(cameras.transform.position.x,cameras.transform.position.x+18), cameras.transform.position.y+8, transform.position.z);





            Instantiate(foodarrange[Random.Range(0, 4)], transform.position, transform.rotation);
        





        }



       





    }
    