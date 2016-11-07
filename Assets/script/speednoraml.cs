using UnityEngine;
using System.Collections;

public class speednoraml : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 pos1 = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);

        transform.position = pos1;
    }
}
