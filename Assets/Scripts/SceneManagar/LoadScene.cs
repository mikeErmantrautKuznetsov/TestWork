using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private int sceneManager;

    public void NextLevel(int sceneManager)
    {
        SceneManager.LoadScene(sceneManager);                              /*Загрузчик сцены. И смена сцен*/
    }
}
