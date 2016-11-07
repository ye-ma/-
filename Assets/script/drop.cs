using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour
{

    public gamemanage gm;
	public GameObject play1;

    void OnTriggerEnter2D(Collider2D other)
    {

		if (other.tag == "Player"||other.tag=="guaiwu")
        {

            gm.appear();

			play1.SetActive (false);
        }




    }
}