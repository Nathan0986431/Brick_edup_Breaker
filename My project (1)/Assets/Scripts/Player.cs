using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    private TMP_Text _liifes;
    private int _lifes= 3;
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
}

