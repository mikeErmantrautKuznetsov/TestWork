using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinRotate : MonoBehaviour
{
    private int timeLiveCoin = 2;
    public float delay = 0.2f;
    public Transform target;

    private void Start()
    {
        DOTween.Sequence()
        .Append(transform.DORotate(new Vector3(0.5f, -180, -0.5f), 0.5f))
        .AppendInterval(delay)
        .Append(transform.DORotate(new Vector3(0.5f, -360, -0.5f), 0.5f))                            /*Поворот монеты и её отключение через куратину*/
        .SetLoops(-1);
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(destryCoin());
        }
    }

    private IEnumerator destryCoin()
    {
        yield return new WaitForSeconds(timeLiveCoin);
        EndAnimation();
    }

    private void EndAnimation()
    {
        gameObject.SetActive(false);
    }
}
