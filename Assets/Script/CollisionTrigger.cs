using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathTrigger"))
        {
            Invoke("LoadDeathScene", 2.0f);
        }

        if (other.CompareTag("Finish"))
        {
            Invoke("LoadFinishScene", 2.0f);
        }

    }

    private void LoadDeathScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void LoadFinishScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}



