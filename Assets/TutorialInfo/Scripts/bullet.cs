using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public static int score = 0; 
    public static Text scoreText; 

    void Start()
    {
        
        if (scoreText == null)
        {
            GameObject scoreObj = GameObject.Find("ScoreText");
            if (scoreObj != null)
            {
                scoreText = scoreObj.GetComponent<Text>();
                scoreText.text = "Score: " + score;
            }
            else
            {
                Debug.LogWarning("ScoreText não foi encontrado na cena!");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            score++;
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score;
            }
            Debug.Log("colidiu com o objeto");
            Destroy(collision.gameObject); // Destroi o carro
            Destroy(gameObject); // Destroi a bala
        }
        Destroy(gameObject, 5);
    }
}
