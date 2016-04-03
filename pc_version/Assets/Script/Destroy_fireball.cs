using UnityEngine;
using System.Collections;

public class Destroy_fireball : MonoBehaviour {
    private int obj_obsorb;
   // static int total_black_hole = 0;
    GameObject []de;
    public Transform charc;
    //public GameObject dark_hole;
    void Awake()
    {
       // total_black_hole++;
        obj_obsorb = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Me")
        {
            Fire_ball_ins.fire_ball_amount--;
            Destroy(other.gameObject);
            obj_obsorb++;
            Check_D();
           
        }
        else
        {
            //if(total_black_hole>1)
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
                        Vector3 pos = new Vector3(Random.Range(-45f, 45f), 0.5f, Random.Range(-45f, 45f));
                        other.gameObject.transform.position = tmp;
                        //charc = other.gameObject.transform;
                        break;
                    }
                }
            }
        }
    }

    void Check_D()
    {
        if (obj_obsorb > 4)
        {
            Dark_hole_ins.hole_count--;
           // total_black_hole++;
            Destroy(gameObject);
        }
    }
}
