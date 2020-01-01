//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Jump_Judge_Col")]
public class Jump_Judge_Col_Component : uScriptCode
{
   #pragma warning disable 414
   public Jump_Judge_Col ExposedVariables = new Jump_Judge_Col( ); 
   #pragma warning restore 414
   
   public System.Single radius_1st { get { return ExposedVariables.radius_1st; } set { ExposedVariables.radius_1st = value; } } 
   public System.Single radius_2nd { get { return ExposedVariables.radius_2nd; } set { ExposedVariables.radius_2nd = value; } } 
   public System.Single radius_3rd { get { return ExposedVariables.radius_3rd; } set { ExposedVariables.radius_3rd = value; } } 
   public UnityEngine.GameObject Col_3rd { get { return ExposedVariables.Col_3rd; } set { ExposedVariables.Col_3rd = value; } } 
   public UnityEngine.GameObject Col_2nd { get { return ExposedVariables.Col_2nd; } set { ExposedVariables.Col_2nd = value; } } 
   public UnityEngine.GameObject Col_1st { get { return ExposedVariables.Col_1st; } set { ExposedVariables.Col_1st = value; } } 
   public System.Int32 Jump_Judge_state { get { return ExposedVariables.Jump_Judge_state; } set { ExposedVariables.Jump_Judge_state = value; } } 
   public System.Single time_01 { get { return ExposedVariables.time_01; } set { ExposedVariables.time_01 = value; } } 
   
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
