using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ally : MonoBehaviour
{

   private void Start()
    {
        
    }

   public void FriendlyFire ()
   {
      GameOverScreenSetup();
   }

   void GameOverScreenSetup()
   {
      SceneManager.LoadScene(2);
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
   }
}
