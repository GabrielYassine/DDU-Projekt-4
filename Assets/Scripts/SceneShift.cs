using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShift : MonoBehaviour
{
    public void PlayGame ()
   {
      SceneManager.LoadScene(1);
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
   }
   
   public void Retry ()
   {
      SceneManager.LoadScene(0);
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;

   }
   public void Win ()
   {
      SceneManager.LoadScene(3);
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
   }
}