using UnityEngine;
using System.Collections;

public class Destroy_fireball : MonoBehaviour {
    private int obj_obsorb;
    static int total_black_hole = 0;
    GameObject []de;
    Transform charc;
    GameObject dark_hole;
    void Awake()
    {
        total_black_hole++;
        obj_obsorb = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Me")
        {
            Destroy(other.gameObject);
            obj_obsorb++;
            Check_D();
        }
        else
        {
            if(total_black_hole>1)
            {
            
                    de = GameObject.FindGameObjectsWithTag("Dark_hole");
                Vector3 tmp;
                     int siz = de.Length;
                while (true)
                {

                    int r = Random.Range(0, siz);
                    if (gameObject.transform.position != de[r].transform.position)
                    {
                        tmp = de[r].transform.position;
                        Destroy(de[r]);
                        Vector3 pos = new Vector3(Random.Range(-45f, 45f), 0.5f, Random.Range(-45f, 45f));
                        other.gameObject.transform.position = tmp;
                        while (Vector3.Distance(pos, charc.position) < 35)
                            pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
                        Instantiate(dark_hole, pos, Quaternion.identity);
                    }
                }
        
               
            }
        }
    }

    void Check_D()
    {
        if (obj_obsorb > 4)
        {
            Destroy(gameObject);
            total_black_hole++;
        }
    }
}
