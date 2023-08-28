using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int lives;
    public static float musicVolume;
    bool gameHasEnded = false;

    //RETARDO GAME OVER 
    public float restartDelay = 1f;

    //MENSAJE NIVEL COMPLETADO 
    public GameObject completelevelUI; 

    //MENSAJE GAME OVER
    public GameObject gameOverUI;

    private void InicioJuego()
    {
        GameManager.lives = 3;
        SceneManager.LoadScene("YAZ"); 
    }

    public void Start()
    {
        GameManager.lives = 3; 
    }
    public void Chocar()
    {
        GameManager.lives--;
        if(GameManager.lives <= 0)
        {
            gameOverUI.SetActive(true); 
            //SceneManager.LoadScene("Intro"); 
        }
        else
        {
            /*int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);*/
        }

    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }
    }
    public void EndGame2()
    {
        Debug.Log("Chocaste contra una pared");
    }
    public void CompleteLevel()
    {
        Debug.Log("You win");
        completelevelUI.SetActive(true);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("YAZ");
    }
}
