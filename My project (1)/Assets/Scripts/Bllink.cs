using System.Collections;
using UnityEngine;
using TMPro;


public class Bllink : MonoBehaviour
{
    private TextMeshProUGUI _message;
    private bool _inBlink = false;
    void Start()
    {
        
        _message = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (!_inBlink)
        {
            StartCoroutine(Blink()); 
        }

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     StopCoroutine(Blink());
        //     _inBlink = true;
        // }
        //
        // if (Input.GetKeyDown(KeyCode.Return))
        // {
        //     StopAllCoroutines();Coroutine(Blink());
        // }
    }

    IEnumerator Blink()
    {
        _inBlink = true;
        _message.enabled =!_message.enabled;
        
        yield return new WaitForSeconds(0.7f);
        
        _inBlink = false;
    }
}
