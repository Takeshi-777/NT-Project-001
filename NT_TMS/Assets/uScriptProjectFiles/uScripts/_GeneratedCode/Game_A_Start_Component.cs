//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Game_A_Start")]
public class Game_A_Start_Component : uScriptCode
{
   #pragma warning disable 414
   public Game_A_Start ExposedVariables = new Game_A_Start( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject _000_StageRoot_Obj { get { return ExposedVariables._000_StageRoot_Obj; } set { ExposedVariables._000_StageRoot_Obj = value; } } 
   public UnityEngine.GameObject Height_txt_obj { get { return ExposedVariables.Height_txt_obj; } set { ExposedVariables.Height_txt_obj = value; } } 
   public UnityEngine.GameObject stage_txt_obj { get { return ExposedVariables.stage_txt_obj; } set { ExposedVariables.stage_txt_obj = value; } } 
   public UnityEngine.GameObject PlayerRoot { get { return ExposedVariables.PlayerRoot; } set { ExposedVariables.PlayerRoot = value; } } 
   
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
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "Stage_root" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
      }
   #endif
}
