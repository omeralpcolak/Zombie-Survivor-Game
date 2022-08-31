using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiHareket : MonoBehaviour
{
    private GameObject oyuncu;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
    }
}
