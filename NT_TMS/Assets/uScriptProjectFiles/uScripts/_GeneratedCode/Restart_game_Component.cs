//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Restart_game")]
public class Restart_game_Component : uScriptCode
{
   #pragma warning disable 414
   public Restart_game ExposedVariables = new Restart_game( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject ReSet_Button { get { return ExposedVariables.ReSet_Button; } set { ExposedVariables.ReSet_Button = value; } } 
   public UnityEngine.GameObject prd_anim_obj { get { return ExposedVariables.prd_anim_obj; } set { ExposedVariables.prd_anim_obj = value; } } 
   public System.Single Restart_Delay { get { return ExposedVariables.Restart_Delay; } set { ExposedVariables.Restart_Delay = value; } } 
   public UnityEngine.GameObject Main_Cam { get { return ExposedVariables.Main_Cam; } set { ExposedVariables.Main_Cam = value; } } 
   public UnityEngine.Vector2 Player_restart_pos { get { return ExposedVariables.Player_restart_pos; } set { ExposedVariables.Player_restart_pos = value; } } 
   public UnityEngine.Vector2 Guide_Cam_ResetPos { get { return ExposedVariables.Guide_Cam_ResetPos; } set { ExposedVariables.Guide_Cam_ResetPos = value; } } 
   public UnityEngine.GameObject Goal_col { get { return ExposedVariables.Goal_col; } set { ExposedVariables.Goal_col = value; } } 
   public UnityEngine.GameObject Dead_col { get { return ExposedVariables.Dead_col; } set { ExposedVariables.Dead_col = value; } } 
   public UnityEngine.GameObject ReSet_Button_02 { get { return ExposedVariables.ReSet_Button_02; } set { ExposedVariables.ReSet_Button_02 = value; } } 
   
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
            gameObject = GameObject.Find( "Player_root" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "Guide_cam" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
      }
   #endif
}
