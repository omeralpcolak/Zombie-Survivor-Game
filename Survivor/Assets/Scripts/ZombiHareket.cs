using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiHareket : MonoBehaviour
{
    private GameObject oyuncu;
    private int zombieCan = 3;
    private float mesafe;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
        mesafe = Vector3.Distance(transform.position, oyuncu.transform.position);

        if (mesafe < 10f)
        {
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("mermi"))
        {
            Debug.Log("Çarpýþma Gerçekleþti");
            zombieCan--;
            if (zombieCan < 1)
            {
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject, 1.667f);
            }
        }
    }

}
