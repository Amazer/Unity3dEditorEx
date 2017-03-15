using UnityEngine;
using System.Collections;
using UnityEditor;
namespace Test
{
    [CustomEditor(typeof(TestHandles))]
	public class TestHandlesEditor : Editor {

         void OnSceneGUI()
        {
            TestHandles h = target as TestHandles;

            Handles.color = Color.red;
            Handles.Label(h.transform.position, "testHandles");

            Handles.BeginGUI();
            EditorGUILayout.LabelField("test editor gui");
            GUILayout.Label("test gui");

            Handles.EndGUI();

            Handles.DrawLine(h.transform.position, h.transform.position+Vector3.one * 100f);
            Handles.CubeCap(0, Vector3.zero, Quaternion.identity, 0.5f);

        }
    }
}
