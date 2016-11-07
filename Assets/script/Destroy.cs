using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
    public GameObject destroypoint;
    public GameObject explosion;
	// Use this for initialization
	void Start () {
        destroypoint = GameObject.Find("Destroypoint");
        explosion = GameObject.Find("explosion");

    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < destroypoint.transform.position.x) {

             Destroy(gameObject);

           
        }
	}
}
