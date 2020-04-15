
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings_btn : MonoBehaviour
{
    public void settings_function()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
}
