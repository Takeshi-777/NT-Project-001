//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class ptcl_trigger : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject col = default(UnityEngine.GameObject);
   UnityEngine.GameObject col_previous = null;
   public UnityEngine.GameObject ptcl = default(UnityEngine.GameObject);
   UnityEngine.GameObject ptcl_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Particles logic_uScriptAct_Particles_uScriptAct_Particles_0 = new uScriptAct_Particles( );
   UnityEngine.GameObject[] logic_uScriptAct_Particles_Target_0 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Particles_ClearParticles_0 = (bool) false;
   bool logic_uScriptAct_Particles_Out_0 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_1 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( col_previous != col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != col_previous )
         {
            {
               uScript_Trigger2D component = col_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
                  component.OnExitTrigger -= Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
               }
            }
         }
         
         col_previous = col;
         
         //setup new listeners
         if ( null != col )
         {
            {
               uScript_Trigger2D component = col.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = col.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_previous != ptcl || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_previous = ptcl;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( col_previous != col || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != col_previous )
         {
            {
               uScript_Trigger2D component = col_previous.GetComponent<uScript_Trigger2D>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
                  component.OnExitTrigger -= Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
               }
            }
         }
         
         col_previous = col;
         
         //setup new listeners
         if ( null != col )
         {
            {
               uScript_Trigger2D component = col.GetComponent<uScript_Trigger2D>();
               if ( null == component )
               {
                  component = col.AddComponent<uScript_Trigger2D>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_1;
                  component.OnExitTrigger += Instance_OnExitTrigger_1;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_1;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( ptcl_previous != ptcl || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         ptcl_previous = ptcl;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != col )
      {
         {
            uScript_Trigger2D component = col.GetComponent<uScript_Trigger2D>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_1;
               component.OnExitTrigger -= Instance_OnExitTrigger_1;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Particles_uScriptAct_Particles_0.SetParent(g);
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
   
   void Instance_OnEnterTrigger_1(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_1( );
   }
   
   void Instance_OnExitTrigger_1(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_1( );
   }
   
   void Instance_WhileInsideTrigger_1(object o, uScript_Trigger2D.TriggerEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_GameObject_1 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_1( );
   }
   
   void Relay_StartEmitting_0()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( ptcl_previous != ptcl || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  ptcl_previous = ptcl;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Particles_Target_0.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Particles_Target_0, index + 1);
            }
            logic_uScriptAct_Particles_Target_0[ index++ ] = ptcl;
            
         }
         {
         }
      }
      logic_uScriptAct_Particles_uScriptAct_Particles_0.StartEmitting(logic_uScriptAct_Particles_Target_0, logic_uScriptAct_Particles_ClearParticles_0);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_StopEmitting_0()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( ptcl_previous != ptcl || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  ptcl_previous = ptcl;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Particles_Target_0.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Particles_Target_0, index + 1);
            }
            logic_uScriptAct_Particles_Target_0[ index++ ] = ptcl;
            
         }
         {
         }
      }
      logic_uScriptAct_Particles_uScriptAct_Particles_0.StopEmitting(logic_uScriptAct_Particles_Target_0, logic_uScriptAct_Particles_ClearParticles_0);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnEnterTrigger_1()
   {
      Relay_StartEmitting_0();
   }
   
   void Relay_OnExitTrigger_1()
   {
   }
   
   void Relay_WhileInsideTrigger_1()
   {
   }
   
}
