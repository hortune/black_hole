using UnityEngine;
using System.Collections;

public class Dark_hole_ins : MonoBehaviour {
    public GameObject dark_hole;
    private Vector3 pos;
    private float timer;
    private float timer_save;
    public static int hole_count;
    public Transform charc;

    private GameObject[] de;
	// Use this for initialization
	void Start () {
        timer = 0f;
        timer_save = 2.7f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer >= 0f||hole_count> 5)
            timer -= Time.deltaTime;
        else
        {
            pos = new Vector3(Random.Range(-45f, 45f), 0.5f, Random.Range(-45f, 45f));
            //Debug.Log(charc);
            while (Vector3.Distance(pos, charc.position) < 35)
            {
                pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
                //Debug.Log(charc.position);
            }
            Instantiate(dark_hole, pos, Quaternion.identity);

            timer = timer_save;
            if (timer_save > 1.3f)
                timer_save *= 0.85f;
            hole_count++;
        }
	}
}
