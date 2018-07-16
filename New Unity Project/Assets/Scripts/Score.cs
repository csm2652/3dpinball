using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

   
    public Text scoreText;
    
    
	// Use this for initialization
	void Start () {
        scoreText= GetComponent<Text>();
    }
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE : " + scoreMake.score.ToString();
    }
}
