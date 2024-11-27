 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

public class transfer : MonoBehaviour
{
    [SerializeField] string sceneToTranferTo;
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        transferScene(sceneToTranferTo);
    }

    void transferScene(string scene)
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
