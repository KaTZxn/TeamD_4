using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   /* public static GameManager manager;
    int sceneNum;
    [SerializeField]
    private KeyCode KeyWord;

    void Awake()
    {
        if(manager == null)
        {
            manager = this;
            DontDestroyOnLoad(this);
        }
        else if(manager != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //sceneNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyWord))
        {
            NextScene();
        }
    }
    void NextScene()
    {
        /*sceneNum++;
        if(sceneNum > 1)
        {
            sceneNum = 0;
        }
        SceneManager.LoadScene(sceneNum);
        sceneNum = Random.Range(1, 3);
        SceneManager.LoadScene(sceneNum);

    }*/
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("GoodScene");
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            Application.LoadLevel("BadScene");
        }
    }
}
