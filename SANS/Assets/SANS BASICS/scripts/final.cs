using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    [SerializeField] private double timer;
    [SerializeField] private double delay;
    [SerializeField] private string returnToScene;
    // Start is called before the first frame update
    void Start()
    {
        Update();    
    }

    // Update is called once per frame
    void Update()
    {
        while (delay > 0)
        {
            delay = delay - 0.0001;
        }
        while (timer > 0)
        {
            timer = timer - 0.0001;
        }
        returnToSScene(returnToScene);
    }

    void returnToSScene(string scene)
    {
        SceneManager.LoadScene(scene);      
    }

}
