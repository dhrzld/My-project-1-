using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    
    public void GameOver()
    {
        
        RestartGame();
    }

    
    public void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
