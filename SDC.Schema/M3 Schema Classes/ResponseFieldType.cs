// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;

/// <summary>
/// This type is a template for a data entry field that accepts entries (responses or answers) of any data type, including text, numbers, dates, and Base 64 - encoded blobs (images, sounds, video, other binary formats, etc.).  This type cannot contain ListItems, but it may be a child of a Question or a ListItem.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ListItemResponseFieldType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class ResponseFieldType : ExtensionBaseType
{
    
    #region Private fields
    [EditorBrowsable(EditorBrowsableState.Never)]
    private DataTypes_DEType _response;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private AnyFunctionsAnyType _setValue;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<ExtensionType> _x_Extension;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private RichTextType _textAfterResponse;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private UnitsType _responseUnits;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<EventType> _afterChange;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    private List<OnEventType> _onEvent;
    
    private static XmlSerializer serializer;
    #endregion
    
    /// <summary>
    /// W3C Schema data type details
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual DataTypes_DEType Response
    {
        get
        {
            return this._response;
        }
        set
        {
            this._response = value;
        }
    }
    
    /// <summary>
    /// NEW
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual AnyFunctionsAnyType SetValue
    {
        get
        {
            return this._setValue;
        }
        set
        {
            this._setValue = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("X_Extension", Order=2)]
    public virtual List<ExtensionType> X_Extension
    {
        get
        {
            return this._x_Extension;
        }
        set
        {
            this._x_Extension = value;
        }
    }
    
    /// <summary>
    /// TextAfterResponse is fixed text that appears after (to the right of) the user's response on the data entry form.  This may be text for units such as "mm", "cm", etc.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public virtual RichTextType TextAfterResponse
    {
        get
        {
            return this._textAfterResponse;
        }
        set
        {
            this._textAfterResponse = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public virtual UnitsType ResponseUnits
    {
        get
        {
            return this._responseUnits;
        }
        set
        {
            this._responseUnits = value;
        }
    }
    
    /// <summary>
    /// Event that occurs after the Response value is changed, usually fired after a user leaves the Response field.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("AfterChange", Order=5)]
    public virtual List<EventType> AfterChange
    {
        get
        {
            return this._afterChange;
        }
        set
        {
            this._afterChange = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("OnEvent", Order=6)]
    public virtual List<OnEventType> OnEvent
    {
        get
        {
            return this._onEvent;
        }
        set
        {
            this._onEvent = value;
        }
    }
    
    private static XmlSerializer Serializer
    {
        get
        {
            if ((serializer == null))
            {
                serializer = new XmlSerializerFactory().CreateSerializer(typeof(ResponseFieldType));
            }
            return serializer;
        }
    }
    
    /// <summary>
    /// Test whether X_Extension should be serialized
    /// </summary>
    public virtual bool ShouldSerializeX_Extension()
    {
        return X_Extension != null && X_Extension.Count > 0;
    }
    
    /// <summary>
    /// Test whether AfterChange should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAfterChange()
    {
        return AfterChange != null && AfterChange.Count > 0;
    }
    
    /// <summary>
    /// Test whether OnEvent should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOnEvent()
    {
        return OnEvent != null && OnEvent.Count > 0;
    }
    
    /// <summary>
    /// Test whether Response should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponse()
    {
        return (_response != null);
    }
    
    /// <summary>
    /// Test whether SetValue should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSetValue()
    {
        return (_setValue != null);
    }
    
    /// <summary>
    /// Test whether TextAfterResponse should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTextAfterResponse()
    {
        return (_textAfterResponse != null);
    }
    
    /// <summary>
    /// Test whether ResponseUnits should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponseUnits()
    {
        return (_responseUnits != null);
    }
    
    #region Serialize/Deserialize
    /// <summary>
    /// Serializes current ResponseFieldType object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize(System.Text.Encoding encoding)
    {
        System.IO.StreamReader streamReader = null;
        System.IO.MemoryStream memoryStream = null;
        try
        {
            memoryStream = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
            xmlWriterSettings.Encoding = encoding;
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = " ";
            System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
            Serializer.Serialize(xmlWriter, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            streamReader = new System.IO.StreamReader(memoryStream, encoding);
            return streamReader.ReadToEnd();
        }
        finally
        {
            if ((streamReader != null))
            {
                streamReader.Dispose();
            }
            if ((memoryStream != null))
            {
                memoryStream.Dispose();
            }
        }
    }
    
    public virtual string Serialize()
    {
        return Serialize(System.Text.Encoding.UTF8);
    }
    
    /// <summary>
    /// Deserializes workflow markup into an ResponseFieldType object
    /// </summary>
    /// <param name="input">string workflow markup to deserialize</param>
    /// <param name="obj">Output ResponseFieldType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string input, out ResponseFieldType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ResponseFieldType);
        try
        {
            obj = Deserialize(input);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool Deserialize(string input, out ResponseFieldType obj)
    {
        System.Exception exception = null;
        return Deserialize(input, out obj, out exception);
    }
    
    public new static ResponseFieldType Deserialize(string input)
    {
        System.IO.StringReader stringReader = null;
        try
        {
            stringReader = new System.IO.StringReader(input);
            return ((ResponseFieldType)(Serializer.Deserialize(XmlReader.Create(stringReader))));
        }
        finally
        {
            if ((stringReader != null))
            {
                stringReader.Dispose();
            }
        }
    }
    
    public static ResponseFieldType Deserialize(System.IO.Stream s)
    {
        return ((ResponseFieldType)(Serializer.Deserialize(s)));
    }
    #endregion
    
    /// <summary>
    /// Serializes current ResponseFieldType object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
    {
        exception = null;
        try
        {
            SaveToFile(fileName, encoding);
            return true;
        }
        catch (System.Exception e)
        {
            exception = e;
            return false;
        }
    }
    
    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
        return SaveToFile(fileName, System.Text.Encoding.UTF8, out exception);
    }
    
    public virtual void SaveToFile(string fileName)
    {
        SaveToFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.StreamWriter streamWriter = null;
        try
        {
            string xmlString = Serialize(encoding);
            streamWriter = new System.IO.StreamWriter(fileName, false, encoding);
            streamWriter.WriteLine(xmlString);
            streamWriter.Close();
        }
        finally
        {
            if ((streamWriter != null))
            {
                streamWriter.Dispose();
            }
        }
    }
    
    /// <summary>
    /// Deserializes xml markup from file into an ResponseFieldType object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output ResponseFieldType object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out ResponseFieldType obj, out System.Exception exception)
    {
        exception = null;
        obj = default(ResponseFieldType);
        try
        {
            obj = LoadFromFile(fileName, encoding);
            return true;
        }
        catch (System.Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public static bool LoadFromFile(string fileName, out ResponseFieldType obj, out System.Exception exception)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8, out obj, out exception);
    }
    
    public static bool LoadFromFile(string fileName, out ResponseFieldType obj)
    {
        System.Exception exception = null;
        return LoadFromFile(fileName, out obj, out exception);
    }
    
    public static ResponseFieldType LoadFromFile(string fileName)
    {
        return LoadFromFile(fileName, System.Text.Encoding.UTF8);
    }
    
    public new static ResponseFieldType LoadFromFile(string fileName, System.Text.Encoding encoding)
    {
        System.IO.FileStream file = null;
        System.IO.StreamReader sr = null;
        try
        {
            file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
            sr = new System.IO.StreamReader(file, encoding);
            string xmlString = sr.ReadToEnd();
            sr.Close();
            file.Close();
            return Deserialize(xmlString);
        }
        finally
        {
            if ((file != null))
            {
                file.Dispose();
            }
            if ((sr != null))
            {
                sr.Dispose();
            }
        }
    }
}
}
#pragma warning restore
