using UnityEngine;
using System.Collections;

public class Destroy_fireball : MonoBehaviour {
    private int obj_obsorb;
    GameObject []de;
    void Awake()
    {
        obj_obsorb = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Me")
        {
            if(other.gameObject.tag == "Fire_ball")
                Fire_ball_ins.fire_ball_amount--;

            Destroy(other.gameObject);
            obj_obsorb++;


            Check_D();
        }
        else
        {
            de = GameObject.FindGameObjectsWithTag("Dark_hole");
            int siz = de.Length;
            if (siz>1)
            {
                Vector3 tmp;
                while (true)
                {
                    int r = Random.Range(0, siz);
                    if (gameObject.transform.position != de[r].transform.position)
                    {
                        tmp = de[r].transform.position;
                        Destroy(de[r]);
                        Hole_ins.b_h_delay_save *= 0.9f;
                        other.gameObject.transform.position = tmp;
                        break;
                    }
                }
            }
        }
    }

    void Check_D()
    {
        if (obj_obsorb > 3)
        {
            Hole_ins.black_hole_amount--;
            Destroy(gameObject);
        }
    }
}
