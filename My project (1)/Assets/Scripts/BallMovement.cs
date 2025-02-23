using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float YLimit = 13.0f;
    public float XLimit = 15.0f;

    private float _speed;
    private int _xDir;
    private int _yDir;

    private AudioSource _source;
    [SerializeField] private AudioClip _wallHit;
    [SerializeField] private AudioClip _BrickHit;
    [SerializeField] private AudioClip _boardHit;
    [SerializeField] private AudioClip _lose;

    void Start()
    {
        _source = GetComponent<AudioSource>();
        
        ResetBall();
    }


    void Update()
    {
        if (GameBehavior.Instance.State == Utilities.GameplayState.play)
        {
            if (Mathf.Abs(transform.position.y) >= YLimit)
            {
                transform.position += new Vector3(
                    transform.position.x,                       //X
                    Mathf.Sign(transform.position.y) *YLimit,   //Y
                    transform.position.z                        //Z
                
                );
                _xDir *= -1;
            }

            if (Mathf.Abs(transform.position.y) >= YLimit)
            {
            
                ResetBall();
            
                GameBehavior.Instance.LossPoint();
                
             
                    
            }
            transform.position += new Vector3(_speed * _xDir, _speed * _yDir, 0) * Time.deltaTime;
        }
        
    }

    void ResetBall()
    {
        transform.position = new Vector3(0, -5, 0);
        
        _xDir = Random.value > 0.5f ? 1 : -1;
        _yDir = 1;
        
        _speed = GameBehavior.Instance.InitBallSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Boards"))
        {
            _source.clip = _boardHit;
            _yDir *= -1;
            _speed *= GameBehavior.Instance.BallSpeedIncrement;
            
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            _source.clip = _wallHit;
            _xDir *= -1;
        }
    }
}
