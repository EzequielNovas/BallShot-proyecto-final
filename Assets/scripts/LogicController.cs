using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicController : MonoBehaviour
{
    [SerializeField] private GameObject menuWin;
    [SerializeField] private int numEnemies;
    [SerializeField] private GameObject camera;
    
    void Start() => SetStart();

    private void SetStart()
    {
        numEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        menuWin.SetActive(false);
    }

    public void SubtractEnemies()
    {
        numEnemies--;

        if (numEnemies <= 0)
            menuWin.SetActive(true);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game...");
    }

    public void NextLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    public void BackToMenu() => SceneManager.LoadScene(0);
}