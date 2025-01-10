# unity-6-mesh-renderer-anim-issue
Small contained project showing an issue in Unity 6 where mesh renderers stop working (go invisible) if animating properties of a Sprite-based shader on them

# Instructions

Start project up and open "SampleScene.unity" with Unity version 6000.0.32

Play the scene.

Notice how the Mesh Renderer cube is not visible, regardless if an animation is actively playing or not.

Click "Destroy Animators" and notice how when the animator is destroyed, the Mesh Renderer cube suddenly becomes visible.

![Unity_b7LQt6nKyD](https://github.com/user-attachments/assets/b2df6760-af4e-4b99-a635-ec1335968eec)

# Details

This is a regression from Unity 2021, in which this not does not happen. The issue is ultimately that adding an animator to something (without the animations necessarily playing) should not make meshes suddennly become invinsible.
