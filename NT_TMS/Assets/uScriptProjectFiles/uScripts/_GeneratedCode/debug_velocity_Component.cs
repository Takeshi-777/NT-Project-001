//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/debug_velocity")]
public class debug_velocity_Component : uScriptCode
{
   #pragma warning disable 414
   public debug_velocity ExposedVariables = new debug_velocity( ); 
   #pragma warning restore 414
   
   public System.Single DB_Maugnitude { get { return ExposedVariables.DB_Maugnitude; } set { ExposedVariables.DB_Maugnitude = value; } } 
   public UnityEngine.Vector2 DB_Velocity { get { return ExposedVariables.DB_Velocity; } set { ExposedVariables.DB_Velocity = value; } } 
   public UnityEngine.GameObject rigidbody { get { return ExposedVariables.rigidbody; } set { ExposedVariables.rigidbody = value; } } 
   
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
