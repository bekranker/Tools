using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(BackgroundColor))]
public class BackgroundColorDecorato : DecoratorDrawer
{
    BackgroundColor attr { get { return ((BackgroundColor)attribute); } }
    public override float GetHeight() { return 0; }

    public override void OnGUI(Rect position)
    {
        GUI.backgroundColor = attr.color;
    }
}
#endif
