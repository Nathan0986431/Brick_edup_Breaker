using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    // private int _score = 0;
     private int _lifes;
     public int Lifes
     {
         //Shorthand get => _score;
         get => _lifes;
         
         set
         {
             _lifes = value;
             _lifesUI.text = _lifes.ToString();
         }
         
     }
     [SerializeField] private TextMeshProUGUI _lifesUI;
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
//     void Start()
//     {
//         
//     }
//
//
//     void Update()
//     {
//         
//     }
// }
