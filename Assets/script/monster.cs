using UnityEngine;
using System.Collections;

public class monster : MonoBehaviour {
    
   
    public Transform left1;
    public Transform right1;
    public int direction = 1;
    public float currentValue;
   

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        currentValue -= Time.deltaTime * direction*2; // or however you are incrementing the position

        if (currentValue >= right1.position.x)
        {
            direction *= -1;
            currentValue = right1.position.x;
            transform.Rotate(0, 180, 0);
        }
        else if (currentValue <= left1.position.x)
        {
            direction *= -1;
            currentValue = left1.position.x;
            transform.Rotate(0, 180, 0);
        }
        transform.position = new Vector3(currentValue, transform.position.y, transform.position.z);




    }
}
