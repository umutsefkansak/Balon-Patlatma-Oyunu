using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunKontrol : MonoBehaviour
{
    public Text zamanText, balonText;
    public GameObject patlama;


    public float zamanSayaci = 60;
    public static int patlayanBalon = 0;
    public static int skor;

    void Start()
    {
       
        balonText.text = "Balon : " + patlayanBalon;
    }

    void Update()
    {
        if (zamanSayaci > 0)
        {
          zamanSayaci -= Time.deltaTime;
          zamanText.text = "Süre : " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }


            skor = patlayanBalon;
            patlayanBalon = 0;

            SceneManager.LoadScene("bitisMenu");
          
            
        }
    }

    public void balonEkle()
    {
        patlayanBalon++;
        balonText.text = "Balon : " + patlayanBalon;
    }
}
