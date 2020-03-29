using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        float f = 5.5f;

        bool c = true;
        bool d = false;

        string e = "Programuję w C#";
        string g = "EPG";

        Debug.Log("a: " + a + " b: " + b + " f: " + f + " c: " + c + "d: " + d + " e: " + e + " g: " + g);

        Porownanie(a, b, e, g);
        Koniukcja(a, b, c, d);
        Alternatywa(a, b, c, d);
    }
    public void Porownanie(int a, int b, string e, string g) {

        if (a == b) {
            Debug.Log("Tak");
        }
        else if (a != b) {
            Debug.Log("Nie");
        }
        if (a > b) {
            Debug.Log("Tak");
        }
        else if (a < b) {
            Debug.Log("Nie");
        }
        if (a <= b) {
            Debug.Log("Tak");
        }
        else if (a >= b) {
            Debug.Log("Nie");
        }

        if (e != g) {
            Debug.Log("różne");
        }
    }
    public void Koniukcja(int a, int b, bool c, bool d) {
        if ((a > b) && (a >= b)) {
            Debug.Log(c);
        } else {
            Debug.Log(d);
        }
        if ((a > b) && (a != b)) {
            Debug.Log(c);
        } else {
            Debug.Log(d);
        }
        if ((a < b) && (a <= b)) {
            Debug.Log(c);
        } else {
            Debug.Log(d);
        }
    }
    public void Alternatywa(int a, int b, bool c, bool d)
    {
        if ((a > b || a >= b)){
            Debug.Log(c);
        } else {
            Debug.Log(d);
        }
        if ((a != b || a >= b))
        {
            Debug.Log(c);
        } else {
            Debug.Log(d);
        }
        if ((a < b || a <= b))
        {
            Debug.Log(c);
        } else {
            Debug.Log(d);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
