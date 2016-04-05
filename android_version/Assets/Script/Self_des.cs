using UnityEngine;
using System.Collections;

public class Self_des : MonoBehaviour {

    public float des_delay;

    void self_des()
    {
        Hole_ins.white_hole_amount--;
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
        Invoke("self_des", des_delay);
	}

}
