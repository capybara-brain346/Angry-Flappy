using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject GameFatal;

    [ContextMenu("Increase Score")]
    public void addscore()
    {
        playerscore++;
        scoreText.text = playerscore.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        GameFatal.SetActive(true);
    }
}
