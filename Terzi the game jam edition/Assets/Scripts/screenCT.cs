using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenCT : MonoBehaviour
{
    // Start is called before the first frame update
     public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void close()
    {
        Application.Quit();
    }
}
