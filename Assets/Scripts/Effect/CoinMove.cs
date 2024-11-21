using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinMove : MonoBehaviour
{
    private float speed = 0.5f;

    [SerializeField]
    private Transform transformTarget;

    void Start()
    {
        DOTween.Sequence()
        .Append(transform.DOMove(new Vector3(5.5f, -6f, -0.5f), 2f))
        .AppendInterval(speed)
        .Append(transform.DOMove(new Vector3(-0.5f, -6f, 5.5f), 2f))          /*движение монет с помощью DoTween*/
        .SetLoops(-1);
    }
}
