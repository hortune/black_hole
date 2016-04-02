using UnityEngine;
using System.Collections;

public class Be_Attracted : MonoBehaviour {
    private GameObject[] Dark_hole;
    private Vector3 force_dir;
    public Rigidbody rb;
    private float p;

	// Use this for initialization
	void Start () {
        p = 400f;
	}
	
	// Update is called once per frame
	void Update () {
        Dark_hole = GameObject.FindGameObjectsWithTag("Dark_hole");
        int siz = Dark_hole.Length;

        for(int i=0;i< siz;i++)
        {
            force_dir = Dark_hole[i].transform.position - transform.position;
            float r = force_dir.magnitude * force_dir.magnitude * force_dir.magnitude;
            rb.AddForce(force_dir * p / r);
        }
	}
}
