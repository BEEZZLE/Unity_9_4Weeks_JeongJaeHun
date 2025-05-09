using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameTrigger : MonoBehaviour, IInteractable
{
    public string miniGameSceneName;

    public void Interact()
    {
        SceneManager.LoadScene(miniGameSceneName);
    }
}
