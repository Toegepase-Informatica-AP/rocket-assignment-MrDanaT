using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public float speed = 45f;
    public float height = 0.25f;
    public int frames = 60;
    private float frameTicks = 0;

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);

        if (frameTicks <= frames)
        {

            transform.Translate(Vector3.down * height * Time.deltaTime);
            frameTicks++;
        }
        else
        {
            frameTicks = 0;
            height = -height;
        }
    }
}
