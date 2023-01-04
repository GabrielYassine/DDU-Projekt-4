using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KillCounter : MonoBehaviour
{
    public SceneShift SceneShift;
    public TMP_Text counterText;
    public int kills;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ShowKills()
    {
        counterText.text = kills.ToString();
    }

    public void AddKill()
    {
        kills++;
        ShowKills();
        if (kills >= 10)
        {
            SceneShift.Win();
        }
    }
}