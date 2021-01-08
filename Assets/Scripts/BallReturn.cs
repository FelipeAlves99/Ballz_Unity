using UnityEngine;

public class BallReturn : MonoBehaviour
{
    private BallLauncher ballLaucher;

    private void Awake()
    {
        ballLaucher = FindObjectOfType<BallLauncher>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballLaucher.ReturnBall();
        collision.collider.gameObject.SetActive(false);
    }
}
