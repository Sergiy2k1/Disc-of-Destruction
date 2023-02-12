using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _exitMenu;


    //���������� ��� ������� �� ������ ������ ����
    [UsedImplicitly]
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(GlobalConstants.GAME_SCENE);
    }
    public void ExitGame() //���������� ��� ������� �� ������ ������ �� ����
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
