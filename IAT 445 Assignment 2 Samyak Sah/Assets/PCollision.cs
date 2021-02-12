using UnityEngine;
using UnityEngine.SceneManagement;

public class PCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
}
