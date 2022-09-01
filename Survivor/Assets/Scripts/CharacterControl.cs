using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Transform mermiPos;
    public GameObject mermi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject go = Instantiate(mermi, mermiPos.position, mermiPos.rotation);
            go.GetComponent<Rigidbody>().velocity = mermiPos.transform.forward*10f;
            Destroy(go.gameObject, 2f);

        }
    }
}