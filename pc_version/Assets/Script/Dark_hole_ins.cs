using UnityEngine;
using System.Collections;

public class Dark_hole_ins : MonoBehaviour {
    public GameObject dark_hole;
    private Vector3 pos;
    private float timer;
    private float timer_save;
    private static int hole_count;

    private GameObject[] de;
	// Use this for initialization
	void Start () {
        timer = 1f;
        timer_save = 5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer >= 0f)
            timer -= Time.deltaTime;
        else
        {
            if (hole_count > 4)
            {
                de = GameObject.FindGameObjectsWithTag("Dark_hole");
                int siz = de.Length;
                int r = Random.Range(0, siz);
                Destroy(de[r]);

                hole_count--;
            }
            pos = new Vector3(Random.Range(-45f, 45f), 0.5f, Random.Range(-45f, 45f));
            Instantiate(dark_hole, pos, Quaternion.identity);

            timer = timer_save;
            if(timer_save > 1f)
                timer_save = timer_save * 0.9f;

            hole_count++;
        }

	}
}
