using UnityEditor;
#if UNITY_2020_2_OR_NEWER
using UnityEditor.AssetImporters;
#else
using UnityEditor.Experimental.AssetImporters;
#endif

namespace Yarn.Unity
{
    [CustomEditor(typeof(YarnProject))]
    public class YarnProjectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.LabelField("wow this is an embedded asset");

        }
    }

}
