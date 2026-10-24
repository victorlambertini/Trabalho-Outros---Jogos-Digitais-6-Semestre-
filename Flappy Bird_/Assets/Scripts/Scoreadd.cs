
using UnityEngine;

public class Scoreadd : MonoBehaviour
{
    private Score score;

    private void Start()
    {
        score = Object.FindFirstObjectByType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Fly_Logic>() != null)
        {
            if (score != null)
            {
                score.scoreValue++;
                score.scoreTxt.text = score.scoreValue.ToString();

                Debug.Log("Pontos: " + score.scoreValue);
            }
            else
            {
                Debug.LogError("Score Manager não encontrado!");
            }
        }
    }
}
