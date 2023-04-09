using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject ButtonPause;
    [SerializeField] private GameObject menuPause;
    private MusicManager _musicManager;
    public bool gamePaused = false;
    private void Start() => _musicManager = Camera.main.GetComponent<MusicManager>();

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePaused)
                Resume();
            else
                Pause();
        }
    }
   
    public void Pause()
    {
        gamePaused     = true;
        Time.timeScale = 0f;
        
        _musicManager.SwitchMusic(gamePaused);
        
        ButtonPause.SetActive(false);
        menuPause.SetActive(true);
    }
    
    public void Resume()
    {
        gamePaused     = false;
        Time.timeScale = 1f;
        
        _musicManager.SwitchMusic(gamePaused);

        ButtonPause.SetActive(true);
        menuPause.SetActive(false);
    }
    
    public void BackToMenu() =>SceneManager.LoadScene(0);
    
    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}

