using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BitisMenu : MonoBehaviour
{
    public Text skor;

 
    

    void Start()
    {
        
    }

    void Update()
    {
        skor.text = "Skor : " + oyunKontrol.skor;

    }
}
