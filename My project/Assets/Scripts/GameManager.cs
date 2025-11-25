using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager core;

    [Header("scenes")]
    public GameObject titleScene;
    public GameObject levelOne;
    public GameObject mainMenu;

    [Header("game State")]
    private bool paused = false;
    public List<HealthPickUp> heals;
    public List<DamageOnCollision> uFOsInPlay;
    public List<DamageOnCollision> AsteroidsInPlay;
    public int Score = 0;

    [Header("Game Information")]
    public GameObject activePlayer;
    public float minX;
    public float minY;
    public float minZ;
    public float maxX;
    public float maxY;
    public float maxZ;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if( core == null)
        {
            core = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        StartTitle();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            paused = TogglePause();
            if (paused)
            {
                mainMenu.SetActive(true);
            }
            else
            {
                mainMenu.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameQuit();
        }
    }
    bool TogglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
    public void DeactivateScenes()
    {
        titleScene.SetActive(false);
        levelOne.SetActive(false);
        mainMenu.SetActive(false);
    }

    public void StartTitle()
    {
        DeactivateScenes();
        titleScene.SetActive(true);
    }

    public void StartLevelOne()
    {
        DeactivateScenes();
        levelOne.SetActive(true);
    }
    public void GameQuit()
    {
       Application.Quit();
        Debug.Log("Game Closing!");
    }
}
