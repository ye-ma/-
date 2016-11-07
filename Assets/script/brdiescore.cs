using UnityEngine;
using System.Collections;

public class brdiescore : MonoBehaviour
{
    public GameObject badimage;
    public Transform point;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Instantiate(badimage, point.position, point.rotation);
        }
    }
}