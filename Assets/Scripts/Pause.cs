using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timeScale = 0f;
                isPaused = true;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1f;
                isPaused = false;
                pauseMenu.SetActive(false);
            }
        }
    }
}
