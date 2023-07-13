using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollecter : MonoBehaviour
{
    public int numberOfCoins = 0;
    public AudioSource source;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);
        Coins coin = other.GetComponent<Coins>();
        if (coin != null)
        {
            numberOfCoins += coin.value;
            source.Play();
            Destroy(coin.gameObject);
        }
    }
}
