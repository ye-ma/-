using UnityEngine;
using System.Collections;

public class brdigefly : MonoBehaviour
{
    public float upspeed;
   
    void Update()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.y + upspeed * Time.deltaTime);

        transform.position = pos;
    }
}