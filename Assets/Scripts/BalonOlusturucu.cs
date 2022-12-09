using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{


    public GameObject balon;
    float balonOlusturmaSuresi = 0.5f;
    float zamanSayaci = 0f;
    oyunKontrol okScripti;


    
    void Start()
    {
        okScripti = this.gameObject.GetComponent<oyunKontrol>();
        
    }

  
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katsayi = (int) (okScripti.zamanSayaci / 10) - 7;
        katsayi *= -1;


        if (zamanSayaci < 0 && okScripti.zamanSayaci > 0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.58f,2.6f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, Random.Range(50f*katsayi, 100f*katsayi), 0f));
            zamanSayaci = balonOlusturmaSuresi;


        }
        
    }
}
