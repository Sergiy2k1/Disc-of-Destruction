using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private float _sceneChangeDelay;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    [UsedImplicitly]
    public void OnPlayerDied()
    {
        StartCoroutine(ShowGameOver());
    }

    private IEnumerator ShowGameOver()
    {
        yield return new WaitForSeconds(_sceneChangeDelay);
        SceneManager.LoadSceneAsync(GlobalConstants.GAME_OVER_SCENE);
    }
}
