using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

    public string Url = "https://github.com/TUD-RSmith/test-project/tree/branchB";

    public void GoToSene1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void GoToSene2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void loadUrl()
    {
        Application.OpenURL(Url);
    }

}
