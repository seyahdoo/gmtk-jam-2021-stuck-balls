using LapsEditor.Utility;
using LapsRuntime;
using UnityEditor;
using UnityEngine;

namespace LapsEditor {
    public class LapsEditorSelectionModule {
        internal static readonly Vector2 SelectionIconSize = new Vector2(30f, 30f);
        private LapsEditor _editor;
        public LapsEditorSelectionModule(LapsEditor lapsEditor) {
            _editor = lapsEditor;
        }
        public void OnSceneGUI() {
            using (Scopes.HandlesGUI()) {
                DrawLapsIcons();
            }
        }
        private void DrawLapsIcons() {
            foreach (var lapsComponent in _editor.allComponents) {
                DrawLapsIcon(lapsComponent);
            }
        }
        private void DrawLapsIcon(LapsComponent lapsComponent) {
            var rect = GetScreenSelectionRect(lapsComponent);
            var iconTexture = GetIconTexture(lapsComponent);
            IconHandle.Draw(lapsComponent, iconTexture, rect);
        }
        private Rect GetScreenSelectionRect(LapsComponent lapsComponent) {
            var rect = new Rect(GetSelectionRectPosition(lapsComponent) - SelectionIconSize / 2f, SelectionIconSize);
            return rect;
        }
        private Vector2 GetSelectionRectPosition(LapsComponent lapsComponent) {
            var screenPosition = GetScreenPosition(lapsComponent);
            if (lapsComponent.ErrorExists) {
                if (screenPosition.x < SelectionIconSize.x / 2f) {
                    screenPosition.x = SelectionIconSize.x / 2f;
                }
                if (screenPosition.x > Screen.width - SelectionIconSize.x / 2f) {
                    screenPosition.x = Screen.width - SelectionIconSize.x / 2f;
                }
                if (screenPosition.y < SelectionIconSize.y / 2f) {
                    screenPosition.y = SelectionIconSize.y / 2f;
                }
                if (screenPosition.y > Screen.height - 40 - SelectionIconSize.y / 2f) {
                    screenPosition.y = Screen.height - 40 - SelectionIconSize.y / 2f;
                }
            }
            return screenPosition;
        }
        private Vector2 GetScreenPosition(LapsComponent lapsComponent) {
            return WorldToScreenPosition(lapsComponent.transform.position);
        }
        private Vector2 WorldToScreenPosition(Vector3 worldPoint) {
            return HandleUtility.WorldToGUIPoint(worldPoint);
        }
        private Texture GetIconTexture(LapsComponent lapsComponent) {
            //todo cache this
            return Resources.Load<Texture>($"LapsIcons/{lapsComponent.GetType().Name.ToLower()}");
        }
    }
}