using UnityEngine;
using System.Collections;

public class Fire_ball_ins : MonoBehaviour {
    public GameObject fire_ball,potion;
    public Transform charc;
    private float timer, timer_save;
    private Vector3 pos;
	// Use this for initialization
	void Start () {
        timer = 0.5f;
        timer_save = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 0f)
            timer -= Time.deltaTime;
        else
        {
            timer = timer_save;
            if(timer_save > 0.3f)
                timer_save *= 0.85f;
            int r = Random.Range(0, 75);
            pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
            while(Vector3.Distance(pos,charc.position) < 35f)
                pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
            if (r > 1)
                Instantiate(fire_ball, pos, Quaternion.identity);
            else
                Instantiate(potion, pos, Quaternion.identity);
        }
	}
}
