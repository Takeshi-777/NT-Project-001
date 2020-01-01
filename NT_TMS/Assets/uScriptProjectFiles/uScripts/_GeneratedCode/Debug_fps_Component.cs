//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Debug_fps")]
public class Debug_fps_Component : uScriptCode
{
   #pragma warning disable 414
   public Debug_fps ExposedVariables = new Debug_fps( ); 
   #pragma warning restore 414
   
   public System.Single _001_Update_time { get { return ExposedVariables._001_Update_time; } set { ExposedVariables._001_Update_time = value; } } 
   public System.Boolean _002_SingleFrame { get { return ExposedVariables._002_SingleFrame; } set { ExposedVariables._002_SingleFrame = value; } } 
   public UnityEngine.GameObject _000_Text_obj { get { return ExposedVariables._000_Text_obj; } set { ExposedVariables._000_Text_obj = value; } } 
   
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
