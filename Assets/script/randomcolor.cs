using UnityEngine;
using System.Collections;

public class randomcolor : MonoBehaviour {
    public point point;
    public GameObject gameobject;
    // Use this for initialization
    void Start () {
        point = FindObjectOfType<point>();


        for (int i = 0; i < 8; i++)
        {
            transform.position = point.transform.position;

   


            Instantiate(gameobject, transform.position, transform.rotation);
        }



    }
	
	// Update is called once per frame
	
}
