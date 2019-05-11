using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {
    public GameObject playerJewelsUI;
    public GameObject playerHealthUI;
    public int JewelCount = 0;
    // Update is called once per frame
    void Update () {
        playerHealthUI.gameObject.GetComponent<Text>().text = ("Health: " + (int)GameObject.Find("Warrior").GetComponent<Player_Health>().Health);
        playerJewelsUI.gameObject.GetComponent<Text>().text = ("Jewels: " + JewelCount);
    }
}
    
