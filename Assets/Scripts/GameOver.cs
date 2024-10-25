using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public TMP_Text gameOverText;
    public Image blackScreen;
    Color colorText;
    Color colorImage;
    Player player;
    private void Start()
    {
        player = FindAnyObjectByType<Player>();
        colorText = gameOverText.color;
        colorImage = blackScreen.color;
    }

    public void GetGameOver()
    {
        player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        player.pv = 100f;
        player.transform.position = player.initialPos;
        Debug.Log("GameOver");
        colorText.a = 1f;
        colorImage.a = 1f;
        gameOverText.color = colorText;
        blackScreen.color = colorImage;
        Invoke("Respawn", 2);
    }

    public void Respawn()
    {
        colorText.a = 0f;
        colorImage.a = 0f;
        gameOverText.color = colorText;
        blackScreen.color = colorImage;
        player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
