 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

public class loadvideo5 : MonoBehaviour
{
    [SerializeField] private string vidscene;
    
    public void buttonDown()
    {
        SceneManager.LoadScene(vidscene);
    }
}
