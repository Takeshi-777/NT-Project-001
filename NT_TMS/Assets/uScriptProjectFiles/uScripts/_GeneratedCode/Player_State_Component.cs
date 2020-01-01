//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Player_State")]
public class Player_State_Component : uScriptCode
{
   #pragma warning disable 414
   public Player_State ExposedVariables = new Player_State( ); 
   #pragma warning restore 414
   
   public System.Boolean Jump_Vector { get { return ExposedVariables.Jump_Vector; } set { ExposedVariables.Jump_Vector = value; } } 
   public UnityEngine.GameObject sensor_left_collider { get { return ExposedVariables.sensor_left_collider; } set { ExposedVariables.sensor_left_collider = value; } } 
   public UnityEngine.GameObject Floor_Colider { get { return ExposedVariables.Floor_Colider; } set { ExposedVariables.Floor_Colider = value; } } 
   public System.Boolean touch_floor { get { return ExposedVariables.touch_floor; } set { ExposedVariables.touch_floor = value; } } 
   public UnityEngine.GameObject Big_col { get { return ExposedVariables.Big_col; } set { ExposedVariables.Big_col = value; } } 
   public System.Boolean Jumpable { get { return ExposedVariables.Jumpable; } set { ExposedVariables.Jumpable = value; } } 
   public UnityEngine.GameObject sensor_Right_collider { get { return ExposedVariables.sensor_Right_collider; } set { ExposedVariables.sensor_Right_collider = value; } } 
   
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
