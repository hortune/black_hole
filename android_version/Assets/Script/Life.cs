using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    public int life;
    public GameObject game_over;
    public GameObject ins_control;
    public GameObject me;

    public GameObject main_camera;
    public GameObject canvas;

    public GameObject heart_one, heart_two, heart_three;
	// Use this for initialization
	void Start () {
        life = 3;
	}

    public void Reset()
    {
        life = 3;
        revive();
        me.SetActive(true);
        ins_control.SetActive(true);
        game_over.SetActive(false);
        Hole_ins hole_ins;
        hole_ins = ins_control.GetComponent<Hole_ins>();
        hole_ins.Start();

        canvas.SetActive(false);
        main_camera.transform.position = me.transform.position + new Vector3(0f, 50f, 0f);
        main_camera.transform.parent = me.transform;
    }

    void revive()
    {
        heart_one.gameObject.SetActive(true);
        heart_two.gameObject.SetActive(true);
        heart_three.gameObject.SetActive(true);
    }

    void charc_die()
    {
        GameObject[] game_obj;
        game_obj = GameObject.FindGameObjectsWithTag("Fire_ball");
        for (int i = 0; i < game_obj.Length; i++)
        {
            Destroy(game_obj[i]);
        }
        game_obj = GameObject.FindGameObjectsWithTag("Dark_hole");
        for (int i = 0; i < game_obj.Length; i++)
        {
            Destroy(game_obj[i]);
        }
        game_obj = GameObject.FindGameObjectsWithTag("White_hole");
        for (int i = 0; i < game_obj.Length; i++)
        {
            Destroy(game_obj[i]);
        }
        game_obj = GameObject.FindGameObjectsWithTag("Potion");
        for (int i = 0; i < game_obj.Length; i++)
        {
            Destroy(game_obj[i]);
        }
        game_obj = GameObject.FindGameObjectsWithTag("Star");
        for (int i = 0; i < game_obj.Length; i++)
        {
            Destroy(game_obj[i]);
        }
        game_obj = GameObject.FindGameObjectsWithTag("Venom");
        for (int i = 0; i < game_obj.Length; i++)
        {
            Destroy(game_obj[i]);
        }
        Score_Control.score = 0;

        game_over.gameObject.SetActive(true);
        me.SetActive(false);
        ins_control.SetActive(false);
        canvas.SetActive(true);
        main_camera.transform.position = new Vector3(30f, 90f, 0f);
        main_camera.transform.parent = null;
    }

    void Check_heart()
    {
        if (life == 0)
        {
            heart_one.gameObject.SetActive(false);

            charc_die();
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
        if(other.gameObject.tag == "Venom")
        {
            life--;
            Score_Control.score--;
            Check_heart();
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Star")
        {
            Score_Control.score += 3;
            Check_heart();
            Destroy(other.gameObject);
        }
    }
}
