using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI endText;
  [SerializeField] private TextMeshProUGUI scoreText;
  [SerializeField] private TextMeshProUGUI versionText;
  [SerializeField] private GameObject gameOverUI;

  private void Start()
  {
    versionText.text = $"v{Application.version}";
    StartGamee();
  }

  public void UpdateScore(int end, (int, int) scores)
  {
    endText.text = $"End {end}";
    scoreText.text = $"{scores.Item1} - {scores.Item2}";
  }

  public void EndGame()
  {
    gameOverUI.SetActive(true);
  }

  public void StartGamee()
  {
    gameOverUI.SetActive(false);
  }
}
