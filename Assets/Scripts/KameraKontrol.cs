using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public OyunKontrol oyunKontrol;
    public float hassasiyet, yumusaklik;
    Vector2 gecisPos;
    Vector2 camPos;

    GameObject Oyuncu;
    void Start()
    {
        Oyuncu = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunKontrol.oyunAktif) { 
        Vector2 farePos = new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));
        farePos = Vector2.Scale(farePos, new Vector2(hassasiyet * yumusaklik, hassasiyet*yumusaklik));
        gecisPos.x = Mathf.Lerp(gecisPos.x, farePos.x, 1f / yumusaklik);
        gecisPos.y = Mathf.Lerp(gecisPos.y, farePos.y, 1f / yumusaklik);
        camPos += gecisPos;
        transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);
        Oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, Oyuncu.transform.up);}
    }
}
