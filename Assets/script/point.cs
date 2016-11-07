using UnityEngine;
using System.Collections;
using System;

public class point : MonoBehaviour
{
    public Transform platgenerate;
    public GameObject platform;
    public GameObject platform2;
    public GameObject shuiguo;
    public GameObject[] foodarrange;
    public float distance;
    public float distancex;
    public float distancex2;
    public GameObject generatepoint;
    private float platwidth;
    public int maxheigh;
    public int minheigh;

    private float originx;
    private float originy;
    private float width;
    public float scalemin;
    public float scalemax;
    public float scaleheigh;
    public float lastpositiony;
    public float lastpositionx;
    public float b;
    public float k1;
    public float k2;
    // Use this for initialization
    void Start()
    {
     


    }
    public void setdistancex(float a)
    {
        distancex = distancex+ a;

    }
    public float getdistancex()
    {
        return distancex;

    }

    public void setdistancex2(float a)
    {
        distancex2 = distancex2+ a;

    }
    public float getdistancex2()
    {
        return distancex2;

    }



    // Update is called once per frame

    public void Update()
    {
        if (transform.position.x < platgenerate.position.x )
        {


            distance = UnityEngine.Random.Range(distancex, distancex2);

            //  heigh = originy + lastpositiony;
            // lastpositiony = heigh;

            platwidth = platform2.GetComponent<BoxCollider2D>().size.x;

            width = transform.position.x + platwidth + distance;
            // platform.transform.localScale = new Vector2(Random.Range(scalemin, scalemax),scaleheigh);

           

            transform.position = new Vector3(width, lastpositionx + UnityEngine.Random.Range(k1, k2), transform.position.z);



            Instantiate(platform, transform.position, transform.rotation);


            lastpositionx = transform.position.y;



            //for (int i = 0; i <= distance; i += 3)
            //{
              //  if (i > distance / 4 && i <= (distance / 4) * 3)
             //   {

               //     Vector3 pos3 = new Vector3(width - i, heigh + distance / 4, transform.position.z);
               //     Instantiate(shuiguo, pos3, transform.rotation);
              //  }

         //   }

           // Instantiate(foodarrange[Random.Range(0, foodarrange.Length)], pos, transform.rotation);


            // Instantiate(baoshi, pos2, transform.rotation);

        }


     



    }

   
}












