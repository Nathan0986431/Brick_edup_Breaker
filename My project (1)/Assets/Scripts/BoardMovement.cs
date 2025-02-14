using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public float Speed = 3.0f;
    public KeyCode LeftdDirection;
    public KeyCode RightdDirection;
    public float Xlimit = 12.1f;

    void Start()
    {
        
    }


    void Update()
    {
        float movement = 0f;

        if (Input.GetKey(LeftdDirection) && transform.position.x > -Xlimit)
        {
            movement -= Speed;
        }

        if (Input.GetKey(RightdDirection) && transform.position.x < Xlimit)
        {
            movement += Speed;
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime;
        
    }
}
