using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    public int life;
    public GameObject game_over;
    public GameObject ins_control;
    public Button replay;

    public GameObject heart_one, heart_two, heart_three;
	// Use this for initialization
	void Start () {
        life = 3;
	}

    public void Reset()
    {
        life = 3;
        revive();
        Dark_hole_ins.hole_count = 0;
        Fire_ball_ins.fire_ball_amount = 0;
    }

    void revive()
    {
        heart_one.gameObject.SetActive(true);
        heart_two.gameObject.SetActive(true);
        heart_three.gameObject.SetActive(true);
    }

    void Check_heart()
    {
        if (life == 0)
        {
            heart_one.gameObject.SetActive(false);

            GameObject[] game_obj;
            game_obj = GameObject.FindGameObjectsWithTag("Fire_ball");
            for (int i = 0; i < game_obj.Length; i++)
            {
                Destroy(game_obj[i]);
            }
            game_obj = GameObject.FindGameObjectsWithTag("Dark_hole");
            for(int i=0;i<game_obj.Length;i++)
            {
                Destroy(game_obj[i]);
            }
            Score_Control.t = 0;

            game_over.gameObject.SetActive(true);
            replay.gameObject.SetActive(true);
            gameObject.SetActive(false);
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
        if(other.gameObject.tag == "Dark_hole")
        {
            life--;
            Check_heart();
            Destroy(other.gameObject);
        }
    }
}
