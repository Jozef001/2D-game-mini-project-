using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coincollector : MonoBehaviour
{
    public Text storecoin;
    skinmanager store;
    coin coinss;
   
    void Start()
    {
        store = GameObject.FindGameObjectWithTag("store").GetComponent<skinmanager>();
        GameObject.FindGameObjectWithTag("coin").GetComponent<coin>();
    }

    // Update is called once per frame
    void Update()
    {
        storecoin.text =coin.globalpt.ToString();
       // store.coinupdate(coin.globalpt); 
    }
}
