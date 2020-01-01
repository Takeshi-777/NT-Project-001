//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/wall_sucking")]
public class wall_sucking_Component : uScriptCode
{
   #pragma warning disable 414
   public wall_sucking ExposedVariables = new wall_sucking( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject Rigid_object { get { return ExposedVariables.Rigid_object; } set { ExposedVariables.Rigid_object = value; } } 
   public System.Single Wall_fixed_time { get { return ExposedVariables.Wall_fixed_time; } set { ExposedVariables.Wall_fixed_time = value; } } 
   public UnityEngine.GameObject sensor_col_left { get { return ExposedVariables.sensor_col_left; } set { ExposedVariables.sensor_col_left = value; } } 
   public UnityEngine.GameObject sensor_col_right { get { return ExposedVariables.sensor_col_right; } set { ExposedVariables.sensor_col_right = value; } } 
   
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
