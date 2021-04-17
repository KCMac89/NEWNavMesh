using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int health = 5;
    public static int score = 0;
    public static int maxScore = 130;

    public Text healthText;
    public Text scoreText;

    private void Update()
    {
        healthText.text = "Health: " + health.ToString();
        scoreText.text = "Score: " + score.ToString();
    }


}
