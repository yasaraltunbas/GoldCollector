using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public AudioClip gold, fall;
    public OyunKontrol oyunKontrol;
  public  float hiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunKontrol.oyunAktif) { 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        x *= Time.deltaTime * hiz;
        y *= Time.deltaTime * hiz;

        transform.Translate(x,0f,y);
        }
    }

     void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("gold")) {
            oyunKontrol.AltinArttir();
            GetComponent<AudioSource>().PlayOneShot(gold, 1f);
            Destroy(c.gameObject);
        }
        
        
        else if (c.gameObject.tag.Equals("engel")){
            oyunKontrol.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);

        }

    }
}
