 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;

public class secret : MonoBehaviour
{
    char A = 's';
    char B = 'e';
    char C = 'c';
    char D = 'r';
    char E = 't';
    [SerializeField] string SceneToGoTo;

    bool s = false;
    bool ee = false;
    bool cc = false;
    bool r = false;
    bool tt = false;

    bool ready = false;

    // Start is called before the first frame update
    void Start()
    {
        // NOTHING HERE, GOTO Update()
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        if (ready)
        {
            LoadScene(SceneToGoTo);
        }
    }

    void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
        return;
    }

    void resetValues()
    {
        s = false;
        ee = false;
        cc = false;
        r = false;
        tt = false;
        return;
    }

    void getInput()
    {
        if (Input.GetKeyDown("s"))
        {
            s = true;
        }
        if (Input.GetKeyDown("e"))
        {
            if (s)
            {
                ee = true;
            }
        }
        if (Input.GetKeyDown("c"))
        {
            if (ee)
            {
                cc = true;
            }
        }
        if (Input.GetKeyDown("r"))
        {
            if (cc)
            {
                r = true;
            }
        }
        if (Input.GetKeyDown("t"))
        {
            if (r)
            {
                tt = true;
            }
        }
        if (s)
        {
            if (ee)
            {
                if (cc)
                {
                    if (r)
                    {
                        if (tt)
                        {
                            ready = true;
                            resetValues();
                        }
                    }
                }
            }
        }
        return;
    }
}
