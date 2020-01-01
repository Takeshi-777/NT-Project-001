//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Game_Param")]
public class Game_Param_Component : uScriptCode
{
   #pragma warning disable 414
   public Game_Param ExposedVariables = new Game_Param( ); 
   #pragma warning restore 414
   
   public System.Single pl_Side_value { get { return ExposedVariables.pl_Side_value; } set { ExposedVariables.pl_Side_value = value; } } 
   public System.Single pl_Up_value { get { return ExposedVariables.pl_Up_value; } set { ExposedVariables.pl_Up_value = value; } } 
   public System.Single st_pl_Side_value { get { return ExposedVariables.st_pl_Side_value; } set { ExposedVariables.st_pl_Side_value = value; } } 
   public System.Single st_pl_Up_value { get { return ExposedVariables.st_pl_Up_value; } set { ExposedVariables.st_pl_Up_value = value; } } 
   
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
