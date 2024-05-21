using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicmanager : MonoBehaviour
{
    public GameObject cat;
    public GameObject mouse;
    public Canvas canvas;
    public Canvas mainmenucanvas;
    public FixedJoystick joystick;
    public GameObject pausebutton;
    public GameObject levelupbutton;
    public Canvas pausemenu;
    public GameObject mousespawner;
    public GameObject healthbar;
    public GameObject gameendpanel;
    public catStats catstats;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI wonscoretext;
    public GameObject gamewonpanel;

    private void Start()
    {   
        if(SceneManager.GetSceneByBuildIndex(2).IsValid() == false)
            SceneManager.LoadScene("main menu",LoadSceneMode.Additive);
    }
    public void StartGame()
    {
        Actions.startaction();
        cat.SetActive(true);
        mouse.SetActive(true);
        canvas.gameObject.SetActive(true);
        mainmenucanvas.gameObject.SetActive(false);
        joystick.gameObject.SetActive(true);
        pausebutton.SetActive(true);
        levelupbutton.gameObject.SetActive(true);
        mousespawner.SetActive(true);
        healthbar.SetActive(true);
        SceneManager.UnloadSceneAsync("main menu");
    }
    public void PauseGame()
    {
        pausemenu.gameObject.SetActive(true);
        canvas.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pausemenu.gameObject.SetActive(false);
        canvas.gameObject.SetActive(true);
        Time.timeScale = 1f;
    }
    void gamelost()
    {
        cat.SetActive(false);
        mouse.SetActive(false);
        canvas.gameObject.SetActive(false);
        joystick.gameObject.SetActive(false);
        pausebutton.SetActive(false);
        levelupbutton.gameObject.SetActive(false);
        mousespawner.SetActive(false);
        healthbar.SetActive(false);
        gameendpanel.SetActive(true);
        scoretext.text = catstats.kills.ToString();
        Time.timeScale = 0;
    }
    private void OnEnable()
    {
        Actions.gamelost += gamelost;
        Actions.gamewon += gamewon;
    }
    private void OnDisable()
    {
        Actions.gamelost -= gamelost;
        Actions.gamewon -= gamewon;
    }
    public void backtomainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
        SceneManager.LoadSceneAsync("main menu", LoadSceneMode.Additive);
    }    
    public void gamewon()
    {
        cat.SetActive(false);
        mouse.SetActive(false);
        canvas.gameObject.SetActive(false);
        joystick.gameObject.SetActive(false);
        pausebutton.SetActive(false);
        levelupbutton.gameObject.SetActive(false);
        mousespawner.SetActive(false);
        healthbar.SetActive(false);
        gamewonpanel.SetActive(true);
        wonscoretext.text = catstats.kills.ToString();
        Time.timeScale = 0;
    }

}
