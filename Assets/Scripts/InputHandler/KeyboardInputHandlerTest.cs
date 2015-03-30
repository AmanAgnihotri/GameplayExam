using UnityEngine;

namespace Exam.InputHandler
{
  public class KeyboardInputHandlerTest : MonoBehaviour
  {
    private void OnEnable ()
    {
      KeyboardInputHandler.OnInputEvent += OnInputEvent;
    }

    private void OnDisable ()
    {
      KeyboardInputHandler.OnInputEvent -= OnInputEvent;
    }

    private void OnInputEvent (InputEvent inputEvent)
    {
      Debug.Log (inputEvent);
    }
  }
}
