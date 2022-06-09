using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BeginScenario : MonoBehaviour
{
    public void begin()
    {
        Player.prevSceneName = Player.childAlotted[0].name;
        SceneManager.LoadScene(Player.childAlotted[0].name); 
    }
}
