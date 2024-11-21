using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading;

public class LoadGameFirstScene : MonoBehaviour
{
    [SerializeField]
    private GameObject Loading;
    [SerializeField]
    private Slider scale;
    public AsyncOperation asyncOperation;

    public void Start()
    {
        StartCoroutine(LoadScene());
        Loading.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadSceneAsync(1);
        }
    }

    private IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(4);
        asyncOperation = SceneManager.LoadSceneAsync(1);   // Загрузка игры со стартовой сцены.
        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            scale.value = progress;
            yield return 0;
        }

    }
}
