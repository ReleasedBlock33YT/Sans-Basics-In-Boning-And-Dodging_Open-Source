 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

public class loadvideoscene : MonoBehaviour
{
    [SerializeField] private string vidscene;
    
    public void buttonDown()
    {
        SceneManager.LoadScene(vidscene);
    }
}
