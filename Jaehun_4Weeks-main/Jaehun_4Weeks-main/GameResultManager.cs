using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameResultManager : MonoBehaviour
{
    public Text resultText;
    public Button returnButton;
    
    private int finalScore;

    void Start()
    {
        finalScore = ScoreManager.Instance.currentScore;

        resultText.text = $"게임 종료!\n점수: {finalScore}";
        returnButton.onClick.AddListener(ReturnToMainScene);
    }

    void ReturnToMainScene()
    {
        SceneManager.LoadScene("MainScene"); 
    }
}
