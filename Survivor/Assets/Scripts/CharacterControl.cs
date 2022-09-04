using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public AudioClip atisSesi, olmeSesi, yaralanmaSesi;
    public Transform mermiPos;
    public GameObject mermi;
    public Image canImaji;
    private float canDegeri = 100f;
    public OyunKontrol oKontrol;
    private AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            aSource.PlayOneShot(atisSesi, 1f);
            GameObject go = Instantiate(mermi, mermiPos.position, mermiPos.rotation);
            go.GetComponent<Rigidbody>().velocity = mermiPos.transform.forward*40f;
            Destroy(go.gameObject, 2f);

        }
    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("zombi"))
        {   
            aSource.PlayOneShot(yaralanmaSesi,1f);
            Debug.Log("Zombi saldýrdý");
            canDegeri -= 10f;
            float x = canDegeri / 100f;
            canImaji.fillAmount = x;
            canImaji.color = Color.Lerp(Color.red, Color.green, x);
            if (canDegeri <= 0)
            {   
                aSource.PlayOneShot(olmeSesi,1f);
                oKontrol.OyunBitti();
            }
        }
    }

}
