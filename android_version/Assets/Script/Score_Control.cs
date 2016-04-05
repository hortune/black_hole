using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_Control : MonoBehaviour {
    public Text score_text;
    public static int score;
	// Use this for initialization
	void Start () {
        score_text.text = "Score :";
        score = 0;
	}
	
	// Update is called once per frame
	void Update() {
        score_text.text = "Score : " + score;
	}
}
