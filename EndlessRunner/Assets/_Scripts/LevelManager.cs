using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts
{
    public class LevelManager : MonoBehaviour
    {
        public void ResetLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
