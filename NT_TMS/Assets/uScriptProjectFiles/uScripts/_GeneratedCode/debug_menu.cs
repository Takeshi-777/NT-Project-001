//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class debug_menu : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _st_pl_side_value_txtobj = default(UnityEngine.GameObject);
   UnityEngine.GameObject _st_pl_side_value_txtobj_previous = null;
   public UnityEngine.GameObject _st_pl_UP_value_txtobj = default(UnityEngine.GameObject);
   UnityEngine.GameObject _st_pl_UP_value_txtobj_previous = null;
   public UnityEngine.GameObject add_button = default(UnityEngine.GameObject);
   UnityEngine.GameObject add_button_previous = null;
   public System.Single def_XvecValue = (float) 0;
   public System.Single def_YvecValue = (float) 0;
   System.String local_110_System_String = "Player_Jump_Vector_Y";
   System.String local_114_System_String = "Player_Jump_Vector_X";
   System.String local_125_System_String = "Player_Jump_Vector_X";
   System.String local_126_System_String = "Player_Jump_Vector_Y";
   System.Single local_14_System_Single = (float) -10;
   System.String local_23_System_String = "";
   System.Single local_28_System_Single = (float) -10;
   System.String local_38_System_String = "Player_Jump_Vector_Y";
   System.String local_40_System_String = "Player_Jump_Vector_X";
   System.String local_5_System_String = "";
   public UnityEngine.GameObject minas_buton = default(UnityEngine.GameObject);
   UnityEngine.GameObject minas_buton_previous = null;
   public System.Single param_UP = (float) 10;
   public UnityEngine.GameObject Reset_Button = default(UnityEngine.GameObject);
   UnityEngine.GameObject Reset_Button_previous = null;
   public UnityEngine.GameObject UP_add_button = default(UnityEngine.GameObject);
   UnityEngine.GameObject UP_add_button_previous = null;
   public UnityEngine.GameObject UP_minas_buton = default(UnityEngine.GameObject);
   UnityEngine.GameObject UP_minas_buton_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_1 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_1 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_1 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_1 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_1 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_1;
   bool logic_uScriptAct_SetString_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_4 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_4 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_4 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_4 = "";
   System.String logic_uScriptAct_FloatToString_CustomCulture_4 = "";
   System.String logic_uScriptAct_FloatToString_Result_4;
   bool logic_uScriptAct_FloatToString_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_8 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_8 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_8 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_8;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_8;
   bool logic_uScriptAct_AddFloat_v2_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_13 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_13 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_13 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_13;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_13;
   bool logic_uScriptAct_AddFloat_v2_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_17 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_17 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_17 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_17 = "";
   System.String logic_uScriptAct_FloatToString_CustomCulture_17 = "";
   System.String logic_uScriptAct_FloatToString_Result_17;
   bool logic_uScriptAct_FloatToString_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_21 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_21 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_21 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_21 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_21 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_21;
   bool logic_uScriptAct_SetString_Out_21 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_26 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_26 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_26 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_26;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_26;
   bool logic_uScriptAct_AddFloat_v2_Out_26 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_27 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_27 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_27 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_27;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_27;
   bool logic_uScriptAct_AddFloat_v2_Out_27 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_32 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_32 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_32 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_32;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_32;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_32 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_34 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_34 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_34 = (float) -1;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_34;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_34;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_34 = true;
   //pointer to script instanced logic node
   uScriptAct_SetPreferenceKeyFloat logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_39 = new uScriptAct_SetPreferenceKeyFloat( );
   System.String logic_uScriptAct_SetPreferenceKeyFloat_KeyName_39 = "";
   System.Single logic_uScriptAct_SetPreferenceKeyFloat_Value_39 = (float) 0;
   bool logic_uScriptAct_SetPreferenceKeyFloat_Out_39 = true;
   //pointer to script instanced logic node
   uScriptAct_SetPreferenceKeyFloat logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_41 = new uScriptAct_SetPreferenceKeyFloat( );
   System.String logic_uScriptAct_SetPreferenceKeyFloat_KeyName_41 = "";
   System.Single logic_uScriptAct_SetPreferenceKeyFloat_Value_41 = (float) 0;
   bool logic_uScriptAct_SetPreferenceKeyFloat_Out_41 = true;
   //pointer to script instanced logic node
   uScriptAct_SavePreferences logic_uScriptAct_SavePreferences_uScriptAct_SavePreferences_45 = new uScriptAct_SavePreferences( );
   bool logic_uScriptAct_SavePreferences_Out_45 = true;
   //pointer to script instanced logic node
   uScriptAct_SavePreferences logic_uScriptAct_SavePreferences_uScriptAct_SavePreferences_46 = new uScriptAct_SavePreferences( );
   bool logic_uScriptAct_SavePreferences_Out_46 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_49 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_49 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_49;
   bool logic_uScriptAct_SetFloat_Out_49 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_50 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_50 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_50;
   bool logic_uScriptAct_SetFloat_Out_50 = true;
   //pointer to script instanced logic node
   uScriptAct_SetPreferenceKeyFloat logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_111 = new uScriptAct_SetPreferenceKeyFloat( );
   System.String logic_uScriptAct_SetPreferenceKeyFloat_KeyName_111 = "";
   System.Single logic_uScriptAct_SetPreferenceKeyFloat_Value_111 = (float) 0;
   bool logic_uScriptAct_SetPreferenceKeyFloat_Out_111 = true;
   //pointer to script instanced logic node
   uScriptAct_SetPreferenceKeyFloat logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_113 = new uScriptAct_SetPreferenceKeyFloat( );
   System.String logic_uScriptAct_SetPreferenceKeyFloat_KeyName_113 = "";
   System.Single logic_uScriptAct_SetPreferenceKeyFloat_Value_113 = (float) 0;
   bool logic_uScriptAct_SetPreferenceKeyFloat_Out_113 = true;
   //pointer to script instanced logic node
   uScript_GraphEvents logic_uScript_GraphEvents_uScript_GraphEvents_122 = new uScript_GraphEvents( );
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyFloat logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_123 = new uScriptAct_GetPreferenceKeyFloat( );
   System.String logic_uScriptAct_GetPreferenceKeyFloat_KeyName_123 = "";
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_123 = (float) 0;
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_Value_123;
   bool logic_uScriptAct_GetPreferenceKeyFloat_Out_123 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPreferenceKeyFloat logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_128 = new uScriptAct_GetPreferenceKeyFloat( );
   System.String logic_uScriptAct_GetPreferenceKeyFloat_KeyName_128 = "";
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_128 = (float) 0;
   System.Single logic_uScriptAct_GetPreferenceKeyFloat_Value_128;
   bool logic_uScriptAct_GetPreferenceKeyFloat_Out_128 = true;
   
   //event nodes
   
   //property nodes
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_2 = (float) 0;
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous = null;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3 = (float) 0;
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous = null;
   System.String property_text_Detox_ScriptEditor_Parameter_text_6 = "";
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9 = (float) 0;
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous = null;
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12 = (float) 0;
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous = null;
   System.String property_text_Detox_ScriptEditor_Parameter_text_25 = "";
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_29 = (float) 0;
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous = null;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30 = (float) 0;
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous = null;
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47 = (float) 0;
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous = null;
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48 = (float) 0;
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 = default(UnityEngine.GameObject);
   UnityEngine.GameObject property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous = null;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_2_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_2_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_2;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_6_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_st_pl_side_value_txtobj != null)
      {
         component = _st_pl_side_value_txtobj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_6_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_st_pl_side_value_txtobj != null)
      {
         component = _st_pl_side_value_txtobj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_6;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_25_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_st_pl_UP_value_txtobj != null)
      {
         component = _st_pl_UP_value_txtobj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_25_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_st_pl_UP_value_txtobj != null)
      {
         component = _st_pl_UP_value_txtobj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_25;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_29_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_29_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_29;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30;
      }
   }
   
   System.Single property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 != null)
      {
         component = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Up_value = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47;
      }
   }
   
   System.Single property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48_Get_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48.GetComponent<Game_Param_Component>();
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
   
   void property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48_Set_Refresh( )
   {
      Game_Param_Component component = null;
      if (property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 != null)
      {
         component = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48.GetComponent<Game_Param_Component>();
      }
      if ( null != component )
      {
         component.st_pl_Side_value = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      if ( null == property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
      {
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 || false == m_RegisteredForEvents )
      {
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
      {
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
      {
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
      {
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 || false == m_RegisteredForEvents )
      {
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 || false == m_RegisteredForEvents )
      {
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47;
         
         //setup new listeners
      }
      if ( null == property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 || false == m_RegisteredForEvents )
      {
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 = uScript_MasterComponent.LatestMaster;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48;
         
         //setup new listeners
      }
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _st_pl_side_value_txtobj_previous != _st_pl_side_value_txtobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _st_pl_side_value_txtobj_previous = _st_pl_side_value_txtobj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( add_button_previous != add_button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != add_button_previous )
         {
            {
               uScript_Button component = add_button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
                  component.OnButtonEnter -= Instance_OnButtonEnter_0;
                  component.OnButtonExit -= Instance_OnButtonExit_0;
                  component.OnButtonDrag -= Instance_OnButtonDrag_0;
               }
            }
         }
         
         add_button_previous = add_button;
         
         //setup new listeners
         if ( null != add_button )
         {
            {
               uScript_Button component = add_button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = add_button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
                  component.OnButtonEnter += Instance_OnButtonEnter_0;
                  component.OnButtonExit += Instance_OnButtonExit_0;
                  component.OnButtonDrag += Instance_OnButtonDrag_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( minas_buton_previous != minas_buton || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != minas_buton_previous )
         {
            {
               uScript_Button component = minas_buton_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_11;
                  component.OnButtonDown -= Instance_OnButtonDown_11;
                  component.OnButtonUp -= Instance_OnButtonUp_11;
                  component.OnButtonEnter -= Instance_OnButtonEnter_11;
                  component.OnButtonExit -= Instance_OnButtonExit_11;
                  component.OnButtonDrag -= Instance_OnButtonDrag_11;
               }
            }
         }
         
         minas_buton_previous = minas_buton;
         
         //setup new listeners
         if ( null != minas_buton )
         {
            {
               uScript_Button component = minas_buton.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = minas_buton.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_11;
                  component.OnButtonDown += Instance_OnButtonDown_11;
                  component.OnButtonUp += Instance_OnButtonUp_11;
                  component.OnButtonEnter += Instance_OnButtonEnter_11;
                  component.OnButtonExit += Instance_OnButtonExit_11;
                  component.OnButtonDrag += Instance_OnButtonDrag_11;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( UP_add_button_previous != UP_add_button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != UP_add_button_previous )
         {
            {
               uScript_Button component = UP_add_button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_19;
                  component.OnButtonDown -= Instance_OnButtonDown_19;
                  component.OnButtonUp -= Instance_OnButtonUp_19;
                  component.OnButtonEnter -= Instance_OnButtonEnter_19;
                  component.OnButtonExit -= Instance_OnButtonExit_19;
                  component.OnButtonDrag -= Instance_OnButtonDrag_19;
               }
            }
         }
         
         UP_add_button_previous = UP_add_button;
         
         //setup new listeners
         if ( null != UP_add_button )
         {
            {
               uScript_Button component = UP_add_button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = UP_add_button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_19;
                  component.OnButtonDown += Instance_OnButtonDown_19;
                  component.OnButtonUp += Instance_OnButtonUp_19;
                  component.OnButtonEnter += Instance_OnButtonEnter_19;
                  component.OnButtonExit += Instance_OnButtonExit_19;
                  component.OnButtonDrag += Instance_OnButtonDrag_19;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( UP_minas_buton_previous != UP_minas_buton || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != UP_minas_buton_previous )
         {
            {
               uScript_Button component = UP_minas_buton_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_24;
                  component.OnButtonDown -= Instance_OnButtonDown_24;
                  component.OnButtonUp -= Instance_OnButtonUp_24;
                  component.OnButtonEnter -= Instance_OnButtonEnter_24;
                  component.OnButtonExit -= Instance_OnButtonExit_24;
                  component.OnButtonDrag -= Instance_OnButtonDrag_24;
               }
            }
         }
         
         UP_minas_buton_previous = UP_minas_buton;
         
         //setup new listeners
         if ( null != UP_minas_buton )
         {
            {
               uScript_Button component = UP_minas_buton.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = UP_minas_buton.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_24;
                  component.OnButtonDown += Instance_OnButtonDown_24;
                  component.OnButtonUp += Instance_OnButtonUp_24;
                  component.OnButtonEnter += Instance_OnButtonEnter_24;
                  component.OnButtonExit += Instance_OnButtonExit_24;
                  component.OnButtonDrag += Instance_OnButtonDrag_24;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _st_pl_UP_value_txtobj_previous != _st_pl_UP_value_txtobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _st_pl_UP_value_txtobj_previous = _st_pl_UP_value_txtobj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Reset_Button_previous != Reset_Button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Reset_Button_previous )
         {
            {
               uScript_Button component = Reset_Button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_37;
                  component.OnButtonDown -= Instance_OnButtonDown_37;
                  component.OnButtonUp -= Instance_OnButtonUp_37;
                  component.OnButtonEnter -= Instance_OnButtonEnter_37;
                  component.OnButtonExit -= Instance_OnButtonExit_37;
                  component.OnButtonDrag -= Instance_OnButtonDrag_37;
               }
            }
         }
         
         Reset_Button_previous = Reset_Button;
         
         //setup new listeners
         if ( null != Reset_Button )
         {
            {
               uScript_Button component = Reset_Button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Reset_Button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_37;
                  component.OnButtonDown += Instance_OnButtonDown_37;
                  component.OnButtonUp += Instance_OnButtonUp_37;
                  component.OnButtonEnter += Instance_OnButtonEnter_37;
                  component.OnButtonExit += Instance_OnButtonExit_37;
                  component.OnButtonDrag += Instance_OnButtonDrag_37;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48;
         
         //setup new listeners
      }
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _st_pl_side_value_txtobj_previous != _st_pl_side_value_txtobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _st_pl_side_value_txtobj_previous = _st_pl_side_value_txtobj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( add_button_previous != add_button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != add_button_previous )
         {
            {
               uScript_Button component = add_button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
                  component.OnButtonEnter -= Instance_OnButtonEnter_0;
                  component.OnButtonExit -= Instance_OnButtonExit_0;
                  component.OnButtonDrag -= Instance_OnButtonDrag_0;
               }
            }
         }
         
         add_button_previous = add_button;
         
         //setup new listeners
         if ( null != add_button )
         {
            {
               uScript_Button component = add_button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = add_button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
                  component.OnButtonEnter += Instance_OnButtonEnter_0;
                  component.OnButtonExit += Instance_OnButtonExit_0;
                  component.OnButtonDrag += Instance_OnButtonDrag_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( minas_buton_previous != minas_buton || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != minas_buton_previous )
         {
            {
               uScript_Button component = minas_buton_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_11;
                  component.OnButtonDown -= Instance_OnButtonDown_11;
                  component.OnButtonUp -= Instance_OnButtonUp_11;
                  component.OnButtonEnter -= Instance_OnButtonEnter_11;
                  component.OnButtonExit -= Instance_OnButtonExit_11;
                  component.OnButtonDrag -= Instance_OnButtonDrag_11;
               }
            }
         }
         
         minas_buton_previous = minas_buton;
         
         //setup new listeners
         if ( null != minas_buton )
         {
            {
               uScript_Button component = minas_buton.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = minas_buton.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_11;
                  component.OnButtonDown += Instance_OnButtonDown_11;
                  component.OnButtonUp += Instance_OnButtonUp_11;
                  component.OnButtonEnter += Instance_OnButtonEnter_11;
                  component.OnButtonExit += Instance_OnButtonExit_11;
                  component.OnButtonDrag += Instance_OnButtonDrag_11;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( UP_add_button_previous != UP_add_button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != UP_add_button_previous )
         {
            {
               uScript_Button component = UP_add_button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_19;
                  component.OnButtonDown -= Instance_OnButtonDown_19;
                  component.OnButtonUp -= Instance_OnButtonUp_19;
                  component.OnButtonEnter -= Instance_OnButtonEnter_19;
                  component.OnButtonExit -= Instance_OnButtonExit_19;
                  component.OnButtonDrag -= Instance_OnButtonDrag_19;
               }
            }
         }
         
         UP_add_button_previous = UP_add_button;
         
         //setup new listeners
         if ( null != UP_add_button )
         {
            {
               uScript_Button component = UP_add_button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = UP_add_button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_19;
                  component.OnButtonDown += Instance_OnButtonDown_19;
                  component.OnButtonUp += Instance_OnButtonUp_19;
                  component.OnButtonEnter += Instance_OnButtonEnter_19;
                  component.OnButtonExit += Instance_OnButtonExit_19;
                  component.OnButtonDrag += Instance_OnButtonDrag_19;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( UP_minas_buton_previous != UP_minas_buton || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != UP_minas_buton_previous )
         {
            {
               uScript_Button component = UP_minas_buton_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_24;
                  component.OnButtonDown -= Instance_OnButtonDown_24;
                  component.OnButtonUp -= Instance_OnButtonUp_24;
                  component.OnButtonEnter -= Instance_OnButtonEnter_24;
                  component.OnButtonExit -= Instance_OnButtonExit_24;
                  component.OnButtonDrag -= Instance_OnButtonDrag_24;
               }
            }
         }
         
         UP_minas_buton_previous = UP_minas_buton;
         
         //setup new listeners
         if ( null != UP_minas_buton )
         {
            {
               uScript_Button component = UP_minas_buton.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = UP_minas_buton.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_24;
                  component.OnButtonDown += Instance_OnButtonDown_24;
                  component.OnButtonUp += Instance_OnButtonUp_24;
                  component.OnButtonEnter += Instance_OnButtonEnter_24;
                  component.OnButtonExit += Instance_OnButtonExit_24;
                  component.OnButtonDrag += Instance_OnButtonDrag_24;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( _st_pl_UP_value_txtobj_previous != _st_pl_UP_value_txtobj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _st_pl_UP_value_txtobj_previous = _st_pl_UP_value_txtobj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Reset_Button_previous != Reset_Button || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Reset_Button_previous )
         {
            {
               uScript_Button component = Reset_Button_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_37;
                  component.OnButtonDown -= Instance_OnButtonDown_37;
                  component.OnButtonUp -= Instance_OnButtonUp_37;
                  component.OnButtonEnter -= Instance_OnButtonEnter_37;
                  component.OnButtonExit -= Instance_OnButtonExit_37;
                  component.OnButtonDrag -= Instance_OnButtonDrag_37;
               }
            }
         }
         
         Reset_Button_previous = Reset_Button;
         
         //setup new listeners
         if ( null != Reset_Button )
         {
            {
               uScript_Button component = Reset_Button.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Reset_Button.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_37;
                  component.OnButtonDown += Instance_OnButtonDown_37;
                  component.OnButtonUp += Instance_OnButtonUp_37;
                  component.OnButtonEnter += Instance_OnButtonEnter_37;
                  component.OnButtonExit += Instance_OnButtonExit_37;
                  component.OnButtonDrag += Instance_OnButtonDrag_37;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_2;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_3;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_9;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_12;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_29;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_30;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous != property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47_previous = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_Instance_47;
                  
                  //setup new listeners
               }
            }
         }
      }
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous != property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48 || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48_previous = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_Instance_48;
                  
                  //setup new listeners
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != add_button )
      {
         {
            uScript_Button component = add_button.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_0;
               component.OnButtonDown -= Instance_OnButtonDown_0;
               component.OnButtonUp -= Instance_OnButtonUp_0;
               component.OnButtonEnter -= Instance_OnButtonEnter_0;
               component.OnButtonExit -= Instance_OnButtonExit_0;
               component.OnButtonDrag -= Instance_OnButtonDrag_0;
            }
         }
      }
      if ( null != minas_buton )
      {
         {
            uScript_Button component = minas_buton.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_11;
               component.OnButtonDown -= Instance_OnButtonDown_11;
               component.OnButtonUp -= Instance_OnButtonUp_11;
               component.OnButtonEnter -= Instance_OnButtonEnter_11;
               component.OnButtonExit -= Instance_OnButtonExit_11;
               component.OnButtonDrag -= Instance_OnButtonDrag_11;
            }
         }
      }
      if ( null != UP_add_button )
      {
         {
            uScript_Button component = UP_add_button.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_19;
               component.OnButtonDown -= Instance_OnButtonDown_19;
               component.OnButtonUp -= Instance_OnButtonUp_19;
               component.OnButtonEnter -= Instance_OnButtonEnter_19;
               component.OnButtonExit -= Instance_OnButtonExit_19;
               component.OnButtonDrag -= Instance_OnButtonDrag_19;
            }
         }
      }
      if ( null != UP_minas_buton )
      {
         {
            uScript_Button component = UP_minas_buton.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_24;
               component.OnButtonDown -= Instance_OnButtonDown_24;
               component.OnButtonUp -= Instance_OnButtonUp_24;
               component.OnButtonEnter -= Instance_OnButtonEnter_24;
               component.OnButtonExit -= Instance_OnButtonExit_24;
               component.OnButtonDrag -= Instance_OnButtonDrag_24;
            }
         }
      }
      if ( null != Reset_Button )
      {
         {
            uScript_Button component = Reset_Button.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_37;
               component.OnButtonDown -= Instance_OnButtonDown_37;
               component.OnButtonUp -= Instance_OnButtonUp_37;
               component.OnButtonEnter -= Instance_OnButtonEnter_37;
               component.OnButtonExit -= Instance_OnButtonExit_37;
               component.OnButtonDrag -= Instance_OnButtonDrag_37;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetString_uScriptAct_SetString_1.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_4.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_8.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_13.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_17.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_21.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_26.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_27.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_32.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_34.SetParent(g);
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_39.SetParent(g);
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_41.SetParent(g);
      logic_uScriptAct_SavePreferences_uScriptAct_SavePreferences_45.SetParent(g);
      logic_uScriptAct_SavePreferences_uScriptAct_SavePreferences_46.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_49.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_50.SetParent(g);
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_111.SetParent(g);
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_113.SetParent(g);
      logic_uScript_GraphEvents_uScript_GraphEvents_122.SetParent(g);
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_123.SetParent(g);
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_128.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScript_GraphEvents_uScript_GraphEvents_122.uScriptEnable += uScript_GraphEvents_uScriptEnable_122;
      logic_uScript_GraphEvents_uScript_GraphEvents_122.uScriptDisable += uScript_GraphEvents_uScriptDisable_122;
      logic_uScript_GraphEvents_uScript_GraphEvents_122.uScriptDestroy += uScript_GraphEvents_uScriptDestroy_122;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
      logic_uScript_GraphEvents_uScript_GraphEvents_122.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_122.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_122.OnDestroy( );
      logic_uScript_GraphEvents_uScript_GraphEvents_122.uScriptEnable -= uScript_GraphEvents_uScriptEnable_122;
      logic_uScript_GraphEvents_uScript_GraphEvents_122.uScriptDisable -= uScript_GraphEvents_uScriptDisable_122;
      logic_uScript_GraphEvents_uScript_GraphEvents_122.uScriptDestroy -= uScript_GraphEvents_uScriptDestroy_122;
   }
   
   void Instance_OnButtonClick_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_0( );
   }
   
   void Instance_OnButtonDown_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_0( );
   }
   
   void Instance_OnButtonUp_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_0( );
   }
   
   void Instance_OnButtonEnter_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_0( );
   }
   
   void Instance_OnButtonExit_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_0( );
   }
   
   void Instance_OnButtonDrag_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_0( );
   }
   
   void Instance_OnButtonClick_11(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_11( );
   }
   
   void Instance_OnButtonDown_11(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_11( );
   }
   
   void Instance_OnButtonUp_11(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_11( );
   }
   
   void Instance_OnButtonEnter_11(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_11( );
   }
   
   void Instance_OnButtonExit_11(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_11( );
   }
   
   void Instance_OnButtonDrag_11(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_11( );
   }
   
   void Instance_OnButtonClick_19(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_19( );
   }
   
   void Instance_OnButtonDown_19(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_19( );
   }
   
   void Instance_OnButtonUp_19(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_19( );
   }
   
   void Instance_OnButtonEnter_19(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_19( );
   }
   
   void Instance_OnButtonExit_19(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_19( );
   }
   
   void Instance_OnButtonDrag_19(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_19( );
   }
   
   void Instance_OnButtonClick_24(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_24( );
   }
   
   void Instance_OnButtonDown_24(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_24( );
   }
   
   void Instance_OnButtonUp_24(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_24( );
   }
   
   void Instance_OnButtonEnter_24(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_24( );
   }
   
   void Instance_OnButtonExit_24(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_24( );
   }
   
   void Instance_OnButtonDrag_24(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_24( );
   }
   
   void Instance_OnButtonClick_37(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_37( );
   }
   
   void Instance_OnButtonDown_37(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_37( );
   }
   
   void Instance_OnButtonUp_37(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_37( );
   }
   
   void Instance_OnButtonEnter_37(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_37( );
   }
   
   void Instance_OnButtonExit_37(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_37( );
   }
   
   void Instance_OnButtonDrag_37(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_37( );
   }
   
   void uScript_GraphEvents_uScriptEnable_122(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptEnable_122( );
   }
   
   void uScript_GraphEvents_uScriptDisable_122(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDisable_122( );
   }
   
   void uScript_GraphEvents_uScriptDestroy_122(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDestroy_122( );
   }
   
   void Relay_OnButtonClick_0()
   {
   }
   
   void Relay_OnButtonDown_0()
   {
      Relay_In_8();
   }
   
   void Relay_OnButtonUp_0()
   {
   }
   
   void Relay_OnButtonEnter_0()
   {
   }
   
   void Relay_OnButtonExit_0()
   {
   }
   
   void Relay_OnButtonDrag_0()
   {
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptAct_SetString_Value_1 = local_5_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetString_uScriptAct_SetString_1.In(logic_uScriptAct_SetString_Value_1, logic_uScriptAct_SetString_ToUpperCase_1, logic_uScriptAct_SetString_ToLowerCase_1, logic_uScriptAct_SetString_TrimWhitespace_1, out logic_uScriptAct_SetString_Target_1);
      property_text_Detox_ScriptEditor_Parameter_text_6 = logic_uScriptAct_SetString_Target_1;
      property_text_Detox_ScriptEditor_Parameter_text_6_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_1.Out;
      
      if ( test_0 == true )
      {
         Relay_In_41();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_4 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_2_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_4.In(logic_uScriptAct_FloatToString_Target_4, logic_uScriptAct_FloatToString_StandardFormat_4, logic_uScriptAct_FloatToString_CustomFormat_4, logic_uScriptAct_FloatToString_CustomCulture_4, out logic_uScriptAct_FloatToString_Result_4);
      local_5_System_String = logic_uScriptAct_FloatToString_Result_4;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_1();
      }
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_8 = param_UP;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_8 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_8.In(logic_uScriptAct_AddFloat_v2_A_8, logic_uScriptAct_AddFloat_v2_B_8, out logic_uScriptAct_AddFloat_v2_FloatResult_8, out logic_uScriptAct_AddFloat_v2_IntResult_8);
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9 = logic_uScriptAct_AddFloat_v2_FloatResult_8;
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_9_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_8.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_OnButtonClick_11()
   {
   }
   
   void Relay_OnButtonDown_11()
   {
      Relay_In_32();
   }
   
   void Relay_OnButtonUp_11()
   {
   }
   
   void Relay_OnButtonEnter_11()
   {
   }
   
   void Relay_OnButtonExit_11()
   {
   }
   
   void Relay_OnButtonDrag_11()
   {
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_13 = local_14_System_Single;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_13 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_13.In(logic_uScriptAct_AddFloat_v2_A_13, logic_uScriptAct_AddFloat_v2_B_13, out logic_uScriptAct_AddFloat_v2_FloatResult_13, out logic_uScriptAct_AddFloat_v2_IntResult_13);
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12 = logic_uScriptAct_AddFloat_v2_FloatResult_13;
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_13.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_17()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_17 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_29_Get_Refresh( );
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_17.In(logic_uScriptAct_FloatToString_Target_17, logic_uScriptAct_FloatToString_StandardFormat_17, logic_uScriptAct_FloatToString_CustomFormat_17, logic_uScriptAct_FloatToString_CustomCulture_17, out logic_uScriptAct_FloatToString_Result_17);
      local_23_System_String = logic_uScriptAct_FloatToString_Result_17;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_17.Out;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_OnButtonClick_19()
   {
   }
   
   void Relay_OnButtonDown_19()
   {
      Relay_In_27();
   }
   
   void Relay_OnButtonUp_19()
   {
   }
   
   void Relay_OnButtonEnter_19()
   {
   }
   
   void Relay_OnButtonExit_19()
   {
   }
   
   void Relay_OnButtonDrag_19()
   {
   }
   
   void Relay_In_21()
   {
      {
         {
            logic_uScriptAct_SetString_Value_21 = local_23_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetString_uScriptAct_SetString_21.In(logic_uScriptAct_SetString_Value_21, logic_uScriptAct_SetString_ToUpperCase_21, logic_uScriptAct_SetString_ToLowerCase_21, logic_uScriptAct_SetString_TrimWhitespace_21, out logic_uScriptAct_SetString_Target_21);
      property_text_Detox_ScriptEditor_Parameter_text_25 = logic_uScriptAct_SetString_Target_21;
      property_text_Detox_ScriptEditor_Parameter_text_25_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_39();
      }
   }
   
   void Relay_OnButtonClick_24()
   {
   }
   
   void Relay_OnButtonDown_24()
   {
      Relay_In_34();
   }
   
   void Relay_OnButtonUp_24()
   {
   }
   
   void Relay_OnButtonEnter_24()
   {
   }
   
   void Relay_OnButtonExit_24()
   {
   }
   
   void Relay_OnButtonDrag_24()
   {
   }
   
   void Relay_In_26()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_26 = local_28_System_Single;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_26 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_26.In(logic_uScriptAct_AddFloat_v2_A_26, logic_uScriptAct_AddFloat_v2_B_26, out logic_uScriptAct_AddFloat_v2_FloatResult_26, out logic_uScriptAct_AddFloat_v2_IntResult_26);
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30 = logic_uScriptAct_AddFloat_v2_FloatResult_26;
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_30_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_26.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_In_27()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_27 = param_UP;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_27 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3_Get_Refresh( );
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_27.In(logic_uScriptAct_AddFloat_v2_A_27, logic_uScriptAct_AddFloat_v2_B_27, out logic_uScriptAct_AddFloat_v2_FloatResult_27, out logic_uScriptAct_AddFloat_v2_IntResult_27);
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3 = logic_uScriptAct_AddFloat_v2_FloatResult_27;
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_27.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
      }
   }
   
   void Relay_In_32()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_32 = param_UP;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_32.In(logic_uScriptAct_MultiplyFloat_v2_A_32, logic_uScriptAct_MultiplyFloat_v2_B_32, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_32, out logic_uScriptAct_MultiplyFloat_v2_IntResult_32);
      local_14_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_32;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_32.Out;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_In_34()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_34 = param_UP;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_34.In(logic_uScriptAct_MultiplyFloat_v2_A_34, logic_uScriptAct_MultiplyFloat_v2_B_34, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_34, out logic_uScriptAct_MultiplyFloat_v2_IntResult_34);
      local_28_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_34;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_34.Out;
      
      if ( test_0 == true )
      {
         Relay_In_26();
      }
   }
   
   void Relay_OnButtonClick_37()
   {
   }
   
   void Relay_OnButtonDown_37()
   {
      Relay_In_49();
   }
   
   void Relay_OnButtonUp_37()
   {
   }
   
   void Relay_OnButtonEnter_37()
   {
   }
   
   void Relay_OnButtonExit_37()
   {
   }
   
   void Relay_OnButtonDrag_37()
   {
   }
   
   void Relay_In_39()
   {
      {
         {
            logic_uScriptAct_SetPreferenceKeyFloat_KeyName_39 = local_38_System_String;
            
         }
         {
            logic_uScriptAct_SetPreferenceKeyFloat_Value_39 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_29_Get_Refresh( );
         }
      }
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_39.In(logic_uScriptAct_SetPreferenceKeyFloat_KeyName_39, logic_uScriptAct_SetPreferenceKeyFloat_Value_39);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_39.Out;
      
      if ( test_0 == true )
      {
         Relay_In_46();
      }
   }
   
   void Relay_In_41()
   {
      {
         {
            logic_uScriptAct_SetPreferenceKeyFloat_KeyName_41 = local_40_System_String;
            
         }
         {
            logic_uScriptAct_SetPreferenceKeyFloat_Value_41 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_2_Get_Refresh( );
         }
      }
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_41.In(logic_uScriptAct_SetPreferenceKeyFloat_KeyName_41, logic_uScriptAct_SetPreferenceKeyFloat_Value_41);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_41.Out;
      
      if ( test_0 == true )
      {
         Relay_In_45();
      }
   }
   
   void Relay_In_45()
   {
      {
      }
      logic_uScriptAct_SavePreferences_uScriptAct_SavePreferences_45.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_46()
   {
      {
      }
      logic_uScriptAct_SavePreferences_uScriptAct_SavePreferences_46.In();
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_49()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_49 = def_YvecValue;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_49.In(logic_uScriptAct_SetFloat_Value_49, out logic_uScriptAct_SetFloat_Target_49);
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47 = logic_uScriptAct_SetFloat_Target_49;
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_49.Out;
      
      if ( test_0 == true )
      {
         Relay_In_50();
      }
   }
   
   void Relay_In_50()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_50 = def_XvecValue;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_50.In(logic_uScriptAct_SetFloat_Value_50, out logic_uScriptAct_SetFloat_Target_50);
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48 = logic_uScriptAct_SetFloat_Target_50;
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_50.Out;
      
      if ( test_0 == true )
      {
         Relay_In_111();
      }
   }
   
   void Relay_In_111()
   {
      {
         {
            logic_uScriptAct_SetPreferenceKeyFloat_KeyName_111 = local_110_System_String;
            
         }
         {
            logic_uScriptAct_SetPreferenceKeyFloat_Value_111 = property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_47_Get_Refresh( );
         }
      }
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_111.In(logic_uScriptAct_SetPreferenceKeyFloat_KeyName_111, logic_uScriptAct_SetPreferenceKeyFloat_Value_111);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_111.Out;
      
      if ( test_0 == true )
      {
         Relay_In_113();
      }
   }
   
   void Relay_In_113()
   {
      {
         {
            logic_uScriptAct_SetPreferenceKeyFloat_KeyName_113 = local_114_System_String;
            
         }
         {
            logic_uScriptAct_SetPreferenceKeyFloat_Value_113 = property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_48_Get_Refresh( );
         }
      }
      logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_113.In(logic_uScriptAct_SetPreferenceKeyFloat_KeyName_113, logic_uScriptAct_SetPreferenceKeyFloat_Value_113);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetPreferenceKeyFloat_uScriptAct_SetPreferenceKeyFloat_113.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
         Relay_In_17();
      }
   }
   
   void Relay_uScriptEnable_122()
   {
      Relay_In_123();
   }
   
   void Relay_uScriptDisable_122()
   {
   }
   
   void Relay_uScriptDestroy_122()
   {
   }
   
   void Relay_In_123()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyFloat_KeyName_123 = local_126_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_123.In(logic_uScriptAct_GetPreferenceKeyFloat_KeyName_123, logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_123, out logic_uScriptAct_GetPreferenceKeyFloat_Value_123);
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3 = logic_uScriptAct_GetPreferenceKeyFloat_Value_123;
      property_st_pl_Up_value_Detox_ScriptEditor_Parameter_st_pl_Up_value_3_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_123.Out;
      
      if ( test_0 == true )
      {
         Relay_In_128();
      }
   }
   
   void Relay_In_128()
   {
      {
         {
            logic_uScriptAct_GetPreferenceKeyFloat_KeyName_128 = local_125_System_String;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_128.In(logic_uScriptAct_GetPreferenceKeyFloat_KeyName_128, logic_uScriptAct_GetPreferenceKeyFloat_DefaultValue_128, out logic_uScriptAct_GetPreferenceKeyFloat_Value_128);
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12 = logic_uScriptAct_GetPreferenceKeyFloat_Value_128;
      property_st_pl_Side_value_Detox_ScriptEditor_Parameter_st_pl_Side_value_12_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetPreferenceKeyFloat_uScriptAct_GetPreferenceKeyFloat_128.Out;
      
      if ( test_0 == true )
      {
         Relay_In_17();
         Relay_In_4();
      }
   }
   
}
