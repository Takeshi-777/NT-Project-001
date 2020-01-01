//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Jump_Judge_Col : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Col_1st = default(UnityEngine.GameObject);
   UnityEngine.GameObject Col_1st_previous = null;
   public UnityEngine.GameObject Col_2nd = default(UnityEngine.GameObject);
   UnityEngine.GameObject Col_2nd_previous = null;
   public UnityEngine.GameObject Col_3rd = default(UnityEngine.GameObject);
   UnityEngine.GameObject Col_3rd_previous = null;
   public System.Int32 Jump_Judge_state = (int) 0;
   public System.Single radius_1st = (float) 0;
   public System.Single radius_2nd = (float) 0;
   public System.Single radius_3rd = (float) 0;
   public System.Single time_01 = (float) 0.1;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScript_GraphEvents logic_uScript_GraphEvents_uScript_GraphEvents_0 = new uScript_GraphEvents( );
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_2 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_2 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_2;
   bool logic_uScriptAct_SetFloat_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_4 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_4 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_4;
   bool logic_uScriptAct_SetFloat_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_7 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_7 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_7;
   bool logic_uScriptAct_SetFloat_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_15 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_15 = (int) 3;
   System.Int32 logic_uScriptAct_SetInt_Target_15;
   bool logic_uScriptAct_SetInt_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_17 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_17 = (int) 2;
   System.Int32 logic_uScriptAct_SetInt_Target_17;
   bool logic_uScriptAct_SetInt_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_22 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_22 = (int) 1;
   System.Int32 logic_uScriptAct_SetInt_Target_22;
   bool logic_uScriptAct_SetInt_Out_22 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_25 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_25 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_25;
   bool logic_uScriptAct_SetInt_Out_25 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_26 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_26 = (int) 3;
   System.Int32 logic_uScriptAct_SetInt_Target_26;
   bool logic_uScriptAct_SetInt_Out_26 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_27 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_27 = (int) 2;
   System.Int32 logic_uScriptAct_SetInt_Target_27;
   bool logic_uScriptAct_SetInt_Out_27 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_55 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_55 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_55 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_55 = true;
   bool logic_uScriptAct_Delay_AfterDelay_55 = true;
   bool logic_uScriptAct_Delay_Stopped_55 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_55 = false;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_13 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_18 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_20 = default(UnityEngine.GameObject);
   
   //property nodes
   System.Single property_radius_Detox_ScriptEditor_Parameter_radius_1 = (float) 0;
   System.Single property_radius_Detox_ScriptEditor_Parameter_radius_5 = (float) 0;
   System.Single property_radius_Detox_ScriptEditor_Parameter_radius_6 = (float) 0;
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.Single property_radius_Detox_ScriptEditor_Parameter_radius_1_Get_Refresh( )
   {
      UnityEngine.CircleCollider2D component = null;
      if (Col_1st != null)
      {
         component = Col_1st.GetComponent<UnityEngine.CircleCollider2D>();
      }
      if ( null != component )
      {
         return component.radius;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_radius_Detox_ScriptEditor_Parameter_radius_1_Set_Refresh( )
   {
      UnityEngine.CircleCollider2D component = null;
      if (Col_1st != null)
      {
         component = Col_1st.GetComponent<UnityEngine.CircleCollider2D>();
      }
      if ( null != component )
      {
         component.radius = property_radius_Detox_ScriptEditor_Parameter_radius_1;
      }
   }
   
   System.Single property_radius_Detox_ScriptEditor_Parameter_radius_5_Get_Refresh( )
   {
      UnityEngine.CircleCollider2D component = null;
      if (Col_2nd != null)
      {
         component = Col_2nd.GetComponent<UnityEngine.CircleCollider2D>();
      }
      if ( null != component )
      {
         return component.radius;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_radius_Detox_ScriptEditor_Parameter_radius_5_Set_Refresh( )
   {
      UnityEngine.CircleCollider2D component = null;
      if (Col_2nd != null)
      {
         component = Col_2nd.GetComponent<UnityEngine.CircleCollider2D>();
      }
      if ( null != component )
      {
         component.radius = property_radius_Detox_ScriptEditor_Parameter_radius_5;
      }
   }
   
   System.Single property_radius_Detox_ScriptEditor_Parameter_radius_6_Get_Refresh( )
   {
      UnityEngine.CircleCollider2D component = null;
      if (Col_3rd != null)
      {
         component = Col_3rd.GetComponent<UnityEngine.CircleCollider2D>();
      }
      if ( null != component )
      {
         return component.radius;
      }
      else
      {
         return (float) 0;
      }
   }
   
   void property_radius_Detox_ScriptEditor_Parameter_radius_6_Set_Refresh( )
   {
      UnityEngine.CircleCollider2D component = null;
      if (Col_3rd != null)
      {
         component = Col_3rd.GetComponent<UnityEngine.CircleCollider2D>();
      }
      if ( null != component )
      {
         component.radius = property_radius_Detox_ScriptEditor_Parameter_radius_6;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_3rd_previous != Col_3rd || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_3rd_previous )
         {
            {
               uScript_Trigger2D component = Col_3rd_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_13;
                  component.OnExitTrigger -= Instance_OnExitTrigger_13;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_13;
               }
            }
         }
         
         Col_3rd_previous = Col_3rd;
         
         //setup new listeners
         if ( null != Col_3rd )
         {
            {
               uScript_Trigger2D component = Col_3rd.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_3rd.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_13;
                  component.OnExitTrigger += Instance_OnExitTrigger_13;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_13;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_2nd_previous != Col_2nd || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_2nd_previous )
         {
            {
               uScript_Trigger2D component = Col_2nd_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_18;
                  component.OnExitTrigger -= Instance_OnExitTrigger_18;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_18;
               }
            }
         }
         
         Col_2nd_previous = Col_2nd;
         
         //setup new listeners
         if ( null != Col_2nd )
         {
            {
               uScript_Trigger2D component = Col_2nd.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_2nd.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_18;
                  component.OnExitTrigger += Instance_OnExitTrigger_18;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_18;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_1st_previous != Col_1st || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_1st_previous )
         {
            {
               uScript_Trigger2D component = Col_1st_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_20;
                  component.OnExitTrigger -= Instance_OnExitTrigger_20;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_20;
               }
            }
         }
         
         Col_1st_previous = Col_1st;
         
         //setup new listeners
         if ( null != Col_1st )
         {
            {
               uScript_Trigger2D component = Col_1st.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_1st.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_20;
                  component.OnExitTrigger += Instance_OnExitTrigger_20;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_20;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_3rd_previous != Col_3rd || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_3rd_previous )
         {
            {
               uScript_Trigger2D component = Col_3rd_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_13;
                  component.OnExitTrigger -= Instance_OnExitTrigger_13;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_13;
               }
            }
         }
         
         Col_3rd_previous = Col_3rd;
         
         //setup new listeners
         if ( null != Col_3rd )
         {
            {
               uScript_Trigger2D component = Col_3rd.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_3rd.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_13;
                  component.OnExitTrigger += Instance_OnExitTrigger_13;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_13;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_2nd_previous != Col_2nd || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_2nd_previous )
         {
            {
               uScript_Trigger2D component = Col_2nd_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_18;
                  component.OnExitTrigger -= Instance_OnExitTrigger_18;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_18;
               }
            }
         }
         
         Col_2nd_previous = Col_2nd;
         
         //setup new listeners
         if ( null != Col_2nd )
         {
            {
               uScript_Trigger2D component = Col_2nd.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_2nd.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_18;
                  component.OnExitTrigger += Instance_OnExitTrigger_18;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_18;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Col_1st_previous != Col_1st || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Col_1st_previous )
         {
            {
               uScript_Trigger2D component = Col_1st_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_20;
                  component.OnExitTrigger -= Instance_OnExitTrigger_20;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_20;
               }
            }
         }
         
         Col_1st_previous = Col_1st;
         
         //setup new listeners
         if ( null != Col_1st )
         {
            {
               uScript_Trigger2D component = Col_1st.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Col_1st.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_20;
                  component.OnExitTrigger += Instance_OnExitTrigger_20;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_20;
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
      if ( null != Col_3rd )
      {
         {
            uScript_Trigger2D component = Col_3rd.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_13;
               component.OnExitTrigger -= Instance_OnExitTrigger_13;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_13;
            }
         }
      }
      if ( null != Col_2nd )
      {
         {
            uScript_Trigger2D component = Col_2nd.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_18;
               component.OnExitTrigger -= Instance_OnExitTrigger_18;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_18;
            }
         }
      }
      if ( null != Col_1st )
      {
         {
            uScript_Trigger2D component = Col_1st.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_20;
               component.OnExitTrigger -= Instance_OnExitTrigger_20;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_20;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScript_GraphEvents_uScript_GraphEvents_0.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_2.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_4.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_7.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_15.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_17.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_22.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_25.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_26.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_27.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_55.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScript_GraphEvents_uScript_GraphEvents_0.uScriptEnable += uScript_GraphEvents_uScriptEnable_0;
      logic_uScript_GraphEvents_uScript_GraphEvents_0.uScriptDisable += uScript_GraphEvents_uScriptDisable_0;
      logic_uScript_GraphEvents_uScript_GraphEvents_0.uScriptDestroy += uScript_GraphEvents_uScriptDestroy_0;
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
      logic_uScript_GraphEvents_uScript_GraphEvents_0.OnEnable( );
   }
   
   public void OnDisable()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_0.OnDisable( );
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_55)
      {
         Relay_DrivenDelay_55();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScript_GraphEvents_uScript_GraphEvents_0.OnDestroy( );
      logic_uScript_GraphEvents_uScript_GraphEvents_0.uScriptEnable -= uScript_GraphEvents_uScriptEnable_0;
      logic_uScript_GraphEvents_uScript_GraphEvents_0.uScriptDisable -= uScript_GraphEvents_uScriptDisable_0;
      logic_uScript_GraphEvents_uScript_GraphEvents_0.uScriptDestroy -= uScript_GraphEvents_uScriptDestroy_0;
   }
   
   void Instance_OnEnterTrigger_13(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_13 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_13( );
   }
   
   void Instance_OnExitTrigger_13(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_13 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_13( );
   }
   
   void Instance_WhileInsideTrigger_13(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_13 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_13( );
   }
   
   void Instance_OnEnterTrigger_18(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_18 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_18( );
   }
   
   void Instance_OnExitTrigger_18(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_18 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_18( );
   }
   
   void Instance_WhileInsideTrigger_18(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_18 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_18( );
   }
   
   void Instance_OnEnterTrigger_20(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_20 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_20( );
   }
   
   void Instance_OnExitTrigger_20(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_20 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_20( );
   }
   
   void Instance_WhileInsideTrigger_20(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_20 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_20( );
   }
   
   void uScript_GraphEvents_uScriptEnable_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptEnable_0( );
   }
   
   void uScript_GraphEvents_uScriptDisable_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDisable_0( );
   }
   
   void uScript_GraphEvents_uScriptDestroy_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_uScriptDestroy_0( );
   }
   
   void Relay_uScriptEnable_0()
   {
      Relay_In_2();
   }
   
   void Relay_uScriptDisable_0()
   {
   }
   
   void Relay_uScriptDestroy_0()
   {
   }
   
   void Relay_In_2()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_2 = radius_1st;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_2.In(logic_uScriptAct_SetFloat_Value_2, out logic_uScriptAct_SetFloat_Target_2);
      property_radius_Detox_ScriptEditor_Parameter_radius_1 = logic_uScriptAct_SetFloat_Target_2;
      property_radius_Detox_ScriptEditor_Parameter_radius_1_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_2.Out;
      
      if ( test_0 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_4 = radius_2nd;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_4.In(logic_uScriptAct_SetFloat_Value_4, out logic_uScriptAct_SetFloat_Target_4);
      property_radius_Detox_ScriptEditor_Parameter_radius_5 = logic_uScriptAct_SetFloat_Target_4;
      property_radius_Detox_ScriptEditor_Parameter_radius_5_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_7();
      }
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_7 = radius_3rd;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_7.In(logic_uScriptAct_SetFloat_Value_7, out logic_uScriptAct_SetFloat_Target_7);
      property_radius_Detox_ScriptEditor_Parameter_radius_6 = logic_uScriptAct_SetFloat_Target_7;
      property_radius_Detox_ScriptEditor_Parameter_radius_6_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_13()
   {
      Relay_In_15();
   }
   
   void Relay_OnExitTrigger_13()
   {
      Relay_In_25();
   }
   
   void Relay_WhileInsideTrigger_13()
   {
   }
   
   void Relay_In_15()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_15.In(logic_uScriptAct_SetInt_Value_15, out logic_uScriptAct_SetInt_Target_15);
      Jump_Judge_state = logic_uScriptAct_SetInt_Target_15;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_17()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_17.In(logic_uScriptAct_SetInt_Value_17, out logic_uScriptAct_SetInt_Target_17);
      Jump_Judge_state = logic_uScriptAct_SetInt_Target_17;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_18()
   {
      Relay_In_17();
   }
   
   void Relay_OnExitTrigger_18()
   {
      Relay_In_26();
   }
   
   void Relay_WhileInsideTrigger_18()
   {
   }
   
   void Relay_OnEnterTrigger_20()
   {
      Relay_In_22();
   }
   
   void Relay_OnExitTrigger_20()
   {
      Relay_In_27();
   }
   
   void Relay_WhileInsideTrigger_20()
   {
   }
   
   void Relay_In_22()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_22.In(logic_uScriptAct_SetInt_Value_22, out logic_uScriptAct_SetInt_Target_22);
      Jump_Judge_state = logic_uScriptAct_SetInt_Target_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetInt_uScriptAct_SetInt_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_55();
      }
   }
   
   void Relay_In_25()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_25.In(logic_uScriptAct_SetInt_Value_25, out logic_uScriptAct_SetInt_Target_25);
      Jump_Judge_state = logic_uScriptAct_SetInt_Target_25;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_26()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_26.In(logic_uScriptAct_SetInt_Value_26, out logic_uScriptAct_SetInt_Target_26);
      Jump_Judge_state = logic_uScriptAct_SetInt_Target_26;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_27()
   {
      {
         {
         }
         {
         }
      }
      logic_uScriptAct_SetInt_uScriptAct_SetInt_27.In(logic_uScriptAct_SetInt_Value_27, out logic_uScriptAct_SetInt_Target_27);
      Jump_Judge_state = logic_uScriptAct_SetInt_Target_27;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_55()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_55 = time_01;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_55.In(logic_uScriptAct_Delay_Duration_55, logic_uScriptAct_Delay_SingleFrame_55);
      logic_uScriptAct_Delay_DrivenDelay_55 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_55.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_27();
      }
   }
   
   void Relay_Stop_55()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_55 = time_01;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_55.Stop(logic_uScriptAct_Delay_Duration_55, logic_uScriptAct_Delay_SingleFrame_55);
      logic_uScriptAct_Delay_DrivenDelay_55 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_55.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_In_27();
      }
   }
   
   void Relay_DrivenDelay_55( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_55 = time_01;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_55 = logic_uScriptAct_Delay_uScriptAct_Delay_55.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_55 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_55.AfterDelay == true )
         {
            Relay_In_27();
         }
      }
   }
}
