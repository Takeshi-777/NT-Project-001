//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/debug_menu")]
public class debug_menu_Component : uScriptCode
{
   #pragma warning disable 414
   public debug_menu ExposedVariables = new debug_menu( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject _st_pl_side_value_txtobj { get { return ExposedVariables._st_pl_side_value_txtobj; } set { ExposedVariables._st_pl_side_value_txtobj = value; } } 
   public UnityEngine.GameObject add_button { get { return ExposedVariables.add_button; } set { ExposedVariables.add_button = value; } } 
   public UnityEngine.GameObject minas_buton { get { return ExposedVariables.minas_buton; } set { ExposedVariables.minas_buton = value; } } 
   public UnityEngine.GameObject UP_add_button { get { return ExposedVariables.UP_add_button; } set { ExposedVariables.UP_add_button = value; } } 
   public UnityEngine.GameObject UP_minas_buton { get { return ExposedVariables.UP_minas_buton; } set { ExposedVariables.UP_minas_buton = value; } } 
   public UnityEngine.GameObject _st_pl_UP_value_txtobj { get { return ExposedVariables._st_pl_UP_value_txtobj; } set { ExposedVariables._st_pl_UP_value_txtobj = value; } } 
   public System.Single param_UP { get { return ExposedVariables.param_UP; } set { ExposedVariables.param_UP = value; } } 
   public UnityEngine.GameObject Reset_Button { get { return ExposedVariables.Reset_Button; } set { ExposedVariables.Reset_Button = value; } } 
   public System.Single def_XvecValue { get { return ExposedVariables.def_XvecValue; } set { ExposedVariables.def_XvecValue = value; } } 
   public System.Single def_YvecValue { get { return ExposedVariables.def_YvecValue; } set { ExposedVariables.def_YvecValue = value; } } 
   
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
