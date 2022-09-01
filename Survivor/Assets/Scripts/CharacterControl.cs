using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public Transform mermiPos;
    public GameObject mermi;
    public Image canImaji;
    private float canDegeri = 100f;
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
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("zombi"))
        {
            Debug.Log("Zombi saldýrdý");
            canDegeri -= 10f;
            float x = canDegeri / 100f;
            canImaji.fillAmount = x;
            canImaji.color = Color.Lerp(Color.red, Color.green, x);
        }
    }

}
