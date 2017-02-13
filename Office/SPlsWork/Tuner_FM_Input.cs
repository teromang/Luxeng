using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_TUNER_FM_INPUT
{
    public class UserModuleClass_TUNER_FM_INPUT : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput BUT_1;
        Crestron.Logos.SplusObjects.DigitalInput BUT_2;
        Crestron.Logos.SplusObjects.DigitalInput BUT_3;
        Crestron.Logos.SplusObjects.DigitalInput BUT_4;
        Crestron.Logos.SplusObjects.DigitalInput BUT_5;
        Crestron.Logos.SplusObjects.DigitalInput BUT_6;
        Crestron.Logos.SplusObjects.DigitalInput BUT_7;
        Crestron.Logos.SplusObjects.DigitalInput BUT_8;
        Crestron.Logos.SplusObjects.DigitalInput BUT_9;
        Crestron.Logos.SplusObjects.DigitalInput BUT_0;
        Crestron.Logos.SplusObjects.DigitalInput BUT_OK;
        Crestron.Logos.SplusObjects.DigitalInput BUT_CLEAR;
        Crestron.Logos.SplusObjects.StringInput FREQ_INPUT;
        Crestron.Logos.SplusObjects.StringOutput FREQ_OUTPUT;
        object BUT_1_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 15;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( FREQ_INPUT , (int)( 3 ) , (int)( 3 ) ) == "."))  ) ) 
                    { 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 19;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Mid( FREQ_INPUT , (int)( 4 ) , (int)( 4 ) ) == ".") ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 7 ) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 21;
                        FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "1"  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 23;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "." , FREQ_INPUT ) == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 25;
                            if ( Functions.TestForTrue  ( ( ((Functions.BoolToInt (Functions.Left( FREQ_INPUT , (int)( 1 ) ) == "8") | Functions.BoolToInt (Functions.Left( FREQ_INPUT , (int)( 1 ) ) == "9")) | Functions.BoolToInt (Functions.Length( FREQ_INPUT ) == 2)))  ) ) 
                                { 
                                __context__.SourceCodeLine = 27;
                                FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "1."  ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 31;
                                FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "1"  ) ; 
                                } 
                            
                            } 
                        
                        }
                    
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object BUT_2_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 39;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
                { 
                __context__.SourceCodeLine = 41;
                FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "2"  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object BUT_3_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 47;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 49;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "3"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_4_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 55;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 57;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "4"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_5_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 63;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 65;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "5"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_6_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 71;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 73;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "6"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_7_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 79;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 81;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "7"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_8_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 87;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 89;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "8"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_9_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 95;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 97;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "9"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_0_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 103;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 105;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "0"  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_OK_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FREQ_INPUT ) <= 5 ))  ) ) 
            { 
            __context__.SourceCodeLine = 113;
            FREQ_OUTPUT  .UpdateValue ( FREQ_INPUT + "."  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUT_CLEAR_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        FREQ_OUTPUT  .UpdateValue ( ""  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    BUT_1 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_1__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_1__DigitalInput__, BUT_1 );
    
    BUT_2 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_2__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_2__DigitalInput__, BUT_2 );
    
    BUT_3 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_3__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_3__DigitalInput__, BUT_3 );
    
    BUT_4 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_4__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_4__DigitalInput__, BUT_4 );
    
    BUT_5 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_5__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_5__DigitalInput__, BUT_5 );
    
    BUT_6 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_6__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_6__DigitalInput__, BUT_6 );
    
    BUT_7 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_7__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_7__DigitalInput__, BUT_7 );
    
    BUT_8 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_8__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_8__DigitalInput__, BUT_8 );
    
    BUT_9 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_9__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_9__DigitalInput__, BUT_9 );
    
    BUT_0 = new Crestron.Logos.SplusObjects.DigitalInput( BUT_0__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_0__DigitalInput__, BUT_0 );
    
    BUT_OK = new Crestron.Logos.SplusObjects.DigitalInput( BUT_OK__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_OK__DigitalInput__, BUT_OK );
    
    BUT_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( BUT_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( BUT_CLEAR__DigitalInput__, BUT_CLEAR );
    
    FREQ_INPUT = new Crestron.Logos.SplusObjects.StringInput( FREQ_INPUT__AnalogSerialInput__, 10, this );
    m_StringInputList.Add( FREQ_INPUT__AnalogSerialInput__, FREQ_INPUT );
    
    FREQ_OUTPUT = new Crestron.Logos.SplusObjects.StringOutput( FREQ_OUTPUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FREQ_OUTPUT__AnalogSerialOutput__, FREQ_OUTPUT );
    
    
    BUT_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_1_OnPush_0, false ) );
    BUT_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_2_OnPush_1, false ) );
    BUT_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_3_OnPush_2, false ) );
    BUT_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_4_OnPush_3, false ) );
    BUT_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_5_OnPush_4, false ) );
    BUT_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_6_OnPush_5, false ) );
    BUT_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_7_OnPush_6, false ) );
    BUT_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_8_OnPush_7, false ) );
    BUT_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_9_OnPush_8, false ) );
    BUT_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_0_OnPush_9, false ) );
    BUT_OK.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_OK_OnPush_10, false ) );
    BUT_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUT_CLEAR_OnPush_11, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_TUNER_FM_INPUT ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint BUT_1__DigitalInput__ = 0;
const uint BUT_2__DigitalInput__ = 1;
const uint BUT_3__DigitalInput__ = 2;
const uint BUT_4__DigitalInput__ = 3;
const uint BUT_5__DigitalInput__ = 4;
const uint BUT_6__DigitalInput__ = 5;
const uint BUT_7__DigitalInput__ = 6;
const uint BUT_8__DigitalInput__ = 7;
const uint BUT_9__DigitalInput__ = 8;
const uint BUT_0__DigitalInput__ = 9;
const uint BUT_OK__DigitalInput__ = 10;
const uint BUT_CLEAR__DigitalInput__ = 11;
const uint FREQ_INPUT__AnalogSerialInput__ = 0;
const uint FREQ_OUTPUT__AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
