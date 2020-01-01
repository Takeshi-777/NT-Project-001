//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Game_Judgment : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject Clear_colider = default(UnityEngine.GameObject);
   UnityEngine.GameObject Clear_colider_previous = null;
   [Multiline(3)]
   public System.String Clear_string = "goal";
   public UnityEngine.GameObject Dead_colider = default(UnityEngine.GameObject);
   UnityEngine.GameObject Dead_colider_previous = null;
   [Multiline(3)]
   public System.String Dead_string = "dead";
   System.Boolean local_12_System_Boolean = (bool) true;
   System.String local_13_System_String = "Clear";
   System.String local_15_System_String = "dead";
   System.String local_5_System_String = "";
   System.String local_7_System_String = "";
   public UnityEngine.GameObject prd_animater = default(UnityEngine.GameObject);
   UnityEngine.GameObject prd_animater_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_4 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_4 = "";
   System.String logic_uScriptCon_CompareString_B_4 = "";
   bool logic_uScriptCon_CompareString_Same_4 = true;
   bool logic_uScriptCon_CompareString_Different_4 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareString logic_uScriptCon_CompareString_uScriptCon_CompareString_6 = new uScriptCon_CompareString( );
   System.String logic_uScriptCon_CompareString_A_6 = "";
   System.String logic_uScriptCon_CompareString_B_6 = "";
   bool logic_uScriptCon_CompareString_Same_6 = true;
   bool logic_uScriptCon_CompareString_Different_6 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_10 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_10 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_10 = "";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_10 = (bool) false;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_AnimatorSetParameterBool logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_16 = new uScriptAct_AnimatorSetParameterBool( );
   UnityEngine.GameObject[] logic_uScriptAct_AnimatorSetParameterBool_Target_16 = new UnityEngine.GameObject[] {};
   System.String logic_uScriptAct_AnimatorSetParameterBool_Name_16 = "";
   System.Boolean logic_uScriptAct_AnimatorSetParameterBool_Value_16 = (bool) true;
   bool logic_uScriptAct_AnimatorSetParameterBool_Out_16 = true;
   
   //event nodes
   System.String event_UnityEngine_GameObject_Signal_2 = "";
   System.String event_UnityEngine_GameObject_Signal_3 = "";
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Dead_colider_previous != Dead_colider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Dead_colider_previous )
         {
            {
               uScript_ReceiveSignal component = Dead_colider_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_3;
               }
            }
         }
         
         Dead_colider_previous = Dead_colider;
         
         //setup new listeners
         if ( null != Dead_colider )
         {
            {
               uScript_ReceiveSignal component = Dead_colider.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = Dead_colider.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_3;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Clear_colider_previous != Clear_colider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Clear_colider_previous )
         {
            {
               uScript_ReceiveSignal component = Clear_colider_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_2;
               }
            }
         }
         
         Clear_colider_previous = Clear_colider;
         
         //setup new listeners
         if ( null != Clear_colider )
         {
            {
               uScript_ReceiveSignal component = Clear_colider.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = Clear_colider.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_2;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( prd_animater_previous != prd_animater || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         prd_animater_previous = prd_animater;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( Dead_colider_previous != Dead_colider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Dead_colider_previous )
         {
            {
               uScript_ReceiveSignal component = Dead_colider_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_3;
               }
            }
         }
         
         Dead_colider_previous = Dead_colider;
         
         //setup new listeners
         if ( null != Dead_colider )
         {
            {
               uScript_ReceiveSignal component = Dead_colider.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = Dead_colider.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_3;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Clear_colider_previous != Clear_colider || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Clear_colider_previous )
         {
            {
               uScript_ReceiveSignal component = Clear_colider_previous.GetComponent<uScript_ReceiveSignal>();
               if ( null != component )
               {
                  component.OnReceiveSignal -= Instance_OnReceiveSignal_2;
               }
            }
         }
         
         Clear_colider_previous = Clear_colider;
         
         //setup new listeners
         if ( null != Clear_colider )
         {
            {
               uScript_ReceiveSignal component = Clear_colider.GetComponent<uScript_ReceiveSignal>();
               if ( null == component )
               {
                  component = Clear_colider.AddComponent<uScript_ReceiveSignal>();
               }
               if ( null != component )
               {
                  component.OnReceiveSignal += Instance_OnReceiveSignal_2;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( prd_animater_previous != prd_animater || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         prd_animater_previous = prd_animater;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Dead_colider )
      {
         {
            uScript_ReceiveSignal component = Dead_colider.GetComponent<uScript_ReceiveSignal>();
            if ( null != component )
            {
               component.OnReceiveSignal -= Instance_OnReceiveSignal_3;
            }
         }
      }
      if ( null != Clear_colider )
      {
         {
            uScript_ReceiveSignal component = Clear_colider.GetComponent<uScript_ReceiveSignal>();
            if ( null != component )
            {
               component.OnReceiveSignal -= Instance_OnReceiveSignal_2;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareString_uScriptCon_CompareString_4.SetParent(g);
      logic_uScriptCon_CompareString_uScriptCon_CompareString_6.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_10.SetParent(g);
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_16.SetParent(g);
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
   
   void Instance_OnReceiveSignal_2(object o, uScript_ReceiveSignal.ReceiveSignalEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Signal_2 = e.Signal;
      //relay event to nodes
      Relay_OnReceiveSignal_2( );
   }
   
   void Instance_OnReceiveSignal_3(object o, uScript_ReceiveSignal.ReceiveSignalEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Signal_3 = e.Signal;
      //relay event to nodes
      Relay_OnReceiveSignal_3( );
   }
   
   void Relay_OnReceiveSignal_2()
   {
      local_5_System_String = event_UnityEngine_GameObject_Signal_2;
      Relay_In_4();
   }
   
   void Relay_OnReceiveSignal_3()
   {
      local_7_System_String = event_UnityEngine_GameObject_Signal_3;
      Relay_In_6();
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptCon_CompareString_A_4 = local_5_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_4 = Clear_string;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_4.In(logic_uScriptCon_CompareString_A_4, logic_uScriptCon_CompareString_B_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_4.Same;
      
      if ( test_0 == true )
      {
         Relay_In_10();
      }
   }
   
   void Relay_In_6()
   {
      {
         {
            logic_uScriptCon_CompareString_A_6 = local_7_System_String;
            
         }
         {
            logic_uScriptCon_CompareString_B_6 = Dead_string;
            
         }
      }
      logic_uScriptCon_CompareString_uScriptCon_CompareString_6.In(logic_uScriptCon_CompareString_A_6, logic_uScriptCon_CompareString_B_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareString_uScriptCon_CompareString_6.Same;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_In_10()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( prd_animater_previous != prd_animater || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  prd_animater_previous = prd_animater;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterBool_Target_10.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_10, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterBool_Target_10[ index++ ] = prd_animater;
            
         }
         {
            logic_uScriptAct_AnimatorSetParameterBool_Name_10 = local_13_System_String;
            
         }
         {
            logic_uScriptAct_AnimatorSetParameterBool_Value_10 = local_12_System_Boolean;
            
         }
      }
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_10.In(logic_uScriptAct_AnimatorSetParameterBool_Target_10, logic_uScriptAct_AnimatorSetParameterBool_Name_10, logic_uScriptAct_AnimatorSetParameterBool_Value_10);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_16()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( prd_animater_previous != prd_animater || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  prd_animater_previous = prd_animater;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_AnimatorSetParameterBool_Target_16.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_AnimatorSetParameterBool_Target_16, index + 1);
            }
            logic_uScriptAct_AnimatorSetParameterBool_Target_16[ index++ ] = prd_animater;
            
         }
         {
            logic_uScriptAct_AnimatorSetParameterBool_Name_16 = local_15_System_String;
            
         }
         {
         }
      }
      logic_uScriptAct_AnimatorSetParameterBool_uScriptAct_AnimatorSetParameterBool_16.In(logic_uScriptAct_AnimatorSetParameterBool_Target_16, logic_uScriptAct_AnimatorSetParameterBool_Name_16, logic_uScriptAct_AnimatorSetParameterBool_Value_16);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
