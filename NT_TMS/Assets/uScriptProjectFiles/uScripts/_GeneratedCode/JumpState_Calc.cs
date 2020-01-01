//uScript Generated Code - Build 1.0.3114
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("JumpState_Calc", "")]
public class JumpState_Calc : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   [FriendlyName("out_0")]
   public event uScriptEventHandler out_0;
   [FriendlyName("out_1")]
   public event uScriptEventHandler out_1;
   [FriendlyName("out_2")]
   public event uScriptEventHandler out_2;
   [FriendlyName("out_3")]
   public event uScriptEventHandler out_3;
   
   //external parameters
   UnityEngine.GameObject external_3 = default(UnityEngine.GameObject);
   
   //local nodes
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_1 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_1 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_1 = (int) 2;
   bool logic_uScriptCon_CompareInt_GreaterThan_1 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_1 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_1 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_1 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_1 = true;
   bool logic_uScriptCon_CompareInt_LessThan_1 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_4 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_4 = (int) 0;
   bool logic_uScriptCon_CompareInt_GreaterThan_4 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_4 = true;
   bool logic_uScriptCon_CompareInt_LessThan_4 = true;
   
   //event nodes
   
   //property nodes
   System.Int32 property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_0 = (int) 0;
   
   //method nodes
   #pragma warning restore 414
   public delegate void uScriptEventHandler(object sender, LogicEventArgs args);
   
   public class LogicEventArgs : System.EventArgs
   {
   }
   
   //functions to refresh properties from entities
   System.Int32 property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_0_Get_Refresh( )
   {
      Jump_Judge_Col_Component component = null;
      if (external_3 != null)
      {
         component = external_3.GetComponent<Jump_Judge_Col_Component>();
      }
      if ( null != component )
      {
         return component.Jump_Judge_state;
      }
      else
      {
         return (int) 0;
      }
   }
   
   void property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_0_Set_Refresh( )
   {
      Jump_Judge_Col_Component component = null;
      if (external_3 != null)
      {
         component = external_3.GetComponent<Jump_Judge_Col_Component>();
      }
      if ( null != component )
      {
         component.Jump_Judge_state = property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_0;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_1.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.SetParent(g);
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
   
   [FriendlyName("JumpState_Calc_in", "")]
   public void JumpState_Calc_in( [FriendlyName("JumpJudgeCol_obj", "")] UnityEngine.GameObject JumpJudgeCol_obj )
   {
      
      external_3 = JumpJudgeCol_obj;
      Relay_In_1( );
   }
   
   void Relay_In_1()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_1 = property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_0_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_1.In(logic_uScriptCon_CompareInt_A_1, logic_uScriptCon_CompareInt_B_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_1.GreaterThan;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_1.EqualTo;
      bool test_2 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_1.LessThan;
      
      if ( test_0 == true )
      {
         Relay_Connection_8();
      }
      if ( test_1 == true )
      {
         Relay_Connection_6();
      }
      if ( test_2 == true )
      {
         Relay_In_4();
      }
   }
   
   void Relay_Connection_2()
   {
   }
   
   void Relay_Connection_3()
   {
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptCon_CompareInt_A_4 = property_Jump_Judge_state_Detox_ScriptEditor_Parameter_Jump_Judge_state_0_Get_Refresh( );
         }
         {
         }
      }
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.In(logic_uScriptCon_CompareInt_A_4, logic_uScriptCon_CompareInt_B_4);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.GreaterThan;
      bool test_1 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_4.EqualTo;
      
      if ( test_0 == true )
      {
         Relay_Connection_7();
      }
      if ( test_1 == true )
      {
         Relay_Connection_5();
      }
   }
   
   void Relay_Connection_5()
   {
      if ( out_0 != null )
      {
         LogicEventArgs eventArgs = new LogicEventArgs( );
         out_0( this, eventArgs );
      }
   }
   
   void Relay_Connection_6()
   {
      if ( out_2 != null )
      {
         LogicEventArgs eventArgs = new LogicEventArgs( );
         out_2( this, eventArgs );
      }
   }
   
   void Relay_Connection_7()
   {
      if ( out_1 != null )
      {
         LogicEventArgs eventArgs = new LogicEventArgs( );
         out_1( this, eventArgs );
      }
   }
   
   void Relay_Connection_8()
   {
      if ( out_3 != null )
      {
         LogicEventArgs eventArgs = new LogicEventArgs( );
         out_3( this, eventArgs );
      }
   }
   
}
