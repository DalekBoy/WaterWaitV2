using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //private StarterAssets input;
    private InputAction menu;

    [SerializeField] private GameObject pauseUI;
    [SerializeField] private bool isPaused;

    void Awake()
    {
        //input = new StarterAssetsInputs();
    }

    private void Update()
    {
        
    }

    private void OnEnable()
    {
        //menu = input.PauseMenu
    }

    private void OnDisable()
    {
        
    }




}
