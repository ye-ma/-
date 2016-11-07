using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{
    private Rigidbody2D rg;
    public float speed;
    public float jump;
    public bool ground;
    public GameObject Pointgameobject;
    public LayerMask matchground;
    public Collider2D co;
    public bool dblJump = false;
    public gamemanage gm;
    public float upspeed;
    private Animator myanimator;
    public float speeddistance;
    
    public float speedplus;
    public int jumpa = 3;
    public int maxJumps = 2;

    public point point;

    public Transform death;
    public score thescore;

    public AudioSource jumpsound;
    public AudioSource doublejump;
   
    // Use this for initialization
    void Start()
    {
        point = FindObjectOfType<point>();
        thescore = FindObjectOfType<score>();
        Pointgameobject = GameObject.Find("generateObject");
        rg = GetComponent<Rigidbody2D>();
        co = GetComponent<Collider2D>();
        myanimator = GetComponent<Animator>();

    
    }

    // Update is called once per frame
    void Update()
    {
        

            ground = Physics2D.IsTouchingLayers(co, matchground);

            rg.velocity = new Vector2(speed*Time.deltaTime, rg.velocity.y);

            if (transform.position.x > speeddistance)
            {
                speeddistance = speeddistance +300;

                speed = speed + speedplus;

                point.setdistancex(0.5f);
            point.setdistancex2(0.5f);

        } 
           
            

            if (ground == true) //if we're on the floor
            {




            //if (Input.GetMouseButtonDown(0))          //Input.GetKeyDown(KeyCode.Space))

            if (Input.GetMouseButtonDown(0) && Input.mousePosition.x < Screen.width / 2)
            

                {


                    jumps();

                    dblJump = true;

                jumpsound.Play();
                }

            }


            if (!ground && dblJump && Input.GetMouseButtonDown(0) && Input.mousePosition.x < Screen.width / 2)// Input.GetMouseButtonDown(0))//Input.GetKeyDown(KeyCode.Space))
            {

                jumps();


                dblJump = false;
            doublejump.Play();
            }




            myanimator.SetBool("ground", ground);

            myanimator.SetBool("dblJump", dblJump);


            myanimator.SetBool("type", Input.GetMouseButtonDown(0));

       

    }

    
    
    void jumps()
    {



        rg.AddForce(Vector2.up * jump);



    }




	void OnTriggerEnter2D(Collider2D other){
	
	
		if(other.tag=="baoshi"){


			thescore.scorecount++;
		}
	
	
	}




}