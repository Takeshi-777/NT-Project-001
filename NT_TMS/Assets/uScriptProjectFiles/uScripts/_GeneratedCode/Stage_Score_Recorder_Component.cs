//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Stage_Score_Recorder")]
public class Stage_Score_Recorder_Component : uScriptCode
{
   #pragma warning disable 414
   public Stage_Score_Recorder ExposedVariables = new Stage_Score_Recorder( ); 
   #pragma warning restore 414
   
   public System.Int32 ID_001_Count { get { return ExposedVariables.ID_001_Count; } set { ExposedVariables.ID_001_Count = value; } } 
   public System.Int32 ID_002_Count { get { return ExposedVariables.ID_002_Count; } set { ExposedVariables.ID_002_Count = value; } } 
   public System.Int32 ID_003_Count { get { return ExposedVariables.ID_003_Count; } set { ExposedVariables.ID_003_Count = value; } } 
   public System.Int32 ID_004_Count { get { return ExposedVariables.ID_004_Count; } set { ExposedVariables.ID_004_Count = value; } } 
   public System.Int32 ID_005_Count { get { return ExposedVariables.ID_005_Count; } set { ExposedVariables.ID_005_Count = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.CMR" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
      }
   #endif
}
