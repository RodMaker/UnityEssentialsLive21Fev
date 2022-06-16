using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadPreviousSceneButton : MonoBehaviour
    {
        
        public void LoadPreviousScene() 
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        }
    }
}
