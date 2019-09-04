using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]

public class ImageController : MonoBehaviour
{
    private Image imageComponent;
    public UnityEvent UpdateImageEvent;
    
    // Start is called before the first frame update
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent(FloatData dataobj)
    {
        imageComponent.fillAmount = dataobj.value;
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateImageEvent.Invoke();
    }
}
