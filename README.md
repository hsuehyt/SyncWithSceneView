# SyncWithSceneView

SyncWithSceneView is a tiny Unity editor utility that allows **any GameObject** to automatically follow the **Scene View camera** in real time while Unity is in Edit Mode.

This is useful when lining up shots, adjusting placements, previewing a camera path, or simply wanting the GameObject to match the exact angle you are navigating in the Scene View.

---

## Features

• Real-time syncing from the Scene View camera to any GameObject
• Works in Edit Mode (no need to press Play)
• Minimal, clean implementation using UnityEditor update callbacks
• Editor-only behavior — safe for builds
• Works on cameras, empties, lights, models, or any GameObject with a Transform

---

## How It Works

The script checks the Scene View's internal camera using `SceneView.lastActiveSceneView.camera` and copies its position and rotation to the GameObject every editor frame.

Because it is wrapped in `#if UNITY_EDITOR` blocks, the syncing feature only runs inside the Unity Editor. In a build, the component does nothing.

---

## Installation

1. Download or clone the repository
   [https://github.com/hsuehyt/SyncWithSceneView](https://github.com/hsuehyt/SyncWithSceneView)

2. Place `SyncWithSceneView.cs` anywhere under your Unity `Assets/` folder
   (Recommended: Assets/EditorTools/)

3. Unity will recompile automatically.
   No extra packages required.

---

## Usage

1. Select any GameObject in your Hierarchy
   (Camera, Empty, Light, Model, Group, etc.)

2. Add the component:
   Add Component → SyncWithSceneView

3. Enable “Sync In Edit Mode”

4. Move around in the Scene View: orbit, pan, zoom
   The GameObject will instantly follow the Scene View camera’s position and rotation.

Tip: View the Scene and Game tabs side-by-side to see the syncing clearly.

---

## When It Syncs

Active when:
• Unity is NOT in Play Mode
• “Sync In Edit Mode” is enabled
• A Scene View window is active and has a valid camera

Inactive when:
• Unity is in Play Mode
• Sync is toggled off
• No Scene View is active

---

## Requirements

• Unity Editor (any recent version)
• No external dependencies
• Works with Built-in, URP, and HDRP

---

## Notes

• The syncing is instant and precise (no smoothing).
• Since the Scene View camera is an internal editor camera, this tool is for editor-workflow convenience only and does not affect builds.
• Safe to use on any GameObject — not limited to Cameras.

---

## License

MIT License (recommended)
