using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button_for_settings : MonoBehaviour
{
    public void back_function_settings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
