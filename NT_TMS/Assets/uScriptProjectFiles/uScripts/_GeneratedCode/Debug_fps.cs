//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Debug_fps : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject _000_Text_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject _000_Text_obj_previous = null;
   public System.Single _001_Update_time = (float) 0.5;
   public System.Boolean _002_SingleFrame = (bool) false;
   System.Boolean local_12_System_Boolean = (bool) false;
   System.Single local_2_System_Single = (float) 0;
   System.String local_4_System_String = "";
   System.Single local_7_System_Single = (float) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_OutputFramesPerSecond logic_uScriptAct_OutputFramesPerSecond_uScriptAct_OutputFramesPerSecond_1 = new uScriptAct_OutputFramesPerSecond( );
   System.Single logic_uScriptAct_OutputFramesPerSecond_FPS_1;
   bool logic_uScriptAct_OutputFramesPerSecond_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_3 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_3 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_3 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_3 = "";
   System.String logic_uScriptAct_FloatToString_CustomCulture_3 = "";
   System.String logic_uScriptAct_FloatToString_Result_3;
   bool logic_uScriptAct_FloatToString_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_5 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_5 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_5 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_5 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_5 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_5;
   bool logic_uScriptAct_SetString_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatFunctions logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6 = new uScriptAct_FloatFunctions( );
   System.Single logic_uScriptAct_FloatFunctions_input_6 = (float) 0;
   System.Single logic_uScriptAct_FloatFunctions_output_6;
   bool logic_uScriptAct_FloatFunctions_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_9 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_9 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_9 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_9 = true;
   bool logic_uScriptAct_Delay_AfterDelay_9 = true;
   bool logic_uScriptAct_Delay_Stopped_9 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_9 = false;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_10 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_10 = true;
   bool logic_uScriptCon_CompareBool_False_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_11 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_11;
   bool logic_uScriptAct_SetBool_Out_11 = true;
   bool logic_uScriptAct_SetBool_SetTrue_11 = true;
   bool logic_uScriptAct_SetBool_SetFalse_11 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_16 = default(UnityEngine.GameObject);
   
   //property nodes
   System.String property_text_Detox_ScriptEditor_Parameter_text_8 = "";
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.String property_text_Detox_ScriptEditor_Parameter_text_8_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_000_Text_obj != null)
      {
         component = _000_Text_obj.GetComponent<UnityEngine.UI.Text>();
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
   
   void property_text_Detox_ScriptEditor_Parameter_text_8_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (_000_Text_obj != null)
      {
         component = _000_Text_obj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_8;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _000_Text_obj_previous != _000_Text_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _000_Text_obj_previous = _000_Text_obj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( _000_Text_obj_previous != _000_Text_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         _000_Text_obj_previous = _000_Text_obj;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_0;
                  component.OnLateUpdate += Instance_OnLateUpdate_0;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_0;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_16 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_16 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_16 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_16.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_16.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_16;
                  component.uScriptLateStart += Instance_uScriptLateStart_16;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_0;
               component.OnLateUpdate -= Instance_OnLateUpdate_0;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_16 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_16.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_16;
               component.uScriptLateStart -= Instance_uScriptLateStart_16;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_OutputFramesPerSecond_uScriptAct_OutputFramesPerSecond_1.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_3.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_5.SetParent(g);
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_9.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_11.SetParent(g);
   }
   public void Awake()
   {
      
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
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_OutputFramesPerSecond_uScriptAct_OutputFramesPerSecond_1.Update( );
      if (true == logic_uScriptAct_Delay_DrivenDelay_9)
      {
         Relay_DrivenDelay_9();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_0( );
   }
   
   void Instance_OnLateUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_0( );
   }
   
   void Instance_OnFixedUpdate_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_0( );
   }
   
   void Instance_uScriptStart_16(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_16( );
   }
   
   void Instance_uScriptLateStart_16(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_16( );
   }
   
   void Relay_OnUpdate_0()
   {
   }
   
   void Relay_OnLateUpdate_0()
   {
   }
   
   void Relay_OnFixedUpdate_0()
   {
      Relay_In_10();
   }
   
   void Relay_In_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_OutputFramesPerSecond_uScriptAct_OutputFramesPerSecond_1.In(out logic_uScriptAct_OutputFramesPerSecond_FPS_1);
      local_2_System_Single = logic_uScriptAct_OutputFramesPerSecond_FPS_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_OutputFramesPerSecond_uScriptAct_OutputFramesPerSecond_1.Out;
      
      if ( test_0 == true )
      {
         Relay_Floor_6();
      }
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_3 = local_7_System_Single;
            
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
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_3.In(logic_uScriptAct_FloatToString_Target_3, logic_uScriptAct_FloatToString_StandardFormat_3, logic_uScriptAct_FloatToString_CustomFormat_3, logic_uScriptAct_FloatToString_CustomCulture_3, out logic_uScriptAct_FloatToString_Result_3);
      local_4_System_String = logic_uScriptAct_FloatToString_Result_3;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_3.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_SetString_Value_5 = local_4_System_String;
            
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
      logic_uScriptAct_SetString_uScriptAct_SetString_5.In(logic_uScriptAct_SetString_Value_5, logic_uScriptAct_SetString_ToUpperCase_5, logic_uScriptAct_SetString_ToLowerCase_5, logic_uScriptAct_SetString_TrimWhitespace_5, out logic_uScriptAct_SetString_Target_5);
      property_text_Detox_ScriptEditor_Parameter_text_8 = logic_uScriptAct_SetString_Target_5;
      property_text_Detox_ScriptEditor_Parameter_text_8_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Abs_6()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_6 = local_2_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Abs(logic_uScriptAct_FloatFunctions_input_6, out logic_uScriptAct_FloatFunctions_output_6);
      local_7_System_Single = logic_uScriptAct_FloatFunctions_output_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_Ceiling_6()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_6 = local_2_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Ceiling(logic_uScriptAct_FloatFunctions_input_6, out logic_uScriptAct_FloatFunctions_output_6);
      local_7_System_Single = logic_uScriptAct_FloatFunctions_output_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_Floor_6()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_6 = local_2_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Floor(logic_uScriptAct_FloatFunctions_input_6, out logic_uScriptAct_FloatFunctions_output_6);
      local_7_System_Single = logic_uScriptAct_FloatFunctions_output_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_Round_6()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_6 = local_2_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Round(logic_uScriptAct_FloatFunctions_input_6, out logic_uScriptAct_FloatFunctions_output_6);
      local_7_System_Single = logic_uScriptAct_FloatFunctions_output_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_Sign_6()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_6 = local_2_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Sign(logic_uScriptAct_FloatFunctions_input_6, out logic_uScriptAct_FloatFunctions_output_6);
      local_7_System_Single = logic_uScriptAct_FloatFunctions_output_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_Sqrt_6()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_6 = local_2_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Sqrt(logic_uScriptAct_FloatFunctions_input_6, out logic_uScriptAct_FloatFunctions_output_6);
      local_7_System_Single = logic_uScriptAct_FloatFunctions_output_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_6.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_In_9()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_9 = _001_Update_time;
            
         }
         {
            logic_uScriptAct_Delay_SingleFrame_9 = _002_SingleFrame;
            
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_9.In(logic_uScriptAct_Delay_Duration_9, logic_uScriptAct_Delay_SingleFrame_9);
      logic_uScriptAct_Delay_DrivenDelay_9 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_9.Immediate;
      bool test_1 = logic_uScriptAct_Delay_uScriptAct_Delay_9.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_False_11();
      }
      if ( test_1 == true )
      {
         Relay_True_11();
      }
   }
   
   void Relay_Stop_9()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_9 = _001_Update_time;
            
         }
         {
            logic_uScriptAct_Delay_SingleFrame_9 = _002_SingleFrame;
            
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_9.Stop(logic_uScriptAct_Delay_Duration_9, logic_uScriptAct_Delay_SingleFrame_9);
      logic_uScriptAct_Delay_DrivenDelay_9 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_9.Immediate;
      bool test_1 = logic_uScriptAct_Delay_uScriptAct_Delay_9.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_False_11();
      }
      if ( test_1 == true )
      {
         Relay_True_11();
      }
   }
   
   void Relay_DrivenDelay_9( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_9 = _001_Update_time;
            
         }
         {
            logic_uScriptAct_Delay_SingleFrame_9 = _002_SingleFrame;
            
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_9 = logic_uScriptAct_Delay_uScriptAct_Delay_9.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_9 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_9.Immediate == true )
         {
            Relay_False_11();
         }
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_9.AfterDelay == true )
         {
            Relay_True_11();
         }
      }
   }
   void Relay_In_10()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_10 = local_12_System_Boolean;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.In(logic_uScriptCon_CompareBool_Bool_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_10.True;
      
      if ( test_0 == true )
      {
         Relay_In_9();
         Relay_In_1();
      }
   }
   
   void Relay_True_11()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_11.True(out logic_uScriptAct_SetBool_Target_11);
      local_12_System_Boolean = logic_uScriptAct_SetBool_Target_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_11()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_11.False(out logic_uScriptAct_SetBool_Target_11);
      local_12_System_Boolean = logic_uScriptAct_SetBool_Target_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_uScriptStart_16()
   {
      Relay_True_11();
   }
   
   void Relay_uScriptLateStart_16()
   {
   }
   
}
