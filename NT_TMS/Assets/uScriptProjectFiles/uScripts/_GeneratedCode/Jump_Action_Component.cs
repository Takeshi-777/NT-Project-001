//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Jump_Action")]
public class Jump_Action_Component : uScriptCode
{
   #pragma warning disable 414
   public Jump_Action ExposedVariables = new Jump_Action( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject Button_obj { get { return ExposedVariables.Button_obj; } set { ExposedVariables.Button_obj = value; } } 
   public UnityEngine.GameObject JumpJudgeCol_obj { get { return ExposedVariables.JumpJudgeCol_obj; } set { ExposedVariables.JumpJudgeCol_obj = value; } } 
   public System.Single Judge_3_Pow { get { return ExposedVariables.Judge_3_Pow; } set { ExposedVariables.Judge_3_Pow = value; } } 
   public UnityEngine.GameObject GameParam_obj { get { return ExposedVariables.GameParam_obj; } set { ExposedVariables.GameParam_obj = value; } } 
   public System.Single Judge_1_Pow { get { return ExposedVariables.Judge_1_Pow; } set { ExposedVariables.Judge_1_Pow = value; } } 
   public UnityEngine.Vector2 Move_vector { get { return ExposedVariables.Move_vector; } set { ExposedVariables.Move_vector = value; } } 
   public System.Single Force_Scale { get { return ExposedVariables.Force_Scale; } set { ExposedVariables.Force_Scale = value; } } 
   public System.Single Input_Delay { get { return ExposedVariables.Input_Delay; } set { ExposedVariables.Input_Delay = value; } } 
   public System.Boolean input_gate { get { return ExposedVariables.input_gate; } set { ExposedVariables.input_gate = value; } } 
   public UnityEngine.GameObject ptcl_03 { get { return ExposedVariables.ptcl_03; } set { ExposedVariables.ptcl_03 = value; } } 
   public UnityEngine.GameObject ptcl_02 { get { return ExposedVariables.ptcl_02; } set { ExposedVariables.ptcl_02 = value; } } 
   public UnityEngine.GameObject ptcl_01 { get { return ExposedVariables.ptcl_01; } set { ExposedVariables.ptcl_01 = value; } } 
   public UnityEngine.GameObject Action_object { get { return ExposedVariables.Action_object; } set { ExposedVariables.Action_object = value; } } 
   
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
            gameObject = GameObject.Find( "/_uScript" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_variables.png");
         }
      }
   #endif
}
