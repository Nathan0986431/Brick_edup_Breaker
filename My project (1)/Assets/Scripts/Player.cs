using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    // private int _score = 0;
    private int _lives = 3;
    
    // Lives get
     public int Lives
     {
         //Shorthand get => _score;
         get
         {
             return _lives;
         }
         set
         {
             _lives = value;
         }
         [SerializeField] private TextMeshProUGUI _livesUI;
     }
    
    //Score get
    // public int Score
    // {
    //     //Getter property
    //     get
    //     {
    //         return _score * 100;
    //     }
    //     //Setter property 
    //     set
    //     {
    //         _score = value;
    //         _scoreUI.text = _score.ToString();
    //     }
    //     
    //     [SerializeField] private TextmeshProUGUI _scoreUI;
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
