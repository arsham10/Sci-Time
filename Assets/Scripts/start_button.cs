using UnityEngine;
using UnityEngine.SceneManagement;

public class start_button : MonoBehaviour
{

    public void go_to_character_select()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
