using System;
using UnityEngine;
using System.Collections.Generic;

namespace Exam.InputHandler
{
  public class KeyboardInputHandler : MonoBehaviour
  {
    public static event Action<InputEvent> OnInputEvent;

    public static IDictionary<KeyCode, InputEvent> KeyBindings { get; private set; }

    private void Start ()
    {
      KeyBindings = new Dictionary<KeyCode, InputEvent> ();

      KeyBindings [KeyCode.X] = InputEvent.Jump;
      KeyBindings [KeyCode.C] = InputEvent.Shoot;
      KeyBindings [KeyCode.V] = InputEvent.Punch;
      KeyBindings [KeyCode.B] = InputEvent.Duck;
    }

    private void Update ()
    {
      foreach (var keyBinding in KeyBindings)
      {
        if (Input.GetKeyDown (keyBinding.Key))
        {
          OnInputEvent (keyBinding.Value);
        }
      }
    }
  }
}
