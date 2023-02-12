using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _exitMenu;


    //вызывается при нажатии на кнопку старта игры
    [UsedImplicitly]
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(GlobalConstants.GAME_SCENE);
    }
    public void ExitGame() //вызывается при нажатии на кнопку выхода из игры
    {
        Application.Quit();
    }

    public void QuestionExitMenu()
    {
        _mainMenu.SetActive(false);
        _exitMenu.SetActive(true);
    }

    public void NoExitGame()
    {
        _mainMenu.SetActive(true);
        _exitMenu.SetActive(false);
    }
}
