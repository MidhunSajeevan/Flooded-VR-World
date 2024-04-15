using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty PinchInputProperty;
    public InputActionProperty GripInputProperty;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float trigerValue = PinchInputProperty.action.ReadValue<float>();
        animator.SetFloat("Trigger", trigerValue);

        float gripValue= GripInputProperty.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);
    }
}
