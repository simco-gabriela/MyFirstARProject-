using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    public ActionBasedController handController;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        if (!handController)
        {
            Debug.LogError("Hand controller not assigned.");
        }
    }

    private void Update()
    {
        HandleInput(handController);
    }

    private void HandleInput(ActionBasedController controller)
    {
        if (controller)
        {
            bool isGripPressed = controller.selectAction.action.ReadValue<float>() > 0.0f;
            animator.SetBool("isGrabbing", isGripPressed);

            bool isTriggerPressed = controller.activateAction.action.ReadValue<float>() > 0.0f;
            animator.SetBool("isTrigger", isTriggerPressed);

            bool isPeaceSignPressed = Input.GetKeyDown(KeyCode.N);
            animator.SetBool("isPeaceSign", isPeaceSignPressed);
        }
    }
}
