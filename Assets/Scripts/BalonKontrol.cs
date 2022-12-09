using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrol : MonoBehaviour
{

    public GameObject patlama;
    oyunKontrol oyunKontrolScripti;



     void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<oyunKontrol> ();
        
    }
    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.267f);

        oyunKontrolScripti.balonEkle();

        
    }
}
