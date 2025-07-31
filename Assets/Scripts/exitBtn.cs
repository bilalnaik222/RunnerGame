using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    // Assign this to your Button's OnClick event
    public void OnExitButtonClick()
    {
        SceneManager.LoadScene(1);  // Instantly load scene with index 1
    }
}
