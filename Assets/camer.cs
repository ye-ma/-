using UnityEngine;
using System.Collections;

public class camer : MonoBehaviour
{
    public player play;
    public float distancey;
    public float distance;
    public float lastposition;
    public float lastpositiony;
    public float speed;
    public float a;
    public float b;
    public Transform highpoint;
    public Rigidbody2D rg;
    public Transform lowpoint;
   
    // Use this for initialization
    void Start()
    {
        
        play = FindObjectOfType<player>();
        rg = GetComponent<Rigidbody2D>();

    }
    void Update()
    {

        distance = play.transform.position.x - lastposition;
        distancey = play.transform.position.y - lastpositiony;

        if (play.transform.position.y > highpoint.position.y)
        {

            transform.position = new Vector3(transform.position.x + distance, transform.position.y + distancey, transform.position.z);
        }

        if (play.transform.position.x > highpoint.position.x)
        {

            transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
        }



        if (play.transform.position.y < lowpoint.position.y)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y-distance, transform.position.z);
        }


        




        lastposition = play.transform.position.x;
        lastpositiony = play.transform.position.y;

    }
}

// Update is called once per frame  

