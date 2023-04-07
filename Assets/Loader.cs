using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("OpenArScene", waitTime);
    }
    void OpenArScene()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
