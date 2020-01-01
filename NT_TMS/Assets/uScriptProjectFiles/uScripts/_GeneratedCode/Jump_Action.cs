//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Jump_Action : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Action_object = default(UnityEngine.GameObject);
   UnityEngine.GameObject Action_object_previous = null;
   public UnityEngine.GameObject Button_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Button_obj_previous = null;
   public System.Single Force_Scale = (float) 1;
   public UnityEngine.GameObject GameParam_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject GameParam_obj_previous = null;
   public System.Single Input_Delay = (float) 0.2;
   public System.Boolean input_gate = (bool) true;
   public System.Single Judge_1_Pow = (float) 1.5;
   public System.Single Judge_3_Pow = (float) 0.8;
   public UnityEngine.GameObject JumpJudgeCol_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject JumpJudgeCol_obj_previous = null;
   System.Single local_17_System_Single = (float) 0;
   System.Single local_18_System_Single = (float) 0;
   System.Single local_21_System_Single = (float) 0;
   System.Single local_27_System_Single = (float) 0;
   System.Single local_28_System_Single = (float) 0;
   System.Single local_30_System_Single = (float) 0;
   System.Single local_44_System_Single = (float) 0;
   System.Single local_51_System_Single = (float) 0;
   System.Single local_62_System_Single = (float) 0;
   System.Single local_64_System_Single = (float) 0;
   System.Single local_65_System_Single = (float) 0;
   public UnityEngine.Vector2 Move_vector = new Vector2( (float)0, (float)0 );
   public UnityEngine.GameObject ptcl_01 = default(UnityEngine.GameObject);
   UnityEngine.GameObject ptcl_01_previous = null;
   public UnityEngine.GameObject ptcl_02 = default(UnityEngine.GameObject);
   UnityEngine.GameObject ptcl_02_previous = null;
   public UnityEngine.GameObject ptcl_03 = default(UnityEngine.GameObject);
   UnityEngine.GameObject ptcl_03_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AddForce2D logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_1 = new uScriptAct_AddForce2D( );
   UnityEngine.GameObject logic_uScriptAct_AddForce2D_Target_1 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_AddForce2D_force_1 = new Vector2( );
   System.Single logic_uScriptAct_AddForce2D_scale_1 = (float) 0;
   bool logic_uScriptAct_AddForce2D_Out_1 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_3 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_3 = true;
   bool logic_uScriptCon_CompareBool_False_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_5 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_5;
   bool logic_uScriptAct_SetBool_Out_5 = true;
   bool logic_uScriptAct_SetBool_SetTrue_5 = true;
   bool logic_uScriptAct_SetBool_SetFalse_5 = true;
   //pointer to script instanced logic node
   JumpState_Calc logic_JumpState_Calc_JumpState_Calc_9 = new JumpState_Calc( );
   UnityEngine.GameObject logic_JumpState_Calc_JumpJudgeCol_obj_9 = default(UnityEngine.GameObject);
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_12 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_12 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_12 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_12;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_12;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_12 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_14 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_14 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_14 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_14;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_14;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_16 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_16 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_16 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_16;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_16;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_19 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_19 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_19 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_19;
   bool logic_uScriptAct_SetComponentsVector2_Out_19 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_20 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_20 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_20 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_20;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_20;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_20 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_26 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_26 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_26 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_26;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_26;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_26 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_29 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_29 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_29 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_29;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_29;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_31 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_31 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_31 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_31;
   bool logic_uScriptAct_SetComponentsVector2_Out_31 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_33 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_33 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_33 = true;
   bool logic_uScriptCon_CompareBool_False_33 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_35 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_35 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_35 = true;
   bool logic_uScriptCon_CompareBool_False_35 = true;
   //pointer to script instanced logic node
   JumpState_Calc logic_JumpState_Calc_JumpState_Calc_38 = new JumpState_Calc( );
   UnityEngine.GameObject logic_JumpState_Calc_JumpJudgeCol_obj_38 = default(UnityEngine.GameObject);
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_40 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_40 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_40 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_40;
   bool logic_uScriptAct_SetComponentsVector2_Out_40 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_42 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_42 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_42 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_42;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_42;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_42 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_48 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_48 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_48 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_48;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_48;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_48 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_50 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_50 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_50 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_50;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_50;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_50 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_54 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_54 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_54 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_54;
   bool logic_uScriptAct_SetComponentsVector2_Out_54 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_56 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_56 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_56 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_56;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_56;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_56 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_58 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_58 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_58 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_58;
   bool logic_uScriptAct_SetComponentsVector2_Out_58 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_59 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_59 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_59 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_59;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_59;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_59 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector2 logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_63 = new uScriptAct_SetComponentsVector2( );
   System.Single logic_uScriptAct_SetComponentsVector2_X_63 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector2_Y_63 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetComponentsVector2_OutputVector2_63;
   bool logic_uScriptAct_SetComponentsVector2_Out_63 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_68 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_68;
   bool logic_uScriptAct_SetBool_Out_68 = true;
   bool logic_uScriptAct_SetBool_SetTrue_68 = true;
   bool logic_uScriptAct_SetBool_SetFalse_68 = true;
   //pointer to script instanced logic node
   uScriptAct_AddForce2D logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_70 = new uScriptAct_AddForce2D( );
   UnityEngine.GameObject logic_uScriptAct_AddForce2D_Target_70 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_AddForce2D_force_70 = new Vector2( );
   System.Single logic_uScriptAct_AddForce2D_scale_70 = (float) 0;
   bool logic_uScriptAct_AddForce2D_Out_70 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_73 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_73 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_73 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_73 = true;
   bool logic_uScriptAct_Delay_AfterDelay_73 = true;
   bool logic_uScriptAct_Delay_Stopped_73 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_73 = false;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_77 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_77 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_77 = true;
   bool logic_uScriptCon_CompareBool_False_77 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_79 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_79;
   bool logic_uScriptAct_SetBool_Out_79 = true;
   bool logic_uScriptAct_SetBool_SetTrue_79 = true;
   bool logic_uScriptAct_SetBool_SetFalse_79 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRigidbodyVelocity2D logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_81 = new uScriptAct_SetRigidbodyVelocity2D( );
   UnityEngine.GameObject[] logic_uScriptAct_SetRigidbodyVelocity2D_Target_81 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector2 logic_uScriptAct_SetRigidbodyVelocity2D_Velocity_81 = new Vector2( (float)0, (float)0 );
   bool logic_uScriptAct_SetRigidbodyVelocity2D_Out_81 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRigidbodyVelocity2D logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_82 = new uScriptAct_SetRigidbodyVelocity2D( );
   UnityEngine.GameObject[] logic_uScriptAct_SetRigidbodyVelocity2D_Target_82 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector2 logic_uScriptAct_SetRigidbodyVelocity2D_Velocity_82 = new Vector2( (float)0, (float)0 );
   bool logic_uScriptAct_SetRigidbodyVelocity2D_Out_82 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_76 = default(UnityEngine.GameObject);
   
   //property nodes
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_23 = (float) 0;
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_25 = (float) 0;
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_37 = (bool) false;
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_43 = (float) 0;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_45 = (float) 0;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_53 = (float) 0;
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_55 = (float) 0;
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_57 = (float) 0;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_61 = (float) 0;
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_74 = (bool) false;
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95 = (bool) false;
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97 = (bool) false;
   System.Boolean property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_99 = (bool) false;
   
   //method nodes
   System.Int32 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_83 = (int) 1;
   System.Int32 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_85 = (int) 1;
   System.Int32 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_87 = (int) 1;
   System.Int32 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_89 = (int) 1;
   System.Int32 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_92 = (int) 1;
   System.Int32 method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_93 = (int) 1;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_23_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Up_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_23_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_23;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_25_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Side_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_25_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_25;
      }
   }
   
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_37_Get_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         return component.Jumpable;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_37_Set_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         component.Jumpable = property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_37;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_43_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Side_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_43_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_43;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_45_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Up_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_45_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_45;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_53_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Up_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_53_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_53;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_55_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Side_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_55_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_55;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_57_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Side_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_57_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_57;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_61_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         return component.st_pl_Up_value;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_61_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (GameParam_obj != null)
      {
         component = GameParam_obj.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_61;
      }
   }
   
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_74_Get_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         return component.Jumpable;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_74_Set_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         component.Jumpable = property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_74;
      }
   }
   
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95_Get_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         return component.Jumpable;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95_Set_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         component.Jumpable = property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95;
      }
   }
   
   System.Boolean property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97_Get_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         return component.Jumpable;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97_Set_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         component.Jumpable = property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97;
      }
   }
   
   System.Boolean property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_99_Get_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         return component.Jump_Vector;
      }
      else
      {
         return (bool) false;
      }
   }
   
   void property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_99_Set_Refresh( )
   {
      Player_State_Component component = null;
      if (Action_object != null)
      {
         component = Action_object.GetComponent<Player_State_Component>();
      }
      if ( null != component )
      {
         component.Jump_Vector = property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_99;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Button_obj_previous != Button_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Button_obj_previous )
         {
            {
               uScript_Button component = Button_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_7;
                  component.OnButtonDown -= Instance_OnButtonDown_7;
                  component.OnButtonUp -= Instance_OnButtonUp_7;
                  component.OnButtonEnter -= Instance_OnButtonEnter_7;
                  component.OnButtonExit -= Instance_OnButtonExit_7;
                  component.OnButtonDrag -= Instance_OnButtonDrag_7;
               }
            }
         }
         
         Button_obj_previous = Button_obj;
         
         //setup new listeners
         if ( null != Button_obj )
         {
            {
               uScript_Button component = Button_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Button_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_7;
                  component.OnButtonDown += Instance_OnButtonDown_7;
                  component.OnButtonUp += Instance_OnButtonUp_7;
                  component.OnButtonEnter += Instance_OnButtonEnter_7;
                  component.OnButtonExit += Instance_OnButtonExit_7;
                  component.OnButtonDrag += Instance_OnButtonDrag_7;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( JumpJudgeCol_obj_previous != JumpJudgeCol_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         JumpJudgeCol_obj_previous = JumpJudgeCol_obj;
         
         //setup new listeners
      }
      if ( null == GameParam_obj || false == m_RegisteredForEvents )
      {
         GameParam_obj = GameObject.Find( "/_uScript" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( GameParam_obj_previous != GameParam_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         GameParam_obj_previous = GameParam_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_03_previous != ptcl_03 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_03_previous = ptcl_03;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_02_previous != ptcl_02 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_02_previous = ptcl_02;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_01_previous != ptcl_01 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_01_previous = ptcl_01;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Action_object_previous != Action_object || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Action_object_previous = Action_object;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Button_obj_previous != Button_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Button_obj_previous )
         {
            {
               uScript_Button component = Button_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_7;
                  component.OnButtonDown -= Instance_OnButtonDown_7;
                  component.OnButtonUp -= Instance_OnButtonUp_7;
                  component.OnButtonEnter -= Instance_OnButtonEnter_7;
                  component.OnButtonExit -= Instance_OnButtonExit_7;
                  component.OnButtonDrag -= Instance_OnButtonDrag_7;
               }
            }
         }
         
         Button_obj_previous = Button_obj;
         
         //setup new listeners
         if ( null != Button_obj )
         {
            {
               uScript_Button component = Button_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Button_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_7;
                  component.OnButtonDown += Instance_OnButtonDown_7;
                  component.OnButtonUp += Instance_OnButtonUp_7;
                  component.OnButtonEnter += Instance_OnButtonEnter_7;
                  component.OnButtonExit += Instance_OnButtonExit_7;
                  component.OnButtonDrag += Instance_OnButtonDrag_7;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( JumpJudgeCol_obj_previous != JumpJudgeCol_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         JumpJudgeCol_obj_previous = JumpJudgeCol_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( GameParam_obj_previous != GameParam_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         GameParam_obj_previous = GameParam_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_03_previous != ptcl_03 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_03_previous = ptcl_03;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_02_previous != ptcl_02 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_02_previous = ptcl_02;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_01_previous != ptcl_01 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_01_previous = ptcl_01;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Action_object_previous != Action_object || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Action_object_previous = Action_object;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_76 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_76 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_76 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_76.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_76.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_76;
                  component.OnLateUpdate += Instance_OnLateUpdate_76;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_76;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Button_obj )
      {
         {
            uScript_Button component = Button_obj.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_7;
               component.OnButtonDown -= Instance_OnButtonDown_7;
               component.OnButtonUp -= Instance_OnButtonUp_7;
               component.OnButtonEnter -= Instance_OnButtonEnter_7;
               component.OnButtonExit -= Instance_OnButtonExit_7;
               component.OnButtonDrag -= Instance_OnButtonDrag_7;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_76 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_76.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_76;
               component.OnLateUpdate -= Instance_OnLateUpdate_76;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_76;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_1.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_5.SetParent(g);
      logic_JumpState_Calc_JumpState_Calc_9.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_12.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_14.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_16.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_19.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_20.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_26.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_29.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_31.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_33.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_35.SetParent(g);
      logic_JumpState_Calc_JumpState_Calc_38.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_40.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_42.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_48.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_50.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_54.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_56.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_58.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_59.SetParent(g);
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_63.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_68.SetParent(g);
      logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_70.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_73.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_77.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_79.SetParent(g);
      logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_81.SetParent(g);
      logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_82.SetParent(g);
   }
   public void Awake()
   {
      logic_JumpState_Calc_JumpState_Calc_9.Awake( );
      logic_JumpState_Calc_JumpState_Calc_38.Awake( );
      
      logic_JumpState_Calc_JumpState_Calc_9.out_0 += JumpState_Calc_out_0_9;
      logic_JumpState_Calc_JumpState_Calc_9.out_1 += JumpState_Calc_out_1_9;
      logic_JumpState_Calc_JumpState_Calc_9.out_2 += JumpState_Calc_out_2_9;
      logic_JumpState_Calc_JumpState_Calc_9.out_3 += JumpState_Calc_out_3_9;
      logic_JumpState_Calc_JumpState_Calc_38.out_0 += JumpState_Calc_out_0_38;
      logic_JumpState_Calc_JumpState_Calc_38.out_1 += JumpState_Calc_out_1_38;
      logic_JumpState_Calc_JumpState_Calc_38.out_2 += JumpState_Calc_out_2_38;
      logic_JumpState_Calc_JumpState_Calc_38.out_3 += JumpState_Calc_out_3_38;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
      logic_JumpState_Calc_JumpState_Calc_9.Start( );
      logic_JumpState_Calc_JumpState_Calc_38.Start( );
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
      logic_JumpState_Calc_JumpState_Calc_9.OnEnable( );
      logic_JumpState_Calc_JumpState_Calc_38.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_JumpState_Calc_JumpState_Calc_9.OnDisable( );
      logic_JumpState_Calc_JumpState_Calc_38.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_JumpState_Calc_JumpState_Calc_9.Update( );
      logic_JumpState_Calc_JumpState_Calc_38.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_73)
      {
         Relay_DrivenDelay_73();
      }
   }
   
   public void OnDestroy()
   {
      logic_JumpState_Calc_JumpState_Calc_9.OnDestroy( );
      logic_JumpState_Calc_JumpState_Calc_38.OnDestroy( );
      logic_JumpState_Calc_JumpState_Calc_9.out_0 -= JumpState_Calc_out_0_9;
      logic_JumpState_Calc_JumpState_Calc_9.out_1 -= JumpState_Calc_out_1_9;
      logic_JumpState_Calc_JumpState_Calc_9.out_2 -= JumpState_Calc_out_2_9;
      logic_JumpState_Calc_JumpState_Calc_9.out_3 -= JumpState_Calc_out_3_9;
      logic_JumpState_Calc_JumpState_Calc_38.out_0 -= JumpState_Calc_out_0_38;
      logic_JumpState_Calc_JumpState_Calc_38.out_1 -= JumpState_Calc_out_1_38;
      logic_JumpState_Calc_JumpState_Calc_38.out_2 -= JumpState_Calc_out_2_38;
      logic_JumpState_Calc_JumpState_Calc_38.out_3 -= JumpState_Calc_out_3_38;
   }
   
   void Instance_OnButtonClick_7(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_7( );
   }
   
   void Instance_OnButtonDown_7(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_7( );
   }
   
   void Instance_OnButtonUp_7(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_7( );
   }
   
   void Instance_OnButtonEnter_7(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_7( );
   }
   
   void Instance_OnButtonExit_7(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_7( );
   }
   
   void Instance_OnButtonDrag_7(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_7( );
   }
   
   void Instance_OnUpdate_76(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_76( );
   }
   
   void Instance_OnLateUpdate_76(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_76( );
   }
   
   void Instance_OnFixedUpdate_76(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_76( );
   }
   
   void JumpState_Calc_out_0_9(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_0_9( );
   }
   
   void JumpState_Calc_out_1_9(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_1_9( );
   }
   
   void JumpState_Calc_out_2_9(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_2_9( );
   }
   
   void JumpState_Calc_out_3_9(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_3_9( );
   }
   
   void JumpState_Calc_out_0_38(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_0_38( );
   }
   
   void JumpState_Calc_out_1_38(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_1_38( );
   }
   
   void JumpState_Calc_out_2_38(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_2_38( );
   }
   
   void JumpState_Calc_out_3_38(object o, JumpState_Calc.LogicEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_out_3_38( );
   }
   
   void Relay_In_1()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Action_object_previous != Action_object || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Action_object_previous = Action_object;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_AddForce2D_Target_1 = Action_object;
            
         }
         {
            logic_uScriptAct_AddForce2D_force_1 = Move_vector;
            
         }
         {
            logic_uScriptAct_AddForce2D_scale_1 = Force_Scale;
            
         }
      }
      logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_1.In(logic_uScriptAct_AddForce2D_Target_1, logic_uScriptAct_AddForce2D_force_1, logic_uScriptAct_AddForce2D_scale_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_1.Out;
      
      if ( test_0 == true )
      {
         Relay_False_5();
      }
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_3 = property_Jump_Vector_Detox_ScriptEditor_Parameter_Jump_Vector_99_Get_Refresh( );
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.In(logic_uScriptCon_CompareBool_Bool_3);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.True;
      bool test_1 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_3.False;
      
      if ( test_0 == true )
      {
         Relay_JumpState_Calc_in_38();
      }
      if ( test_1 == true )
      {
         Relay_JumpState_Calc_in_9();
      }
   }
   
   void Relay_True_5()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_5.True(out logic_uScriptAct_SetBool_Target_5);
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95 = logic_uScriptAct_SetBool_Target_5;
      input_gate = logic_uScriptAct_SetBool_Target_5;
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_5.SetTrue;
      
      if ( test_0 == true )
      {
         Relay_In_73();
      }
   }
   
   void Relay_False_5()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_5.False(out logic_uScriptAct_SetBool_Target_5);
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95 = logic_uScriptAct_SetBool_Target_5;
      input_gate = logic_uScriptAct_SetBool_Target_5;
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_95_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_5.SetTrue;
      
      if ( test_0 == true )
      {
         Relay_In_73();
      }
   }
   
   void Relay_OnButtonClick_7()
   {
   }
   
   void Relay_OnButtonDown_7()
   {
      Relay_In_35();
   }
   
   void Relay_OnButtonUp_7()
   {
   }
   
   void Relay_OnButtonEnter_7()
   {
   }
   
   void Relay_OnButtonExit_7()
   {
   }
   
   void Relay_OnButtonDrag_7()
   {
   }
   
   void Relay_out_0_9()
   {
      Relay_In_42();
   }
   
   void Relay_out_1_9()
   {
      Relay_In_12();
   }
   
   void Relay_out_2_9()
   {
      Relay_In_42();
   }
   
   void Relay_out_3_9()
   {
      Relay_In_14();
   }
   
   void Relay_JumpState_Calc_in_9()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( JumpJudgeCol_obj_previous != JumpJudgeCol_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  JumpJudgeCol_obj_previous = JumpJudgeCol_obj;
                  
                  //setup new listeners
               }
            }
            logic_JumpState_Calc_JumpJudgeCol_obj_9 = JumpJudgeCol_obj;
            
         }
      }
      logic_JumpState_Calc_JumpState_Calc_9.JumpState_Calc_in(logic_JumpState_Calc_JumpJudgeCol_obj_9);
      
      //Don't copy 'out' values back to the global variables because this was an auto generated nested node
      //and those values get set through an event which is called before the above method exited
   }
   
   void Relay_In_12()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_12 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_23_Get_Refresh( );
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_12 = Judge_1_Pow;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_12.In(logic_uScriptAct_MultiplyFloat_v2_A_12, logic_uScriptAct_MultiplyFloat_v2_B_12, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_12, out logic_uScriptAct_MultiplyFloat_v2_IntResult_12);
      local_17_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_12;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_12.Out;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_In_14()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_14 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_23_Get_Refresh( );
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_14 = Judge_3_Pow;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_14.In(logic_uScriptAct_MultiplyFloat_v2_A_14, logic_uScriptAct_MultiplyFloat_v2_B_14, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_14, out logic_uScriptAct_MultiplyFloat_v2_IntResult_14);
      local_27_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_14;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_14.Out;
      
      if ( test_0 == true )
      {
         Relay_In_26();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_16 = Judge_1_Pow;
            
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_16 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_25_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_16.In(logic_uScriptAct_MultiplyFloat_v2_A_16, logic_uScriptAct_MultiplyFloat_v2_B_16, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_16, out logic_uScriptAct_MultiplyFloat_v2_IntResult_16);
      local_18_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_16;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_16.Out;
      
      if ( test_0 == true )
      {
         Relay_In_20();
      }
   }
   
   void Relay_In_19()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector2_X_19 = local_21_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_19 = local_17_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_19.In(logic_uScriptAct_SetComponentsVector2_X_19, logic_uScriptAct_SetComponentsVector2_Y_19, out logic_uScriptAct_SetComponentsVector2_OutputVector2_19);
      Move_vector = logic_uScriptAct_SetComponentsVector2_OutputVector2_19;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_19.Out;
      
      if ( test_0 == true )
      {
         Relay_In_82();
         Relay_Emit_83();
      }
   }
   
   void Relay_In_20()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_20 = local_18_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_20.In(logic_uScriptAct_MultiplyFloat_v2_A_20, logic_uScriptAct_MultiplyFloat_v2_B_20, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_20, out logic_uScriptAct_MultiplyFloat_v2_IntResult_20);
      local_21_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_20;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_20.Out;
      
      if ( test_0 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_In_26()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_26 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_43_Get_Refresh( );
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_26 = Judge_3_Pow;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_26.In(logic_uScriptAct_MultiplyFloat_v2_A_26, logic_uScriptAct_MultiplyFloat_v2_B_26, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_26, out logic_uScriptAct_MultiplyFloat_v2_IntResult_26);
      local_28_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_26;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_26.Out;
      
      if ( test_0 == true )
      {
         Relay_In_29();
      }
   }
   
   void Relay_In_29()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_29 = local_28_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_29.In(logic_uScriptAct_MultiplyFloat_v2_A_29, logic_uScriptAct_MultiplyFloat_v2_B_29, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_29, out logic_uScriptAct_MultiplyFloat_v2_IntResult_29);
      local_30_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_29;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_29.Out;
      
      if ( test_0 == true )
      {
         Relay_In_31();
      }
   }
   
   void Relay_In_31()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector2_X_31 = local_30_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_31 = local_27_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_31.In(logic_uScriptAct_SetComponentsVector2_X_31, logic_uScriptAct_SetComponentsVector2_Y_31, out logic_uScriptAct_SetComponentsVector2_OutputVector2_31);
      Move_vector = logic_uScriptAct_SetComponentsVector2_OutputVector2_31;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_31.Out;
      
      if ( test_0 == true )
      {
         Relay_In_82();
         Relay_Emit_87();
      }
   }
   
   void Relay_In_33()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_33 = input_gate;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_33.In(logic_uScriptCon_CompareBool_Bool_33);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_33.True;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_In_35()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_35 = property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_37_Get_Refresh( );
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_35.In(logic_uScriptCon_CompareBool_Bool_35);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_35.True;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_out_0_38()
   {
      Relay_In_58();
   }
   
   void Relay_out_1_38()
   {
      Relay_In_48();
   }
   
   void Relay_out_2_38()
   {
      Relay_In_58();
   }
   
   void Relay_out_3_38()
   {
      Relay_In_50();
   }
   
   void Relay_JumpState_Calc_in_38()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( JumpJudgeCol_obj_previous != JumpJudgeCol_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  JumpJudgeCol_obj_previous = JumpJudgeCol_obj;
                  
                  //setup new listeners
               }
            }
            logic_JumpState_Calc_JumpJudgeCol_obj_38 = JumpJudgeCol_obj;
            
         }
      }
      logic_JumpState_Calc_JumpState_Calc_38.JumpState_Calc_in(logic_JumpState_Calc_JumpJudgeCol_obj_38);
      
      //Don't copy 'out' values back to the global variables because this was an auto generated nested node
      //and those values get set through an event which is called before the above method exited
   }
   
   void Relay_In_40()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector2_X_40 = local_44_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_40 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_45_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_40.In(logic_uScriptAct_SetComponentsVector2_X_40, logic_uScriptAct_SetComponentsVector2_Y_40, out logic_uScriptAct_SetComponentsVector2_OutputVector2_40);
      Move_vector = logic_uScriptAct_SetComponentsVector2_OutputVector2_40;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_40.Out;
      
      if ( test_0 == true )
      {
         Relay_In_82();
         Relay_Emit_85();
      }
   }
   
   void Relay_In_42()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_42 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_43_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_42.In(logic_uScriptAct_MultiplyFloat_v2_A_42, logic_uScriptAct_MultiplyFloat_v2_B_42, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_42, out logic_uScriptAct_MultiplyFloat_v2_IntResult_42);
      local_44_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_42;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_42.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_In_48()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_48 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_61_Get_Refresh( );
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_48 = Judge_1_Pow;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_48.In(logic_uScriptAct_MultiplyFloat_v2_A_48, logic_uScriptAct_MultiplyFloat_v2_B_48, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_48, out logic_uScriptAct_MultiplyFloat_v2_IntResult_48);
      local_62_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_48;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_48.Out;
      
      if ( test_0 == true )
      {
         Relay_In_56();
      }
   }
   
   void Relay_In_50()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_50 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_61_Get_Refresh( );
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_50 = Judge_3_Pow;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_50.In(logic_uScriptAct_MultiplyFloat_v2_A_50, logic_uScriptAct_MultiplyFloat_v2_B_50, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_50, out logic_uScriptAct_MultiplyFloat_v2_IntResult_50);
      local_51_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_50;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_50.Out;
      
      if ( test_0 == true )
      {
         Relay_In_59();
      }
   }
   
   void Relay_In_54()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector2_X_54 = local_64_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_54 = local_62_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_54.In(logic_uScriptAct_SetComponentsVector2_X_54, logic_uScriptAct_SetComponentsVector2_Y_54, out logic_uScriptAct_SetComponentsVector2_OutputVector2_54);
      Move_vector = logic_uScriptAct_SetComponentsVector2_OutputVector2_54;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_54.Out;
      
      if ( test_0 == true )
      {
         Relay_In_81();
         Relay_Emit_93();
      }
   }
   
   void Relay_In_56()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_56 = Judge_1_Pow;
            
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_56 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_55_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_56.In(logic_uScriptAct_MultiplyFloat_v2_A_56, logic_uScriptAct_MultiplyFloat_v2_B_56, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_56, out logic_uScriptAct_MultiplyFloat_v2_IntResult_56);
      local_64_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_56;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_56.Out;
      
      if ( test_0 == true )
      {
         Relay_In_54();
      }
   }
   
   void Relay_In_58()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector2_X_58 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_57_Get_Refresh( );
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_58 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_53_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_58.In(logic_uScriptAct_SetComponentsVector2_X_58, logic_uScriptAct_SetComponentsVector2_Y_58, out logic_uScriptAct_SetComponentsVector2_OutputVector2_58);
      Move_vector = logic_uScriptAct_SetComponentsVector2_OutputVector2_58;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_58.Out;
      
      if ( test_0 == true )
      {
         Relay_In_81();
         Relay_Emit_92();
      }
   }
   
   void Relay_In_59()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_59 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_57_Get_Refresh( );
         }
         {
            logic_uScriptAct_MultiplyFloat_v2_B_59 = Judge_3_Pow;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_59.In(logic_uScriptAct_MultiplyFloat_v2_A_59, logic_uScriptAct_MultiplyFloat_v2_B_59, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_59, out logic_uScriptAct_MultiplyFloat_v2_IntResult_59);
      local_65_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_59;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_59.Out;
      
      if ( test_0 == true )
      {
         Relay_In_63();
      }
   }
   
   void Relay_In_63()
   {
      {
         {
            logic_uScriptAct_SetComponentsVector2_X_63 = local_65_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsVector2_Y_63 = local_51_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_63.In(logic_uScriptAct_SetComponentsVector2_X_63, logic_uScriptAct_SetComponentsVector2_Y_63, out logic_uScriptAct_SetComponentsVector2_OutputVector2_63);
      Move_vector = logic_uScriptAct_SetComponentsVector2_OutputVector2_63;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsVector2_uScriptAct_SetComponentsVector2_63.Out;
      
      if ( test_0 == true )
      {
         Relay_In_81();
         Relay_Emit_89();
      }
   }
   
   void Relay_True_68()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_68.True(out logic_uScriptAct_SetBool_Target_68);
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97 = logic_uScriptAct_SetBool_Target_68;
      input_gate = logic_uScriptAct_SetBool_Target_68;
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_68.SetTrue;
      
      if ( test_0 == true )
      {
         Relay_In_73();
      }
   }
   
   void Relay_False_68()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_68.False(out logic_uScriptAct_SetBool_Target_68);
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97 = logic_uScriptAct_SetBool_Target_68;
      input_gate = logic_uScriptAct_SetBool_Target_68;
      property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_97_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_68.SetTrue;
      
      if ( test_0 == true )
      {
         Relay_In_73();
      }
   }
   
   void Relay_In_70()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Action_object_previous != Action_object || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Action_object_previous = Action_object;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_AddForce2D_Target_70 = Action_object;
            
         }
         {
            logic_uScriptAct_AddForce2D_force_70 = Move_vector;
            
         }
         {
            logic_uScriptAct_AddForce2D_scale_70 = Force_Scale;
            
         }
      }
      logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_70.In(logic_uScriptAct_AddForce2D_Target_70, logic_uScriptAct_AddForce2D_force_70, logic_uScriptAct_AddForce2D_scale_70);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddForce2D_uScriptAct_AddForce2D_70.Out;
      
      if ( test_0 == true )
      {
         Relay_False_68();
      }
   }
   
   void Relay_In_73()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_73 = Input_Delay;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_73.In(logic_uScriptAct_Delay_Duration_73, logic_uScriptAct_Delay_SingleFrame_73);
      logic_uScriptAct_Delay_DrivenDelay_73 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_73.AfterDelay;
      bool test_1 = logic_uScriptAct_Delay_uScriptAct_Delay_73.Stopped;
      
      if ( test_0 == true )
      {
         Relay_True_79();
      }
      if ( test_1 == true )
      {
         Relay_True_79();
      }
   }
   
   void Relay_Stop_73()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_73 = Input_Delay;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_73.Stop(logic_uScriptAct_Delay_Duration_73, logic_uScriptAct_Delay_SingleFrame_73);
      logic_uScriptAct_Delay_DrivenDelay_73 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_73.AfterDelay;
      bool test_1 = logic_uScriptAct_Delay_uScriptAct_Delay_73.Stopped;
      
      if ( test_0 == true )
      {
         Relay_True_79();
      }
      if ( test_1 == true )
      {
         Relay_True_79();
      }
   }
   
   void Relay_DrivenDelay_73( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_73 = Input_Delay;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_73 = logic_uScriptAct_Delay_uScriptAct_Delay_73.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_73 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_73.AfterDelay == true )
         {
            Relay_True_79();
         }
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_73.Stopped == true )
         {
            Relay_True_79();
         }
      }
   }
   void Relay_OnUpdate_76()
   {
      Relay_In_77();
   }
   
   void Relay_OnLateUpdate_76()
   {
   }
   
   void Relay_OnFixedUpdate_76()
   {
   }
   
   void Relay_In_77()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_77 = property_Jumpable_Detox_ScriptEditor_Parameter_Jumpable_74_Get_Refresh( );
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_77.In(logic_uScriptCon_CompareBool_Bool_77);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_77.True;
      
      if ( test_0 == true )
      {
         Relay_Stop_73();
      }
   }
   
   void Relay_True_79()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_79.True(out logic_uScriptAct_SetBool_Target_79);
      input_gate = logic_uScriptAct_SetBool_Target_79;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_79()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_79.False(out logic_uScriptAct_SetBool_Target_79);
      input_gate = logic_uScriptAct_SetBool_Target_79;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_81()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Action_object_previous != Action_object || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Action_object_previous = Action_object;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetRigidbodyVelocity2D_Target_81.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetRigidbodyVelocity2D_Target_81, index + 1);
            }
            logic_uScriptAct_SetRigidbodyVelocity2D_Target_81[ index++ ] = Action_object;
            
         }
         {
         }
      }
      logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_81.In(logic_uScriptAct_SetRigidbodyVelocity2D_Target_81, logic_uScriptAct_SetRigidbodyVelocity2D_Velocity_81);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_81.Out;
      
      if ( test_0 == true )
      {
         Relay_In_70();
      }
   }
   
   void Relay_In_82()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Action_object_previous != Action_object || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Action_object_previous = Action_object;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetRigidbodyVelocity2D_Target_82.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetRigidbodyVelocity2D_Target_82, index + 1);
            }
            logic_uScriptAct_SetRigidbodyVelocity2D_Target_82[ index++ ] = Action_object;
            
         }
         {
         }
      }
      logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_82.In(logic_uScriptAct_SetRigidbodyVelocity2D_Target_82, logic_uScriptAct_SetRigidbodyVelocity2D_Velocity_82);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_82.Out;
      
      if ( test_0 == true )
      {
         Relay_In_1();
      }
   }
   
   void Relay_Emit_83()
   {
      {
         {
         }
      }
      {
         UnityEngine.ParticleSystem component;
         component = ptcl_01.GetComponent<UnityEngine.ParticleSystem>();
         if ( null != component )
         {
            component.Emit(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_83);
         }
      }
   }
   
   void Relay_Emit_85()
   {
      {
         {
         }
      }
      {
         UnityEngine.ParticleSystem component;
         component = ptcl_02.GetComponent<UnityEngine.ParticleSystem>();
         if ( null != component )
         {
            component.Emit(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_85);
         }
      }
   }
   
   void Relay_Emit_87()
   {
      {
         {
         }
      }
      {
         UnityEngine.ParticleSystem component;
         component = ptcl_03.GetComponent<UnityEngine.ParticleSystem>();
         if ( null != component )
         {
            component.Emit(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_87);
         }
      }
   }
   
   void Relay_Emit_89()
   {
      {
         {
         }
      }
      {
         UnityEngine.ParticleSystem component;
         component = ptcl_03.GetComponent<UnityEngine.ParticleSystem>();
         if ( null != component )
         {
            component.Emit(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_89);
         }
      }
   }
   
   void Relay_Emit_92()
   {
      {
         {
         }
      }
      {
         UnityEngine.ParticleSystem component;
         component = ptcl_02.GetComponent<UnityEngine.ParticleSystem>();
         if ( null != component )
         {
            component.Emit(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_92);
         }
      }
   }
   
   void Relay_Emit_93()
   {
      {
         {
         }
      }
      {
         UnityEngine.ParticleSystem component;
         component = ptcl_01.GetComponent<UnityEngine.ParticleSystem>();
         if ( null != component )
         {
            component.Emit(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_count_93);
         }
      }
   }
   
}
