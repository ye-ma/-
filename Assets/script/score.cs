using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
  public Text ScoreText;
    public int scorecount=0;
    public Transform playx;
    public Text ScoreText2;
    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        ScoreText.GetComponent<Text>().text = "x"+ scorecount;
        ScoreText2.GetComponent<Text>().text = "距离   " + playx.position.x;
    }
}
