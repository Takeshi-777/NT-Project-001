//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Player_State : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Big_col = default(UnityEngine.GameObject);
   UnityEngine.GameObject Big_col_previous = null;
   public UnityEngine.GameObject Floor_Colider = default(UnityEngine.GameObject);
   UnityEngine.GameObject Floor_Colider_previous = null;
   public System.Boolean Jump_Vector = (bool) false;
   public System.Boolean Jumpable = (bool) false;
   public UnityEngine.GameObject sensor_left_collider = default(UnityEngine.GameObject);
   UnityEngine.GameObject sensor_left_collider_previous = null;
   public UnityEngine.GameObject sensor_Right_collider = default(UnityEngine.GameObject);
   UnityEngine.GameObject sensor_Right_collider_previous = null;
   public System.Boolean touch_floor = (bool) false;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_1 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_1;
   bool logic_uScriptAct_SetBool_Out_1 = true;
   bool logic_uScriptAct_SetBool_SetTrue_1 = true;
   bool logic_uScriptAct_SetBool_SetFalse_1 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_6 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_6;
   bool logic_uScriptAct_SetBool_Out_6 = true;
   bool logic_uScriptAct_SetBool_SetTrue_6 = true;
   bool logic_uScriptAct_SetBool_SetFalse_6 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_8 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_8 = true;
   bool logic_uScriptCon_CompareBool_False_8 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_9 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_9;
   bool logic_uScriptAct_SetBool_Out_9 = true;
   bool logic_uScriptAct_SetBool_SetTrue_9 = true;
   bool logic_uScriptAct_SetBool_SetFalse_9 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_15 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_15;
   bool logic_uScriptAct_SetBool_Out_15 = true;
   bool logic_uScriptAct_SetBool_SetTrue_15 = true;
   bool logic_uScriptAct_SetBool_SetFalse_15 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_3 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_4 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_10 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_14 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_left_collider_previous != sensor_left_collider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_left_collider_previous )
         {
            {
               uScript_Trigger2D component = sensor_left_collider_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_3;
                  component.OnExitTrigger -= Instance_OnExitTrigger_3;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_3;
               }
            }
         }
         
         sensor_left_collider_previous = sensor_left_collider;
         
         //setup new listeners
         if ( null != sensor_left_collider )
         {
            {
               uScript_Trigger2D component = sensor_left_collider.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_left_collider.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_3;
                  component.OnExitTrigger += Instance_OnExitTrigger_3;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_3;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Floor_Colider_previous != Floor_Colider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Floor_Colider_previous )
         {
            {
               uScript_Trigger2D component = Floor_Colider_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_4;
                  component.OnExitTrigger -= Instance_OnExitTrigger_4;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_4;
               }
            }
         }
         
         Floor_Colider_previous = Floor_Colider;
         
         //setup new listeners
         if ( null != Floor_Colider )
         {
            {
               uScript_Trigger2D component = Floor_Colider.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Floor_Colider.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_4;
                  component.OnExitTrigger += Instance_OnExitTrigger_4;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_4;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Big_col_previous != Big_col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Big_col_previous )
         {
            {
               uScript_Trigger2D component = Big_col_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_10;
                  component.OnExitTrigger -= Instance_OnExitTrigger_10;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_10;
               }
            }
         }
         
         Big_col_previous = Big_col;
         
         //setup new listeners
         if ( null != Big_col )
         {
            {
               uScript_Trigger2D component = Big_col.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Big_col.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_10;
                  component.OnExitTrigger += Instance_OnExitTrigger_10;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_10;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_Right_collider_previous != sensor_Right_collider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_Right_collider_previous )
         {
            {
               uScript_Trigger2D component = sensor_Right_collider_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_14;
                  component.OnExitTrigger -= Instance_OnExitTrigger_14;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_14;
               }
            }
         }
         
         sensor_Right_collider_previous = sensor_Right_collider;
         
         //setup new listeners
         if ( null != sensor_Right_collider )
         {
            {
               uScript_Trigger2D component = sensor_Right_collider.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_Right_collider.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_14;
                  component.OnExitTrigger += Instance_OnExitTrigger_14;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_14;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_left_collider_previous != sensor_left_collider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_left_collider_previous )
         {
            {
               uScript_Trigger2D component = sensor_left_collider_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_3;
                  component.OnExitTrigger -= Instance_OnExitTrigger_3;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_3;
               }
            }
         }
         
         sensor_left_collider_previous = sensor_left_collider;
         
         //setup new listeners
         if ( null != sensor_left_collider )
         {
            {
               uScript_Trigger2D component = sensor_left_collider.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_left_collider.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_3;
                  component.OnExitTrigger += Instance_OnExitTrigger_3;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_3;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Floor_Colider_previous != Floor_Colider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Floor_Colider_previous )
         {
            {
               uScript_Trigger2D component = Floor_Colider_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_4;
                  component.OnExitTrigger -= Instance_OnExitTrigger_4;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_4;
               }
            }
         }
         
         Floor_Colider_previous = Floor_Colider;
         
         //setup new listeners
         if ( null != Floor_Colider )
         {
            {
               uScript_Trigger2D component = Floor_Colider.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Floor_Colider.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_4;
                  component.OnExitTrigger += Instance_OnExitTrigger_4;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_4;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Big_col_previous != Big_col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Big_col_previous )
         {
            {
               uScript_Trigger2D component = Big_col_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_10;
                  component.OnExitTrigger -= Instance_OnExitTrigger_10;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_10;
               }
            }
         }
         
         Big_col_previous = Big_col;
         
         //setup new listeners
         if ( null != Big_col )
         {
            {
               uScript_Trigger2D component = Big_col.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Big_col.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_10;
                  component.OnExitTrigger += Instance_OnExitTrigger_10;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_10;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( sensor_Right_collider_previous != sensor_Right_collider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != sensor_Right_collider_previous )
         {
            {
               uScript_Trigger2D component = sensor_Right_collider_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_14;
                  component.OnExitTrigger -= Instance_OnExitTrigger_14;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_14;
               }
            }
         }
         
         sensor_Right_collider_previous = sensor_Right_collider;
         
         //setup new listeners
         if ( null != sensor_Right_collider )
         {
            {
               uScript_Trigger2D component = sensor_Right_collider.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = sensor_Right_collider.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_14;
                  component.OnExitTrigger += Instance_OnExitTrigger_14;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_14;
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
      if ( null != sensor_left_collider )
      {
         {
            uScript_Trigger2D component = sensor_left_collider.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_3;
               component.OnExitTrigger -= Instance_OnExitTrigger_3;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_3;
            }
         }
      }
      if ( null != Floor_Colider )
      {
         {
            uScript_Trigger2D component = Floor_Colider.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_4;
               component.OnExitTrigger -= Instance_OnExitTrigger_4;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_4;
            }
         }
      }
      if ( null != Big_col )
      {
         {
            uScript_Trigger2D component = Big_col.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_10;
               component.OnExitTrigger -= Instance_OnExitTrigger_10;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_10;
            }
         }
      }
      if ( null != sensor_Right_collider )
      {
         {
            uScript_Trigger2D component = sensor_Right_collider.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_14;
               component.OnExitTrigger -= Instance_OnExitTrigger_14;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_14;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetBool_uScriptAct_SetBool_1.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_6.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_9.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_15.SetParent(g);
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
   
   void Instance_OnEnterTrigger_3(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_3 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_3( );
   }
   
   void Instance_OnExitTrigger_3(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_3 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_3( );
   }
   
   void Instance_WhileInsideTrigger_3(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_3 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_3( );
   }
   
   void Instance_OnEnterTrigger_4(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_4 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_4( );
   }
   
   void Instance_OnExitTrigger_4(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_4 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_4( );
   }
   
   void Instance_WhileInsideTrigger_4(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_4 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_4( );
   }
   
   void Instance_OnEnterTrigger_10(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_10 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_10( );
   }
   
   void Instance_OnExitTrigger_10(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_10 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_10( );
   }
   
   void Instance_WhileInsideTrigger_10(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_10 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_10( );
   }
   
   void Instance_OnEnterTrigger_14(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_14 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_14( );
   }
   
   void Instance_OnExitTrigger_14(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_14 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_14( );
   }
   
   void Instance_WhileInsideTrigger_14(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_14 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_14( );
   }
   
   void Relay_True_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_1.True(out logic_uScriptAct_SetBool_Target_1);
      Jump_Vector = logic_uScriptAct_SetBool_Target_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_1.False(out logic_uScriptAct_SetBool_Target_1);
      Jump_Vector = logic_uScriptAct_SetBool_Target_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_3()
   {
      Relay_True_1();
   }
   
   void Relay_OnExitTrigger_3()
   {
   }
   
   void Relay_WhileInsideTrigger_3()
   {
   }
   
   void Relay_OnEnterTrigger_4()
   {
      Relay_True_6();
   }
   
   void Relay_OnExitTrigger_4()
   {
      Relay_False_6();
   }
   
   void Relay_WhileInsideTrigger_4()
   {
      Relay_In_8();
   }
   
   void Relay_True_6()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_6.True(out logic_uScriptAct_SetBool_Target_6);
      touch_floor = logic_uScriptAct_SetBool_Target_6;
      Jumpable = logic_uScriptAct_SetBool_Target_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_6()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_6.False(out logic_uScriptAct_SetBool_Target_6);
      touch_floor = logic_uScriptAct_SetBool_Target_6;
      Jumpable = logic_uScriptAct_SetBool_Target_6;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_8()
   {
      {
         {
            logic_uScriptCon_CompareBool_Bool_8 = touch_floor;
            
         }
      }
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8.In(logic_uScriptCon_CompareBool_Bool_8);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_8.False;
      
      if ( test_0 == true )
      {
         Relay_True_6();
      }
   }
   
   void Relay_True_9()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_9.True(out logic_uScriptAct_SetBool_Target_9);
      Jumpable = logic_uScriptAct_SetBool_Target_9;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_9()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_9.False(out logic_uScriptAct_SetBool_Target_9);
      Jumpable = logic_uScriptAct_SetBool_Target_9;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_10()
   {
      Relay_True_9();
   }
   
   void Relay_OnExitTrigger_10()
   {
      Relay_False_9();
   }
   
   void Relay_WhileInsideTrigger_10()
   {
      Relay_True_9();
   }
   
   void Relay_OnEnterTrigger_14()
   {
      Relay_False_15();
   }
   
   void Relay_OnExitTrigger_14()
   {
   }
   
   void Relay_WhileInsideTrigger_14()
   {
   }
   
   void Relay_True_15()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_15.True(out logic_uScriptAct_SetBool_Target_15);
      Jump_Vector = logic_uScriptAct_SetBool_Target_15;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_False_15()
   {
      {
         {
         }
      }
      logic_uScriptAct_SetBool_uScriptAct_SetBool_15.False(out logic_uScriptAct_SetBool_Target_15);
      Jump_Vector = logic_uScriptAct_SetBool_Target_15;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
