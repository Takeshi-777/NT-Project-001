//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class debug_velocity : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Single DB_Maugnitude = (float) 0;
   public UnityEngine.Vector2 DB_Velocity = new Vector2( (float)0, (float)0 );
   public UnityEngine.GameObject rigidbody = default(UnityEngine.GameObject);
   UnityEngine.GameObject rigidbody_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetRigidbodyVelocity2D logic_uScriptAct_GetRigidbodyVelocity2D_uScriptAct_GetRigidbodyVelocity2D_1 = new uScriptAct_GetRigidbodyVelocity2D( );
   UnityEngine.GameObject logic_uScriptAct_GetRigidbodyVelocity2D_Target_1 = default(UnityEngine.GameObject);
   UnityEngine.Vector2 logic_uScriptAct_GetRigidbodyVelocity2D_Velocity_1;
   System.Single logic_uScriptAct_GetRigidbodyVelocity2D_AngularVelocity_1;
   System.Single logic_uScriptAct_GetRigidbodyVelocity2D_Magnitude_1;
   bool logic_uScriptAct_GetRigidbodyVelocity2D_Out_1 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( rigidbody_previous != rigidbody || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         rigidbody_previous = rigidbody;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( rigidbody_previous != rigidbody || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         rigidbody_previous = rigidbody;
         
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
      
      logic_uScriptAct_GetRigidbodyVelocity2D_uScriptAct_GetRigidbodyVelocity2D_1.SetParent(g);
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
      Relay_In_1();
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
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( rigidbody_previous != rigidbody || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  rigidbody_previous = rigidbody;
                  
                  //setup new listeners
               }
            }
            logic_uScriptAct_GetRigidbodyVelocity2D_Target_1 = rigidbody;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetRigidbodyVelocity2D_uScriptAct_GetRigidbodyVelocity2D_1.In(logic_uScriptAct_GetRigidbodyVelocity2D_Target_1, out logic_uScriptAct_GetRigidbodyVelocity2D_Velocity_1, out logic_uScriptAct_GetRigidbodyVelocity2D_AngularVelocity_1, out logic_uScriptAct_GetRigidbodyVelocity2D_Magnitude_1);
      DB_Velocity = logic_uScriptAct_GetRigidbodyVelocity2D_Velocity_1;
      DB_Maugnitude = logic_uScriptAct_GetRigidbodyVelocity2D_Magnitude_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
