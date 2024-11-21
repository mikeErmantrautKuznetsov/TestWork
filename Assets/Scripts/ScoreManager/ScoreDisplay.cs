using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private int scoreClick;

    [SerializeField]
    private Text scoreText;

    private void Start()
    {
        scoreClick = 0;
    }

    public void ButtonClick()
    {
        scoreClick++;                                  /*����� � ���������� ����� ���� �����*/
    }

    public void Update()
    {
        scoreText.text = "����: " + scoreClick;
    }
}
