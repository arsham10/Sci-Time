
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_button : MonoBehaviour
{
    public void back_function()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
