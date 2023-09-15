using UnityEngine;
using UnityEngine.SceneManagement;

public class levelswitch : MonoBehaviour
{
   
    public KeyCode loadSceneKey = KeyCode.Space;
    public string sceneNameToLoad;

 
    void Update()
    {
       
        if (Input.GetKeyDown(loadSceneKey))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
