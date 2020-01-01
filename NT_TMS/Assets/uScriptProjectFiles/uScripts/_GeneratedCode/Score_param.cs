//uScript Generated Code - Build 1.0.3117
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Score_param : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.Single local_12_System_Single = (float) 0;
   UnityEngine.GameObject local_3_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_3_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector2 local_4_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   System.Single local_6_System_Single = (float) 0;
   System.Single local_7_System_Single = (float) 100;
   public UnityEngine.GameObject Score_txt_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Score_txt_obj_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_1 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_1 = (float) 0;
   bool logic_uScriptCon_CompareFloat_GreaterThan_1 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_1 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_1 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRectTransformPosition2D logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2 = new uScriptAct_GetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_GetRectTransformPosition2D_Target_2 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_GetRectTransformPosition2D_Position_2;
   bool logic_uScriptAct_GetRectTransformPosition2D_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector2 logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_5 = new uScriptAct_GetComponentsVector2( );
   UnityEngine.Vector2 logic_uScriptAct_GetComponentsVector2_InputVector2_5 = new Vector2( );
   System.Single logic_uScriptAct_GetComponentsVector2_X_5;
   System.Single logic_uScriptAct_GetComponentsVector2_Y_5;
   bool logic_uScriptAct_GetComponentsVector2_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_8 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_8 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_8 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_8 = "";
   System.String logic_uScriptAct_FloatToString_CustomCulture_8 = "";
   System.String logic_uScriptAct_FloatToString_Result_8;
   bool logic_uScriptAct_FloatToString_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatFunctions logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11 = new uScriptAct_FloatFunctions( );
   System.Single logic_uScriptAct_FloatFunctions_input_11 = (float) 0;
   System.Single logic_uScriptAct_FloatFunctions_output_11;
   bool logic_uScriptAct_FloatFunctions_Out_11 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   System.String property_text_Detox_ScriptEditor_Parameter_text_9 = "";
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.String property_text_Detox_ScriptEditor_Parameter_text_9_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (Score_txt_obj != null)
      {
         component = Score_txt_obj.GetComponent<UnityEngine.UI.Text>();
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
   
   void property_text_Detox_ScriptEditor_Parameter_text_9_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (Score_txt_obj != null)
      {
         component = Score_txt_obj.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_9;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_3_UnityEngine_GameObject = GameObject.Find( "Guide_cam" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Score_txt_obj_previous != Score_txt_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Score_txt_obj_previous = Score_txt_obj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Score_txt_obj_previous != Score_txt_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Score_txt_obj_previous = Score_txt_obj;
         
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
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1.SetParent(g);
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2.SetParent(g);
      logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_5.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_8.SetParent(g);
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.SetParent(g);
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
   
   void Relay_OnUpdate_0()
   {
      Relay_In_2();
   }
   
   void Relay_OnLateUpdate_0()
   {
   }
   
   void Relay_OnFixedUpdate_0()
   {
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_1 = local_6_System_Single;
            
         }
         {
            logic_uScriptCon_CompareFloat_B_1 = local_7_System_Single;
            
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1.In(logic_uScriptCon_CompareFloat_A_1, logic_uScriptCon_CompareFloat_B_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_1.GreaterThan;
      
      if ( test_0 == true )
      {
         Relay_Floor_11();
      }
   }
   
   void Relay_In_2()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetRectTransformPosition2D_Target_2 = local_3_UnityEngine_GameObject;
            
         }
         {
         }
      }
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2.In(logic_uScriptAct_GetRectTransformPosition2D_Target_2, out logic_uScriptAct_GetRectTransformPosition2D_Position_2);
      local_4_UnityEngine_Vector2 = logic_uScriptAct_GetRectTransformPosition2D_Position_2;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector2_InputVector2_5 = local_4_UnityEngine_Vector2;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_5.In(logic_uScriptAct_GetComponentsVector2_InputVector2_5, out logic_uScriptAct_GetComponentsVector2_X_5, out logic_uScriptAct_GetComponentsVector2_Y_5);
      local_6_System_Single = logic_uScriptAct_GetComponentsVector2_Y_5;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector2_uScriptAct_GetComponentsVector2_5.Out;
      
      if ( test_0 == true )
      {
         Relay_In_1();
      }
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_8 = local_12_System_Single;
            
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
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_8.In(logic_uScriptAct_FloatToString_Target_8, logic_uScriptAct_FloatToString_StandardFormat_8, logic_uScriptAct_FloatToString_CustomFormat_8, logic_uScriptAct_FloatToString_CustomCulture_8, out logic_uScriptAct_FloatToString_Result_8);
      property_text_Detox_ScriptEditor_Parameter_text_9 = logic_uScriptAct_FloatToString_Result_8;
      property_text_Detox_ScriptEditor_Parameter_text_9_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Abs_11()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_11 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Abs(logic_uScriptAct_FloatFunctions_input_11, out logic_uScriptAct_FloatFunctions_output_11);
      local_12_System_Single = logic_uScriptAct_FloatFunctions_output_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Ceiling_11()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_11 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Ceiling(logic_uScriptAct_FloatFunctions_input_11, out logic_uScriptAct_FloatFunctions_output_11);
      local_12_System_Single = logic_uScriptAct_FloatFunctions_output_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Floor_11()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_11 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Floor(logic_uScriptAct_FloatFunctions_input_11, out logic_uScriptAct_FloatFunctions_output_11);
      local_12_System_Single = logic_uScriptAct_FloatFunctions_output_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Round_11()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_11 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Round(logic_uScriptAct_FloatFunctions_input_11, out logic_uScriptAct_FloatFunctions_output_11);
      local_12_System_Single = logic_uScriptAct_FloatFunctions_output_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Sign_11()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_11 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Sign(logic_uScriptAct_FloatFunctions_input_11, out logic_uScriptAct_FloatFunctions_output_11);
      local_12_System_Single = logic_uScriptAct_FloatFunctions_output_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
   void Relay_Sqrt_11()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_11 = local_6_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Sqrt(logic_uScriptAct_FloatFunctions_input_11, out logic_uScriptAct_FloatFunctions_output_11);
      local_12_System_Single = logic_uScriptAct_FloatFunctions_output_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_8();
      }
   }
   
}
