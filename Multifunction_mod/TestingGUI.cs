using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Vector2 = UnityEngine.Vector2;

namespace Multifunction_mod
{
    internal class TestingGUI
    {
        Rect windowRect = new Rect(20, 20, 120, 50);

        public void OnGUI()
        {
            // Register the window. Notice the 3rd parameter
            windowRect = GUILayout.Window(0, windowRect, DoMyWindow, "My Window");
        }

        // Make the contents of the window
        public void DoMyWindow(int windowID)
        {
            // This button will size to fit the window
            if (GUILayout.Button("Hello World"))
            {
               Text.print("Got a click");
            }
        }
    }
}
