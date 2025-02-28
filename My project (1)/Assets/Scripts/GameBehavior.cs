using TMPro;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior Instance;
    
    public Utilities.GameplayState State;
    [SerializeField] private TextMeshProUGUI _pauseMessage;
    
    public float InitBallSpeed = 5.0f;
    public float BallSpeedIncrement = 1.1f;

    public Player[] Players = new Player[1];

    [SerializeField] private int _lossscore = 0;
    void Awake()
    {
        // singleton pattern
        
        // When creating an instance, check if one already exists,
        // and if the existing is the one that is trying it be created 
        if (Instance != null && Instance != this)
        {
            // If a different instance already exists,
            //please destroy the instance that is currently being created
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {

        State = Utilities.GameplayState.Play;
        _pauseMessage.enabled = false;
     
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            State = State == Utilities.GameplayState.Play
                ? Utilities.GameplayState.Pause
                : Utilities.GameplayState.Play;
            
            _pauseMessage.enabled = !_pauseMessage.enabled;
        }
    }

    public void LossPoint (int playerNumber)
    {
        Players[playerNumber - 1].Lifes--;
        CheckLoser();
    }

    private void CheckLoser()
    {
        foreach (Player p in Players)
        {
            if (p.Lifes <= _lossscore)
            {
                ResetGame();
            }
        }
    }

    private void ResetGame()
    {
        foreach (Player p in Players)
        {
            p.Lifes = 3;
        }
   
    }
}
