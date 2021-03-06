﻿using UnityEngine;
using UnityEditor;

namespace CreateThis.Factory.VR.UI.Container {
    [CustomEditor(typeof(PanelContainerFactory))]
    [CanEditMultipleObjects]
    public class PanelContainerFactoryEditor : ContainerBaseFactoryEditor {
        SerializedProperty minWidth;
        SerializedProperty minHeight;
        SerializedProperty panelBody;
        SerializedProperty material;
        SerializedProperty highlight;
        SerializedProperty outline;
        SerializedProperty fontColor;
        SerializedProperty bodyScale;

        protected override void OnEnable() {
            base.OnEnable();
            minWidth = serializedObject.FindProperty("minWidth");
            minHeight = serializedObject.FindProperty("minHeight");
            panelBody = serializedObject.FindProperty("panelBody");
            material = serializedObject.FindProperty("material");
            highlight = serializedObject.FindProperty("highlight");
            outline = serializedObject.FindProperty("outline");
            fontColor = serializedObject.FindProperty("fontColor");
            bodyScale = serializedObject.FindProperty("bodyScale");
        }

        protected override void BuildGenerateButton() {
            if (GUILayout.Button("Generate")) {
                if (target.GetType() == typeof(PanelContainerFactory)) {
                    PanelContainerFactory containerFactory = (PanelContainerFactory)target;
                    containerFactory.Generate();
                }
            }
        }

        protected override void AdditionalProperties() {
            EditorGUILayout.PropertyField(minWidth);
            EditorGUILayout.PropertyField(minHeight);
            EditorGUILayout.PropertyField(panelBody);
            EditorGUILayout.PropertyField(material);
            EditorGUILayout.PropertyField(highlight);
            EditorGUILayout.PropertyField(outline);
            EditorGUILayout.PropertyField(fontColor);
            EditorGUILayout.PropertyField(bodyScale);
        }
    }
}
