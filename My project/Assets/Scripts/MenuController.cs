using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private static MenuController instance;
    int index;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.root.gameObject); // вызываем DontDestroyOnLoad для корневого GameObject
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 6)
            {
                index = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(6);
            }
            else
            {
                SceneManager.LoadScene(index);
            }
        }
    }

    
}