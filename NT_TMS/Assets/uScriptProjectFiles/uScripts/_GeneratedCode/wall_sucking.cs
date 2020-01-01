//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class wall_sucking : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Rigid_object = default(UnityEngine.GameObject);
   UnityEngine.GameObject Rigid_object_previous = null;
   public UnityEngine.GameObject sensor_col_left = default(UnityEngine.GameObject);
   UnityEngine.GameObject sensor_col_left_previous = null;
   public UnityEngine.GameObject sensor_col_right = default(UnityEngine.GameObject);
   UnityEngine.GameObject sensor_col_right_previous = null;
   public System.Single Wall_fixed_time = (float) 0.5;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_1 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_1;
   bool logic_uScriptAct_SetBool_Out_1 = true;
   bool logic_uScriptAct_SetBool_SetTrue_1 = true;
   bool logic_uScriptAct_SetBool_SetFalse_1 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_3 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_3 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_3 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_3 = true;
   bool logic_uScriptAct_Delay_AfterDelay_3 = true;
   bool logic_uScriptAct_Delay_Stopped_3 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_3 = false;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_5 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_5;
   bool logic_uScriptAct_SetBool_Out_5 = true;
   bool logic_uScriptAct_SetBool_SetTrue_5 = true;
   bool logic_uScriptAct_SetBool_SetFalse_5 = true;
   //pointer to script instanced logic node
   uScriptAct_GetRectTransformPosition2D logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16 = new uScriptAct_GetRectTransformPosition2D( );
   UnityEngine.GameObject logic_uScriptAct_GetRectTransformPosition2D_Target_16 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_GetRectTransformPosition2D_Position_16;
   bool logic_uScriptAct_GetRectTransformPosition2D_Out_16 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_7 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Rigid_object_previous != Rigid_object || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Rigid_object_previous = Rigid_object;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_col_left_previous != sensor_col_left || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_col_left_previous )
         {
            {
               uScript_Trigger2D component = sensor_col_left_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         sensor_col_left_previous = sensor_col_left;
         
         //setup new listeners
         if ( null != sensor_col_left )
         {
            {
               uScript_Trigger2D component = sensor_col_left.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_col_left.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_col_right_previous != sensor_col_right || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_col_right_previous )
         {
            {
               uScript_Trigger2D component = sensor_col_right_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_7;
                  component.OnExitTrigger -= Instance_OnExitTrigger_7;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_7;
               }
            }
         }
         
         sensor_col_right_previous = sensor_col_right;
         
         //setup new listeners
         if ( null != sensor_col_right )
         {
            {
               uScript_Trigger2D component = sensor_col_right.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_col_right.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_7;
                  component.OnExitTrigger += Instance_OnExitTrigger_7;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_7;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Rigid_object_previous != Rigid_object || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Rigid_object_previous = Rigid_object;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_col_left_previous != sensor_col_left || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_col_left_previous )
         {
            {
               uScript_Trigger2D component = sensor_col_left_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         sensor_col_left_previous = sensor_col_left;
         
         //setup new listeners
         if ( null != sensor_col_left )
         {
            {
               uScript_Trigger2D component = sensor_col_left.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_col_left.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_col_right_previous != sensor_col_right || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_col_right_previous )
         {
            {
               uScript_Trigger2D component = sensor_col_right_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_7;
                  component.OnExitTrigger -= Instance_OnExitTrigger_7;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_7;
               }
            }
         }
         
         sensor_col_right_previous = sensor_col_right;
         
         //setup new listeners
         if ( null != sensor_col_right )
         {
            {
               uScript_Trigger2D component = sensor_col_right.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_col_right.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_7;
                  component.OnExitTrigger += Instance_OnExitTrigger_7;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_7;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != sensor_col_left )
      {
         {
            uScript_Trigger2D component = sensor_col_left.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
      if ( null != sensor_col_right )
      {
         {
            uScript_Trigger2D component = sensor_col_right.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_7;
               component.OnExitTrigger -= Instance_OnExitTrigger_7;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_7;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetBool_uScriptAct_SetBool_1.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_3.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_5.SetParent(g);
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16.SetParent(g);
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
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_3)
      {
         Relay_DrivenDelay_3();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnEnterTrigger_0(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_0( );
   }
   
   void Instance_OnExitTrigger_0(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_0( );
   }
   
   void Instance_WhileInsideTrigger_0(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_0( );
   }
   
   void Instance_OnEnterTrigger_7(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_7 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_7( );
   }
   
   void Instance_OnExitTrigger_7(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_7 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_7( );
   }
   
   void Instance_WhileInsideTrigger_7(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_7 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_7( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      Relay_False_1();
   }
   
   void Relay_OnExitTrigger_0()
   {
   }
   
   void Relay_WhileInsideTrigger_0()
   {
   }
   
   void Relay_True_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_1.True(out logic_uScriptAct_SetBool_Target_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_1.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_False_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_1.False(out logic_uScriptAct_SetBool_Target_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_1.SetFalse;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_3 = Wall_fixed_time;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_3.In(logic_uScriptAct_Delay_Duration_3, logic_uScriptAct_Delay_SingleFrame_3);
      logic_uScriptAct_Delay_DrivenDelay_3 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_3.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_True_5();
      }
   }
   
   void Relay_Stop_3()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_3 = Wall_fixed_time;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_3.Stop(logic_uScriptAct_Delay_Duration_3, logic_uScriptAct_Delay_SingleFrame_3);
      logic_uScriptAct_Delay_DrivenDelay_3 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_3.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_True_5();
      }
   }
   
   void Relay_DrivenDelay_3( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_3 = Wall_fixed_time;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_3 = logic_uScriptAct_Delay_uScriptAct_Delay_3.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_3 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_3.AfterDelay == true )
         {
            Relay_True_5();
         }
      }
   }
   void Relay_True_5()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_5.True(out logic_uScriptAct_SetBool_Target_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_5()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_5.False(out logic_uScriptAct_SetBool_Target_5);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_7()
   {
      Relay_False_1();
      Relay_In_16();
   }
   
   void Relay_OnExitTrigger_7()
   {
   }
   
   void Relay_WhileInsideTrigger_7()
   {
   }
   
   void Relay_In_16()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRectTransformPosition2D_uScriptAct_GetRectTransformPosition2D_16.In(logic_uScriptAct_GetRectTransformPosition2D_Target_16, out logic_uScriptAct_GetRectTransformPosition2D_Position_16);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
