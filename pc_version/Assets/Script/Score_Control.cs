using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_Control : MonoBehaviour {
    public Text score;
    private float t;
	// Use this for initialization
	void Start () {
        score.text = "Score :";
        t = 0;
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        score.text = "Score : " + t;
	}
}
