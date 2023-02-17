using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodlama : MonoBehaviour
{
    int tahmin;
    int minsayi = 1;
    int maxsayi = 100;
    bool oyunbasladi = false;
    bool oyunbitti = false;


    
    void Start()
    {
        print(" Merhaba, oyuna başlayalım mı? [E/H]");
    }


    // ---------------------------Başlangıç------------------
    void Update()
    {

        if (!oyunbasladi)

        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Harika, aklından 1-100 arasında bir sayı tut bakalım");
            print("Devam etmek için Enter'a bas");

        }

        else if (Input.GetKeyDown(KeyCode.H))
            print("Sen bilirsin");



        if (Input.GetKeyDown(KeyCode.Return)) {
            Kontrol();
            oyunbasladi = true;
        }

        else if (!oyunbitti)


        // ---------------------------Oyun--------------------


        if (Input.GetKeyDown(KeyCode.UpArrow)) {

            minsayi = tahmin;
            Kontrol();

        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {

            maxsayi = tahmin;
            Kontrol();
        }
    


        else if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Sayını buldum");

            oyunbitti = true;

        }


        }


    void Kontrol()
    {

        tahmin = (minsayi + maxsayi) / 2;
        print("Tuttuğun sayı " + tahmin + "?");
        print("Büyükse yukarı, değilse aşağı tuşuna bas, DOĞRU ise da boşluk tuşuna");

    }

    }



   
