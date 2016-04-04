using UnityEngine;
using System.Collections;

public class Self_des : MonoBehaviour {

    public float des_delay;

    void self_des()
    {
        if(gameObject.tag=="White_hole")
        White_hole_ins.white_hole_amount--;
        if (gameObject.tag == "Fire_ball")
        Fire_ball_ins.fire_ball_amount--;
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
        Invoke("self_des", des_delay);
	}

}
