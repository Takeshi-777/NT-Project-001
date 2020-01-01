//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Game_Judgment")]
public class Game_Judgment_Component : uScriptCode
{
   #pragma warning disable 414
   public Game_Judgment ExposedVariables = new Game_Judgment( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject Dead_colider { get { return ExposedVariables.Dead_colider; } set { ExposedVariables.Dead_colider = value; } } 
   public UnityEngine.GameObject Clear_colider { get { return ExposedVariables.Clear_colider; } set { ExposedVariables.Clear_colider = value; } } 
   public System.String Clear_string { get { return ExposedVariables.Clear_string; } set { ExposedVariables.Clear_string = value; } } 
   public System.String Dead_string { get { return ExposedVariables.Dead_string; } set { ExposedVariables.Dead_string = value; } } 
   public UnityEngine.GameObject prd_animater { get { return ExposedVariables.prd_animater; } set { ExposedVariables.prd_animater = value; } } 
   
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
