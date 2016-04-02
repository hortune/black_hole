using UnityEngine;
using System.Collections;

public class Fire_ball_ins : MonoBehaviour {
    public GameObject fire_ball,potion;
    private float timer, timer_save;
	// Use this for initialization
	void Start () {
        timer = 0f;
        timer_save = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 0f)
            timer -= Time.deltaTime;
        else
        {
            timer = timer_save;
            timer_save = timer_save * 1.2f;
            int r = Random.Range(0, 15);
            if(r>1)
                Instantiate(fire_ball, new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f)),Quaternion.identity);
            else
                Instantiate(potion, new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f)), Quaternion.identity);
        }
	}
}
