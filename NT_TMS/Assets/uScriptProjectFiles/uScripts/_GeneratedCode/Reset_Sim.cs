//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Reset_Sim : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Collide = default(UnityEngine.GameObject);
   UnityEngine.GameObject Collide_previous = null;
   public UnityEngine.GameObject rigidbody2d = default(UnityEngine.GameObject);
   UnityEngine.GameObject rigidbody2d_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_SetRigidbodyVelocity2D logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_4 = new uScriptAct_SetRigidbodyVelocity2D( );
   UnityEngine.GameObject[] logic_uScriptAct_SetRigidbodyVelocity2D_Target_4 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector2 logic_uScriptAct_SetRigidbodyVelocity2D_Velocity_4 = new Vector2( (float)0, (float)0 );
   bool logic_uScriptAct_SetRigidbodyVelocity2D_Out_4 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Collide_previous != Collide || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Collide_previous )
         {
            {
               uScript_Trigger2D component = Collide_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         Collide_previous = Collide;
         
         //setup new listeners
         if ( null != Collide )
         {
            {
               uScript_Trigger2D component = Collide.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Collide.AddComponent<uScript_Trigger2D>();
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
      if ( rigidbody2d_previous != rigidbody2d || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         rigidbody2d_previous = rigidbody2d;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Collide_previous != Collide || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Collide_previous )
         {
            {
               uScript_Trigger2D component = Collide_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         Collide_previous = Collide;
         
         //setup new listeners
         if ( null != Collide )
         {
            {
               uScript_Trigger2D component = Collide.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = Collide.AddComponent<uScript_Trigger2D>();
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
      if ( rigidbody2d_previous != rigidbody2d || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         rigidbody2d_previous = rigidbody2d;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Collide )
      {
         {
            uScript_Trigger2D component = Collide.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_4.SetParent(g);
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
   
   void Relay_OnEnterTrigger_0()
   {
      Relay_In_4();
   }
   
   void Relay_OnExitTrigger_0()
   {
   }
   
   void Relay_WhileInsideTrigger_0()
   {
   }
   
   void Relay_In_4()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( rigidbody2d_previous != rigidbody2d || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  rigidbody2d_previous = rigidbody2d;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_SetRigidbodyVelocity2D_Target_4.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_SetRigidbodyVelocity2D_Target_4, index + 1);
            }
            logic_uScriptAct_SetRigidbodyVelocity2D_Target_4[ index++ ] = rigidbody2d;
            
         }
         {
         }
      }
      logic_uScriptAct_SetRigidbodyVelocity2D_uScriptAct_SetRigidbodyVelocity2D_4.In(logic_uScriptAct_SetRigidbodyVelocity2D_Target_4, logic_uScriptAct_SetRigidbodyVelocity2D_Velocity_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
