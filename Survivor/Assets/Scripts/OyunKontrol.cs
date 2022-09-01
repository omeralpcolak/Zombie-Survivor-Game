using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject zombi;
    private float zamanSayaci;
    private float olusumSureci = 5f;
    // Start is called before the first frame update
    void Start()
    {
        zamanSayaci = olusumSureci;
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;

        if (zamanSayaci < 0)
        {
            Vector3 pos = new Vector3(Random.Range(100f,250f), 30f, Random.Range(150f,250f));
            Instantiate(zombi,pos,Quaternion.identity);
            zamanSayaci = olusumSureci;
        }

    }
}
