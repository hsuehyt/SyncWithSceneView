using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteAlways]   // Runs in Edit Mode and Play Mode
public class SyncWithSceneView : MonoBehaviour
{
    public bool syncInEditMode = true;

#if UNITY_EDITOR
    private void OnEnable()
    {
        EditorApplication.update += EditorUpdate;
    }

    private void OnDisable()
    {
        EditorApplication.update -= EditorUpdate;
    }

    private void EditorUpdate()
    {
        // Only sync in Edit Mode
        if (!Application.isPlaying && syncInEditMode)
        {
            if (SceneView.lastActiveSceneView == null) return;

            Camera sceneViewCam = SceneView.lastActiveSceneView.camera;
            if (sceneViewCam == null) return;

            // Direct copy (precise syncing)
            transform.position = sceneViewCam.transform.position;
            transform.rotation = sceneViewCam.transform.rotation;
        }
    }
#endif
}
