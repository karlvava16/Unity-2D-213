using Assets.Scripts;
using UnityEngine;

public class PigScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PigDestroy"))
        {
            GameState.isLevelCompleted = true;
            GameState.Pause("ВИГРАШ", "Рівень пройдено");
        }
    }
}
