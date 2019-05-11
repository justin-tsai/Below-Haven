using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    
    public Player_Move gamePlayer;
    public int coins;
    // Use this for initialization
    void Start()
    {
        gamePlayer = FindObjectOfType<Player_Move>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void AddCoins(int numberOfCoins)
    {
        coins += numberOfCoins;
    }
}
