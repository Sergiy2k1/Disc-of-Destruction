using DG.Tweening;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _currentScoreLabel;
        [SerializeField] private TextMeshProUGUI _bestScoreLabel;
        [SerializeField] private float _newBestScoreAnimationDuration;

        [SerializeField] private AudioSource _bestScoreChangedSound;


        private void Awake()
        {
            var currentScore = PlayerPrefs.GetInt(GlobalConstants.SCORE_PREFS_KEY);
            var bestScore = PlayerPrefs.GetInt(GlobalConstants.BEST_SCORE_PREFS_KEY);

            if (currentScore > bestScore)
            {
                bestScore = currentScore;
                ShowNewBestScoreAnimation();
                SaveNewBestSore(bestScore);
            }

            _currentScoreLabel.text = currentScore.ToString();
            _bestScoreLabel.text = $"BEST {bestScore.ToString()}";
        }

        private void ShowNewBestScoreAnimation()
        {
            _bestScoreLabel.transform.DOPunchScale(Vector3.one, _newBestScoreAnimationDuration, 0);
            _bestScoreChangedSound.Play();
        }

        //���������� ��� ������� �� ������ �������� ����
        [UsedImplicitly]
        public void RestartGame()
        {
            SceneManager.LoadSceneAsync(GlobalConstants.GAME_SCENE);
        }

        public void MainMenu()
        {
            SceneManager.LoadScene(GlobalConstants.Start_SCENE);
        }

        private void SaveNewBestSore(int bestScore)
        {
            PlayerPrefs.SetInt(GlobalConstants.BEST_SCORE_PREFS_KEY, bestScore);
            PlayerPrefs.Save();
        }
    }
}