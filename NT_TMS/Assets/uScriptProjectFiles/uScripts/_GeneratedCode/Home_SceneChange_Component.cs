//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Home_SceneChange")]
public class Home_SceneChange_Component : uScriptCode
{
   #pragma warning disable 414
   public Home_SceneChange ExposedVariables = new Home_SceneChange( ); 
   #pragma warning restore 414
   
   public System.Single _000_Open_Fade { get { return ExposedVariables._000_Open_Fade; } set { ExposedVariables._000_Open_Fade = value; } } 
   public UnityEngine.GameObject Fade_Controler { get { return ExposedVariables.Fade_Controler; } set { ExposedVariables.Fade_Controler = value; } } 
   public System.Int32 ChoiseGameStage { get { return ExposedVariables.ChoiseGameStage; } set { ExposedVariables.ChoiseGameStage = value; } } 
   public System.Single _001_Change_FadeTime { get { return ExposedVariables._001_Change_FadeTime; } set { ExposedVariables._001_Change_FadeTime = value; } } 
   public System.Boolean ChoiseGameMode { get { return ExposedVariables.ChoiseGameMode; } set { ExposedVariables.ChoiseGameMode = value; } } 
   public UnityEngine.GameObject _080_btncomp { get { return ExposedVariables._080_btncomp; } set { ExposedVariables._080_btncomp = value; } } 
   
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
