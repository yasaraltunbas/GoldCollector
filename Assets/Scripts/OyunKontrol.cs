using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public int goldNumber = 0;
    public Text goldText;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AltinArttir()
    {
        goldNumber += 1; 
        goldText.text = "" + goldNumber;
    }
}
