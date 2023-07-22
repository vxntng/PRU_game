using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinhtenlua : MonoBehaviour
{
    public GameObject tenlua;
    
    void Start()
    {
        InvokeRepeating("sinh",0,5);
        
    }

    void sinh()
    {
        GameObject a= Instantiate(tenlua, transform.position, tenlua.transform.rotation);
        a.SetActive (true);

    }

}
