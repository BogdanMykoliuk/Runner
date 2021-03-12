using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public int coinsCount = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            Progress.AddCoins(coinsCount);
            UIUpdater.UpdateCoinsText();
            Destroy(this.gameObject);
        }
        if (collision.tag == "Destroyer") 
        {
            Destroy(this.gameObject);
        }
    }
}
