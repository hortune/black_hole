using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
    static public int life;
    public GameObject game_over;
    public GameObject ins_control;

    public GameObject heart_one, heart_two, heart_three;
	// Use this for initialization
	void Start () {
        life = 3;
	}

    void Check_heart()
    {
        if (life == 0)
        {
            heart_one.gameObject.SetActive(false);
            Destroy(gameObject);
            game_over.gameObject.SetActive(true);
            ins_control.SetActive(false);
        }
        if (life == 1)
        {
            heart_one.gameObject.SetActive(true);
            heart_two.gameObject.SetActive(false);
        }
        if (life == 2)
        {
            heart_two.gameObject.SetActive(true);
            heart_three.gameObject.SetActive(false);
        }
        if(life == 3)
        {
            heart_three.gameObject.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Fire_ball")
        {
            life--;
            Check_heart();
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Potion")
        {
            if(life < 3)
                life++;
            Check_heart();
            Destroy(other.gameObject);
        }
    }
}
